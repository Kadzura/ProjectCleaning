﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCleaning
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCleaning_Entities : DbContext
    {
        public static DbCleaning_Entities _context;

        public DbCleaning_Entities()
            : base("name=DbCleaning_Entities")
        {
        }

        public static DbCleaning_Entities GetComponent()
        {
            if (_context == null)
            {
                _context = new DbCleaning_Entities();
            }
            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tClient> tClient { get; set; }
        public virtual DbSet<tOrder> tOrder { get; set; }
        public virtual DbSet<tPackage> tPackage { get; set; }
        public virtual DbSet<tPackageType> tPackageType { get; set; }
        public virtual DbSet<tPerson> tPerson { get; set; }
        public virtual DbSet<tPosition> tPosition { get; set; }
        public virtual DbSet<tResponsive> tResponsive { get; set; }
        public virtual DbSet<tService> tService { get; set; }
    }
}
