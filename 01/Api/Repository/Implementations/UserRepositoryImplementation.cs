using Api.Model;
using Api.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Implementations
{
    public class UserRepositoryImplementation : IUserRepository
    {
        private MySQLContext _context;

        public UserRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }
        public List<User> FindAll()
        {
            return _context.User.ToList();
        }

        public User FindByID(long id)
        {
            return _context.User.SingleOrDefault(u => u.Id.Equals(id));
        }
        public User Create(User user)
        {
            try
            {
                _context.Add(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return user;
        }

        public User Update(User user)
        {
            if (!Exists(user.Id)) return null;

            var result = _context.User.SingleOrDefault(u => u.Id.Equals(user.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return user;
        }

        public void Delete(long id)
        {
            var result = _context.User.SingleOrDefault(u => u.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.User.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _context.User.Any(u => u.Id.Equals(id));
        }
    }
}
