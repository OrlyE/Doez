using Infrastructure.Security.Model;
using Infrastructure.Web.Security.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.EFRepositories;
using Yad2.Services.Interfaces;
using Yad2.Services.Messages.SellerServiceMessages;

namespace Yad2.Services.Implementations
{
    public interface IAccountDTL
    {
        GetSellerDTLResponse GetSellerDtl(GetSellerDTLRequest request);

        UpdateSellerDTLResponse UpdateSeller(UpdateSellerDTLRequest request);
        SetUserPasswordResponse SetUserPassword(SetUserPasswordRequest request);
        CreateSellerResponse CreateSeller(CreateSellerRequest request);
        UserBase CreatTempUser();

    }
}
