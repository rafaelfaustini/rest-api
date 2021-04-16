using Api.Data.Converter;
using System.Collections.Generic;

namespace Api.Business
{
    public interface IUserBusiness
    {
        UserVO Create(UserVO user);
        UserVO FindByID(long id);
        List<UserVO> FindAll();
        UserVO Update(UserVO user);
        void Delete(long id);
    }
}
