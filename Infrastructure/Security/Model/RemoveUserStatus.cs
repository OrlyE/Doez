﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Security.Model
{
    public enum RemoveUserStatus
    {
        Success = 1,
        UserNotFound,
        ProviderError
    }
}
