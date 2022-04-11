using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Task6.DATA;
using Task6.Entities;

namespace Task6.Services
{
    public class BreakfastRepository : IRepository<Breakfast>
    {
        private readonly MyDBContext _context;

        public BreakfastRepository(MyDBContext context)
        {
            _context = context;
        }

        public void Add(Breakfast item)
        {
            _context.Entry(item).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(Breakfast item)
        {
            _context.Entry(item).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public Breakfast Get(int id)
        {
            return _context.Breakfasts.FirstOrDefault(b => b.Id == id);
        }

        public List<Breakfast> GetAll()
        {
            return _context.Breakfasts.ToList();
        }

        public void Update(Breakfast item)
        {
            _context.Entry(item).State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}