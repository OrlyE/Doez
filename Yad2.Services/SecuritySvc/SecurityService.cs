using Infrastructure.Domain;
using Infrastructure.Helpers;
using Infrastructure.Security.Interfaces;
using Infrastructure.Security.Model;
using Infrastructure.Web.Security.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Yad2.EFRepositories;
using Yad2.Model.Entities.BaseEntities;

namespace Yad2.Services.SecuritySvc

{
    public class SecurityService : ISecurityService
    {
        IRepository<Seller, int> _iSellerRepository;
        IRepository<UserBase, int> _iUserRepository;
        IRepository<UsersGroupBase, int> _iUsersGroupRepository;
   //     IRepository<UserInGroup, UserInGroup> _iUserInGroupRepository;
        ICurrentSessionUser _iCurrentSessionUser;

        byte[] hashSalt = StringBytesHelper.GetBytes(DateTime.Now.ToString());
        string hashAlgorithmName = "SHA1";

        public SecurityService(IRepository<Seller, int> sellerRepository, IRepository<UserBase, int> userRepository, ICurrentSessionUser currentSessionUser,
                            IRepository<UsersGroupBase, int> usersGroupRepository //IRepository<UserInGroup, UserInGroup> userInGroupRepository
            )
        {
            this._iSellerRepository = sellerRepository;
            this._iUserRepository = userRepository;
            this._iCurrentSessionUser = currentSessionUser;
      //      this._iUserInGroupRepository = userInGroupRepository;
            this._iUsersGroupRepository = usersGroupRepository;
        }

        public UserBase Authenticate(string Username, string Password)
        {
            UserBase user = GetUser(Username);
            if (user != null)
            {
                user.UserGroups = GetGroupsOfUser(user.Id).ToList();
                if (HashHelper.VerifyHash(Password, hashAlgorithmName, user.PasswordHash) && user.IsActive)
                {
                    bool isSuccess = HashHelper.VerifyHash("1234", hashAlgorithmName, user.PasswordHash);

                    _iCurrentSessionUser.SignIn(user,false);
                    return user;
                }
            }

            return null;
        }
        public UserBase Authenticate(UserBase User)
        {
            if (User != null)
            {
                _iCurrentSessionUser.SignIn(User, false);
            }

            return User;
        }

        public UserBase GetUser()
        {
            return GetUser(_iCurrentSessionUser.GetUserName());
        }

        public UserBase GetUser(int Id)
        {
            return EFContext.Get().Users.FirstOrDefault(u => u.Id == Id);
        }

        public UserBase GetUser(string Username)
        {
            return EFContext.Get().Users.FirstOrDefault(u => u.UserName.ToLower() == Username.ToLower());
        }

        public bool SetNewPasswordForUser(string password)
        {
            return SetNewPasswordForUser(GetUser().Id, password);
        }

        public bool SetNewPasswordForUser(int Id, string password)
        {
            UserBase user = GetUser(Id) as UserBase;
            try
            {
                user.PasswordHash = HashHelper.ComputeHash(password, hashAlgorithmName, hashSalt);
                UserBase existing = EFContext.Get().Set<UserBase>().Find(user.Id);
                if (existing != null)
                {
                    EFContext.Get().Entry(existing).CurrentValues.SetValues(user);
                    EFContext.Get().SaveChanges();
                }

            }
            catch (Exception ex)
            {
                // todo: log ex
                return false;
            }
            return true;
        }


        public IEnumerable<UsersGroupBase> GetGroupsOfUser()
        {
            return GetUser().UserGroups;
        }

        public IEnumerable<UsersGroupBase> GetGroupsOfUser(int Id)
        {
            return GetUser(Id).UserGroups;
        }

        public IEnumerable<UserBase> GetUsersInGroup(string GroupName)
        {
            UsersGroupBase group = EFContext.Get().UsersGroups.FirstOrDefault(g => g.Name == GroupName);
            //if (group != null)
            //{
            //    IEnumerable<UserInGroup> usersInGroupOnlyId = EFContext.Get().UsersInGroups.Where(uig => uig.GroupId == group.Id);
            //    List<UserBase> usersOfGroup = new List<UserBase>();
            //    foreach (UserInGroup uig in usersInGroupOnlyId)
            //    {
            //        usersOfGroup.Add(EFContext.Get().Users.FirstOrDefault(u => u.Id == uig.UserId));
            //    }

            //    return usersOfGroup;
            //}
            //return null;
            return group.Users;
        }




        public SaveUserStatus CreateUser(UserBase User)
        { 
            if (User != null)
            {
                IEnumerable<BusinessRule> userBrokenRules = User.GetBrokenRules();
                if (userBrokenRules.Count() == 0)
                {
                    foreach (UserBase user in EFContext.Get().Users)
                    {
                        if (user.UserName.ToLower() == User.UserName.ToLower()) return SaveUserStatus.DuplicateUserName;
                        if (user.Email.ToLower() == User.Email.ToLower()) return SaveUserStatus.DuplicateEmail;
                    }
                    try
                    {
                        EFContext.Get().Users.Add(User);
                        EFContext.Get().SaveChanges();
                    }

                    catch (Exception ex)
                    {
                        // log Ex
                        return SaveUserStatus.ProviderError;
                    }
                    return SaveUserStatus.Success;
                }
                else
                {
                    if (userBrokenRules.FirstOrDefault(br => br.Property == "UserName") != null) return SaveUserStatus.InvalidUsername;
                    if (userBrokenRules.FirstOrDefault(br => br.Property == "Email") != null) return SaveUserStatus.InvalidEmail;
                }
            }
           
            return SaveUserStatus.UserIsNullOrTypeError;
        }

        public SaveUsersGroupStatus CreateUsersGroup(UsersGroupBase UsersGroup)
        {
            if (UsersGroup != null)
            {
                IEnumerable<BusinessRule> groupBrokenRules = UsersGroup.GetBrokenRules();
                if (groupBrokenRules.Count() == 0)
                {
                    if (EFContext.Get().UsersGroups.FirstOrDefault(g => g.Name == UsersGroup.Name) != null) return SaveUsersGroupStatus.DuplicateGroupName;
                    try
                    {
                        EFContext.Get().UsersGroups.Add(UsersGroup);
                        EFContext.Get().SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        // log Ex
                        return SaveUsersGroupStatus.ProviderError;
                    }
                    return SaveUsersGroupStatus.Success;
                }
                else
                {
                    if (groupBrokenRules.FirstOrDefault(br => br.Property == "Name") != null) return SaveUsersGroupStatus.InvalidGroupName;
                }
            }

            return SaveUsersGroupStatus.UsersGroupIsNullOrTypeError;
        }

        public SaveUserStatus SaveUser(UserBase User)
        {
            if (User != null)
            {
                IEnumerable<BusinessRule> userBrokenRules = User.GetBrokenRules();
                if (userBrokenRules.Count() == 0)
                {
                    foreach (UserBase user in EFContext.Get().Users)
                    {
                        if (user.Id != User.Id && user.UserName.ToLower() == User.UserName.ToLower()) return SaveUserStatus.DuplicateUserName;
                        if (user.Id != User.Id && user.Email.ToLower() == User.Email.ToLower()) return SaveUserStatus.DuplicateEmail;
                    }
                    try
                    {
                        UserBase existing = EFContext.Get().Set<UserBase>().Find(User.Id);
                        EFContext.Get().Entry(existing).CurrentValues.SetValues(User);
                        EFContext.Get().SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        // log Ex
                        return SaveUserStatus.ProviderError;
                    }
                    return SaveUserStatus.Success;
                }
                else
                {
                    if (userBrokenRules.FirstOrDefault(br => br.Property == "UserName") != null) return SaveUserStatus.InvalidUsername;
                    if (userBrokenRules.FirstOrDefault(br => br.Property == "Email") != null) return SaveUserStatus.InvalidEmail;
                }
            }

            return SaveUserStatus.UserIsNullOrTypeError;
        }

        public SaveUsersGroupStatus SaveUsersGroup(UsersGroupBase UsersGroup)
        {
            if (UsersGroup != null)
            {
                IEnumerable<BusinessRule> groupBrokenRules = UsersGroup.GetBrokenRules();
                if (groupBrokenRules.Count() == 0)
                {
                    if (EFContext.Get().UsersGroups.FirstOrDefault(g => g.Name == UsersGroup.Name) != null) return SaveUsersGroupStatus.DuplicateGroupName;
                    try
                    {
                        
                        UsersGroupBase existing = EFContext.Get().Set<UsersGroupBase>().Find(UsersGroup.Id);
                        EFContext.Get().Entry(existing).CurrentValues.SetValues(UsersGroup);
                        EFContext.Get().SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        // log Ex
                        return SaveUsersGroupStatus.ProviderError;
                    }
                    return SaveUsersGroupStatus.Success;
                }
                else
                {
                    if (groupBrokenRules.FirstOrDefault(br => br.Property == "Name") != null) return SaveUsersGroupStatus.InvalidGroupName;
                }
            }

            return SaveUsersGroupStatus.UsersGroupIsNullOrTypeError;
        }

        public RemoveUserStatus RemoveUser(UserBase User)
        {
            if (User != null)
            {
                try
                {
                    EFContext.Get().Set<UserBase>().Remove(User);
                    EFContext.Get().SaveChanges();
                }
                catch (Exception ex)
                {
                    // log Ex
                    return RemoveUserStatus.ProviderError;
                }
                return RemoveUserStatus.Success;
            }
            return RemoveUserStatus.UserNotFound;
        }

        public RemoveUsersGroupStatus RemoveUsersGroup(UsersGroupBase UsersGroup)
        {
            if (UsersGroup != null)
            {
                try
                {
                    EFContext.Get().Set<UsersGroupBase>().Remove(UsersGroup);
                    EFContext.Get().SaveChanges();
                }
                catch (Exception ex)
                {
                    // log Ex
                    return RemoveUsersGroupStatus.ProviderError;
                }
                return RemoveUsersGroupStatus.Success;
            }
            return RemoveUsersGroupStatus.GroupNotFound;
        }


        public AddUserToGroupStatus AddUserToGroup(UserBase User, string GroupName)
        {
            if (User == null) return AddUserToGroupStatus.UserNotFound;

            UsersGroupBase group = EFContext.Get().UsersGroups.FirstOrDefault(g => g.Name == GroupName);
            if (group == null) return AddUserToGroupStatus.GroupNameNotFound;


            //IEnumerable<UserInGroup> allUsersInGroupOnlyId = EFContext.Get().UsersInGroups.Where(uig => uig.GroupId == group.Id);
            //foreach (UserInGroup uig in allUsersInGroupOnlyId)
            //    if (uig.UserId == User.Id) return AddUserToGroupStatus.UserAlreadyInGroup;

            try
            {
                //EFContext.Get().UsersInGroups.Add(new UserInGroup() { UserId = User.Id, GroupId = group.Id });
                group.Users.Add(User);
                EFContext.Get().SaveChanges();
            }
            catch (Exception ex)
            {
                // log Ex
                return AddUserToGroupStatus.ProviderError;
            }

            return AddUserToGroupStatus.Success;
        }

        public RemoveUserFromGroupStatus RemoveUserFromGroup(UserBase User, string GroupName)
        {
            if (User == null) return RemoveUserFromGroupStatus.UserNotFound;
           
            UsersGroupBase group = EFContext.Get().UsersGroups.FirstOrDefault(g => g.Name == GroupName);
            if (group == null) return RemoveUserFromGroupStatus.GroupNameNotFound;

            try
            {
                //UserInGroup uig = EFContext.Get().UsersInGroups.FirstOrDefault(ug => ug.GroupId == group.Id && ug.UserId == User.Id);
               var user = group.Users.FirstOrDefault(u => u.Id == User.Id );
                if (user != null )// uig != null)
                {
                    group.Users.Remove(User);
                    EFContext.Get().SaveChanges();
                }
                else return RemoveUserFromGroupStatus.UserWasNotInGroup;
              
            }
            catch (Exception ex)
            {
                // log Ex
                return RemoveUserFromGroupStatus.ProviderError;
            }

            return RemoveUserFromGroupStatus.Success;
        }


        public void SignOut()
        {
            _iCurrentSessionUser.SignOut();
        }


        public bool IsUserInGroup(string groupName)
        {
            if (GetUser() != null)
            {
                foreach (UsersGroupBase group in GetUser().UserGroups)
                    if (group.Name == groupName) return true;
            }
            return false;
        }

        public bool IsUserInGroup(int UserId, string groupName)
        {
            if (GetUser(UserId) != null)
            {
                foreach (UsersGroupBase group in GetUser(UserId).UserGroups)
                    if (group.Name == groupName) return true;
            }
            return false;
        }
    }
}
