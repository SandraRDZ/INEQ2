﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ2.DAL
{
    public class DAL : DbContext
    {

        public DAL () : base("INEQ")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}