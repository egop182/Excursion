namespace Excursion
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Modelo;

    internal class CnxEF : DbContext
    {
        public CnxEF()
            : base("name=CnxEF")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Elementos> Elementos { get; set; }
        public virtual DbSet<Riscoss> Riscos { get; set; }

        //internal void SaveChanges(Elementos e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}