using Api.Model;
using Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Business.Implementations
{
    public class UserBusinessImplementation : IUserBusiness
    {
        private readonly IUserRepository _repository;

        public UserBusinessImplementation(IUserRepository repository)
        {
            _repository = repository;
        }
        public List<User> FindAll()
        {
            return _repository.FindAll();
        }

        public User FindByID(long id)
        {
            return _repository.FindByID(id);
        }
        public User Create(User user)
        {
            return _repository.Create(user);
        }

        public User Update(User user)
        {
            return _repository.Update(user);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
