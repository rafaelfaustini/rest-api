using Api.Model;
using System.Collections.Generic;

namespace Api.Business
{
    public interface IUserBusiness
    {
        User Create(User user);
        User FindByID(long id);
        List<User> FindAll();
        User Update(User user);
        void Delete(long id);
    }
}
