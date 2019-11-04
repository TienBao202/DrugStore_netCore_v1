using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Infrastructure.Interfaces;

namespace DrugStore.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DrugStoreDbContext _context;
        public EFUnitOfWork(DrugStoreDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
