using Microsoft.EntityFrameworkCore;
using Rest.Domain.Ententies;
using Rest.Domain.Interfaces.Repositorys;
using Rest.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rest.Infra.Data.Repository
{
    public class PratoRepository: IPratoRepository
    {
        private DataContext _context;
        
        public PratoRepository(DataContext context)
        {
            _context = context;
        }
        public void Insert(Prato prato)
        {
            _context.Pratos.Add(prato);
            _context.SaveChanges();
        }

        public void Delete(Prato prato)
        {
            _context.Pratos.Remove(prato);
            _context.SaveChanges();
        }
        public IEnumerable<Prato> GetAll()
        {
            return _context.Pratos.ToList();
        }
        public Prato GetOne(int id)
        {
            return _context.Pratos.Find(id);
        }
        public void Update(int id, Prato prato)
        {
            _context.Entry(prato).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
