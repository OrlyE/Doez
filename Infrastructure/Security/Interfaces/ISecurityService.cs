using Infrastructure.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Security.Interfaces
{
    public interface ISecurityService
    {
        UserBase Authenticate(string Username, string Password);
        UserBase Authenticate(UserBase User);
        void SignOut();
        UserBase GetUser();
        UserBase GetUser(int Id);
        UserBase GetUser(string Username);
        bool SetNewPasswordForUser(string password);
        bool SetNewPasswordForUser(int Id, string password);
        IEnumerable<UsersGroupBase> GetGroupsOfUser();
        IEnumerable<UsersGroupBase> GetGroupsOfUser(int Id);
        IEnumerable<UserBase> GetUsersInGroup(string GroupName);
        SaveUserStatus CreateUser(UserBase User);
        SaveUsersGroupStatus CreateUsersGroup(UsersGroupBase UsersGroup);
        SaveUserStatus SaveUser(UserBase User);
        SaveUsersGroupStatus SaveUsersGroup(UsersGroupBase UsersGroup);
        RemoveUserStatus RemoveUser(UserBase User);
        RemoveUsersGroupStatus RemoveUsersGroup(UsersGroupBase UsersGroup);
        AddUserToGroupStatus AddUserToGroup(UserBase User, string GroupName);
        RemoveUserFromGroupStatus RemoveUserFromGroup(UserBase User, string GroupName);
        bool IsUserInGroup(string groupName);
        bool IsUserInGroup(int UserId, string groupName);
    }
}
