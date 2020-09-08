using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Base.Models;

namespace Base.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext()
            :base("BaseContext")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}