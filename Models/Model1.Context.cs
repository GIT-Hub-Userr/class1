﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MainEntities : DbContext
    {
        public MainEntities()
            : base("name=MainEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<employee_salary_details> employee_salary_details { get; set; }
        public virtual DbSet<employee_table> employee_table { get; set; }
        public virtual DbSet<manager_table> manager_table { get; set; }
        public virtual DbSet<sales_table> sales_table { get; set; }
        public virtual DbSet<studentdetail> studentdetails { get; set; }
        public virtual DbSet<teacherdetail> teacherdetails { get; set; }
    }
}
