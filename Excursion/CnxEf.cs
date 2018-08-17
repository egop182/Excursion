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

        public object Elementos { get; set; }
        public object Riscos { get; set; }

        internal void SaveChanges(Elementos e)
        {
            throw new NotImplementedException();
        }
    }
}