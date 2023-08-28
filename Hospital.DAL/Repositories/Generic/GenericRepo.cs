using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Hospital.DAL
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly HospitalContext _context;

        public GenericRepo(HospitalContext context)
        {
            _context = context;
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }
        public T? GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
          // _context.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        
    }
}
