﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.Messages.SellerService
{
    public class AddPostResponse<T> : MessageBase
    {
        public T Post { get; set; }
    }
}
