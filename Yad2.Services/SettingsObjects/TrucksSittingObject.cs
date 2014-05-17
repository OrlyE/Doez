﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Model.Entities;
using Yad2.Services.Interfaces;

namespace Yad2.Services.SettingsObjects
{
    public class TrucksSittingObject : SettingsObjectBase, ISettingsObj<Trucks>
    {
        public IEnumerable<ListItem> Manufacturers { get; set; }
        public IEnumerable<ListItem> Models { get; set; }

        public IEnumerable<ListItem> Pics { get; set; }
    }
}