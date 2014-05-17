using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Security.Model
{
    public enum SaveUserStatus
    {
        Success = 1,
        DuplicateEmail,
        DuplicateUserName,
        InvalidEmail,
        InvalidUsername,
        UserIsNullOrTypeError,
        ProviderError
    }
}
