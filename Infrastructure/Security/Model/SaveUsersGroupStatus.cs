using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Security.Model
{
    public enum SaveUsersGroupStatus
    {
        Success = 1,
        DuplicateGroupName,
        InvalidGroupName,
        UsersGroupIsNullOrTypeError,
        ProviderError
    }
}
