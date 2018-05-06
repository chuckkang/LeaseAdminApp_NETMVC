﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBConnectionTest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LeaseAdminEntities : DbContext
    {
        public LeaseAdminEntities()
            : base("name=LeaseAdminEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BusinessDate> BusinessDates { get; set; }
        public virtual DbSet<CalendarMonth> CalendarMonths { get; set; }
        public virtual DbSet<CalendarYear> CalendarYears { get; set; }
        public virtual DbSet<ExpenseAlert> ExpenseAlerts { get; set; }
        public virtual DbSet<ExpenseDetail> ExpenseDetails { get; set; }
        public virtual DbSet<ExpenseResponsibility> ExpenseResponsibilities { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpensesType> ExpensesTypes { get; set; }
        public virtual DbSet<Frequency> Frequencies { get; set; }
        public virtual DbSet<GeneralNote> GeneralNotes { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<IncomeType> IncomeTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaskManagement> TaskManagements { get; set; }
        public virtual DbSet<TenantLeaseInfo> TenantLeaseInfoes { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }
        public virtual DbSet<TenderType> TenderTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
    }
}
