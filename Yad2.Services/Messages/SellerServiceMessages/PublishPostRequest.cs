﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2.Services.Messages.SellerServiceMessages
{
    public class PublishPostRequest<T>
    {
        public T Post { get; set; }
        public int UserId { get; set; }
    }
}
