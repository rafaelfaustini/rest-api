using Api.Data.Converter;
using Api.Data.Converter.Implementations;
using Api.Model;
using Api.Repository;
using System.Collections.Generic;

namespace Api.Business.Implementations
{
    public class UserBusinessImplementation : IUserBusiness
    {
        private readonly IRepository<User> _repository;

        private readonly UserConverter _converter;

        public UserBusinessImplementation(IRepository<User> repository)
        {
            _repository = repository;
            _converter = new UserConverter();
        }
        public List<UserVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public UserVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }
        public UserVO Create(UserVO user)
        {
            var userEntity = _converter.Parse(user);
            userEntity = _repository.Create(userEntity);
            return _converter.Parse(userEntity);
        }

        public UserVO Update(UserVO user)
        {
            var userEntity = _converter.Parse(user);
            userEntity = _repository.Update(userEntity);
            return _converter.Parse(userEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
