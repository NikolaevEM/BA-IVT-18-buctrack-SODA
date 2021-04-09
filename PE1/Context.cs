﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PE1
{
    public class Context : DbContext
    {

        public Context() : base("PE1.Properties.Settings.BugtrackDBConnectionString")
        {

        }
        // types
        public virtual DbSet<BugType> BugTypes { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<PositionEmployee> PositionEmployees { get; set; }
        public virtual DbSet<Procedure> Procedures { get; set; }
        public virtual DbSet<StatusBug> StatusBugs { get; set; }
        public virtual DbSet<StatusEmployee> StatusEmployees { get; set; }
        // main classes
        public virtual DbSet<Bug> BugTypes { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Fix> Fixes { get; set; }
        public virtual DbSet<Log> Logs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

        }

    }
}
