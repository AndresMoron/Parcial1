﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AndresMoronFriend.Models
{
    public class DataContext : DbContext

    {
        public DataContext() : base("DefaultConnection");
    }
}