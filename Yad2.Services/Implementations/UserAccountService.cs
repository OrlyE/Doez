using Infrastructure.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.EFRepositories;
using Yad2.Model.Entities;
using Yad2.Model.Entities.BaseEntities;
using Yad2.Services.Messages.SellerServiceMessages;
using Ninject;
using Infrastructure.Domain;
using Infrastructure.Web.Security.Interfaces;
using Infrastructure.Security.Interfaces;
using Yad2.Services.Interfaces;
using Yad2.Services.SettingsObjects;

namespace Yad2.Services.Implementations
{
    public class UserAccountService : IAccountDTL
    {
        //IRepository<Seller, int> _iSellerRepository;
        ICurrentSessionUser _iCurrentSessionUser;
        ISecurityService _iSecurityService;
        IRepository<UserBase, int> _userRepo;
        IRepository<Seller, int> _sellerRepo;
        IRepository<UsersGroupBase, int> _usersGroupRepo;
        public UserAccountService(IRepository<Seller, int> sellerRepository, ICurrentSessionUser currentSessionUser, ISecurityService securityService,
                                  IRepository<UserBase, int> userRepository, IRepository<UsersGroupBase, int> usersGroupRepository)
        {
            //this._iSellerRepository = sellerRepository;
            this._iCurrentSessionUser = currentSessionUser;
            this._iSecurityService = securityService;
            _userRepo = userRepository;
            _sellerRepo = sellerRepository;
            _usersGroupRepo = usersGroupRepository;
        }


        public UserBase CreatTempUser()
        {

            bool isPassSet;
            UserBase user = EFContext.Get().Users.FirstOrDefault(u => u.UserName == "Shuki");
            isPassSet = _iSecurityService.SetNewPasswordForUser(user.Id, "1234");
            EFContext.Get().SaveChanges();

            return user;
        }

        public GetSellerDTLResponse GetSellerDtl(GetSellerDTLRequest request)
        {
            GetSellerDTLResponse response = new GetSellerDTLResponse()
            {
                Success = true,
                Message = "Success"

            };
            //if (!string.IsNullOrEmpty(request.UserName))
            if (request.User != null)
            {
                // UserBase User = EFContext.Get().Users.FirstOrDefault(u => u.Id == request.User.Id);
                Seller seller = EFContext.Get().Sellers.FirstOrDefault(s => s.User.Email == request.User.Email);

                response.Seller = new ViewModels.SellerModel();
                response.Seller.Id = seller.Id;
                response.Seller.Name = seller.Name;
                response.Seller.Phone1 = seller.Phone1;
                response.Seller.Phone2 = seller.Phone2;
                response.Seller.FullAddress = seller.FullAddress;
                response.Seller.Email = seller.User.Email;

            }
            else
            {
                response.Success = false;
                response.Message = "User is null";
            }
            return response;

        }


        public UpdateSellerDTLResponse UpdateSeller(UpdateSellerDTLRequest request)
        {
            UpdateSellerDTLResponse response = new UpdateSellerDTLResponse();
            {
                response.Success = true;
                response.Message = "Success";
            };

           // request.Seller = new ViewModels.SellerModel();

            UserBase userConnected = _iSecurityService.GetUser();
            Seller existSeller = _sellerRepo.FindAll().FirstOrDefault(s => s.Id == request.Seller.Id);

            if (existSeller.User.Id == userConnected.Id)
            {
               // existSeller.Id == request.Seller.Id;
                try
                {
                    existSeller.Name = request.Seller.Name;
                    existSeller.Phone1 = request.Seller.Phone1;
                    existSeller.Phone2 = request.Seller.Phone2;
                    existSeller.FullAddress = request.Seller.FullAddress;
                    existSeller.Phone2 = request.Seller.Phone2;
                    existSeller.User.Email = request.Seller.Email;
                    //existSeller.User.Email = request.User.Email;

                    response.Seller = new ViewModels.SellerModel();
                    response.Seller = request.Seller;

                    //_userRepo.Update(existUser);
                    //EFContext.Get().Users.Add(existUser);
                    _sellerRepo.Update(existSeller);
                    EFContext.Get().Sellers.Add(existSeller);

                }

                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = ex.Message;
                }


            }
            else
            {
                response.Success = false;
                response.Message = "user is not connected";
            }

            return response;
        }


        public SetUserPasswordResponse SetUserPassword(SetUserPasswordRequest request)
        {
            SetUserPasswordResponse response = new SetUserPasswordResponse();
            {
                response.Success = true;
                response.Message = "Success";
            };

            UserBase user = _iSecurityService.GetUser();
            if (user == null)
            {
                UserBase currentUser = EFContext.Get().Users.FirstOrDefault(u => u.Id == user.Id);
                if (currentUser == null)
                {
                    response.Success = false;
                    response.Message = "No user found";
                }
                try
                {
                    if (request.confirmPassword == request.password)
                    {
                        bool isPassSet;
                        isPassSet = _iSecurityService.SetNewPasswordForUser(user.Id, request.password);
                        if (!isPassSet)
                        {
                            response.Success = false;
                            response.Message = "error in set password data";
                        }

                    }
                    else throw new ApplicationException("password dosent match");
                }

                catch (Exception ex)
                {

                    response.Success = false;
                    response.Message = ex.Message;
                }
            }
            else
            {
                response.Success = false;
                response.Message = "No user is connected";
            }

            return response;
        }


        public CreateSellerResponse CreateSeller(CreateSellerRequest request)
        {
            CreateSellerResponse response = new CreateSellerResponse();
            {
                response.Success = true;
                response.Message = "Success";
            };

            Seller seller = new Seller();
            try
            {
                if (request.User.Id == null)
                {
                    //creat user in Sellers group:
                    UsersGroupBase usersGroup = EFContext.Get().UsersGroups.FirstOrDefault(uig => uig.Name == "Sellers");
                    if (usersGroup != null)
                    {

                        usersGroup.Users = new List<UserBase>();
                        usersGroup.Users.Add(new UserBase()
                        {
                            UserName = request.User.Email,
                            Created = DateTime.Now,
                            Email = request.User.Email,
                            IsActive = true,
                            LastVisited = DateTime.Now,
                            PasswordHash = "",
                            HasToChangePass = false,
                        });

                        //adding to repository & dbset:
                        _usersGroupRepo.Add(usersGroup);
                        EFContext.Get().UsersGroups.Add(usersGroup);
                    }

                    UserBase user = EFContext.Get().Users.FirstOrDefault(u => u.Email == request.User.Email);
                    if (user != null)
                    {
                        if (request.Pass == request.PassConfirm)
                        {
                            bool isPassSet;
                            isPassSet = _iSecurityService.SetNewPasswordForUser(user.Id, request.Pass);
                            if (!isPassSet)
                            {
                                response.Success = false;
                                response.Message = "error in set password data";
                            }

                        }
                    }
                    //creat seller for regular-user:
                    seller.Name = request.Seller.Name;
                    seller.Phone1 = request.Seller.Phone1;
                    seller.Phone2 = request.Seller.Phone2;
                    seller.FullAddress = request.Seller.FullAddress;
                    seller.UserId = user.Id;
                    _sellerRepo.Add(seller);
                    EFContext.Get().Sellers.Add(seller);
                }
                else
                {
                    //creat seller for facebook-user:
                    seller.Name = request.Seller.Name;
                    seller.Phone1 = request.Seller.Phone1;
                    seller.Phone2 = request.Seller.Phone2;
                    seller.FullAddress = request.Seller.FullAddress;
                    seller.UserId = request.User.Id;

                    _sellerRepo.Add(seller);
                    EFContext.Get().Sellers.Add(seller);
                }
            }
            catch (Exception ex)
            {
                // response.seller = seller;
                response.Success = false;
                response.Message = ex.Message;
            }
            // response.seller = seller;

            //connecting user:
            if (request.Pass != null)
            {
                _iSecurityService.Authenticate(seller.User.UserName, request.Pass);
            }
            else
                _iSecurityService.Authenticate(seller.User);



            return response;
        }
        public CreateSellerResponse CreateFaceBookSeller(CreateSellerRequest request)
        {
            CreateSellerResponse response = new CreateSellerResponse();
            {
                response.Success = true;
                response.Message = "Success";
            };
            return response;
        }
    }
}
