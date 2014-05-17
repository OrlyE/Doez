﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Security.Model;
using Yad2.Model.Entities.BaseEntities;

namespace Yad2.Services.Messages.SellerService
{
    public class CreateSellerRequest
    {
        public UserBase User { get; set; }
        public Seller Seller { get; set; }
        public string Pass { get; set; }
        public string PassConfirm { get; set; }
    }
}
