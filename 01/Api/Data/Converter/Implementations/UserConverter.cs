using Api.Data.Converter.Contract;
using Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Converter.Implementations
{
    public class UserConverter : IParser<UserVO, User>, IParser<User, UserVO>
    {
        public UserVO Parse(User origin)
        {
            if (origin == null) return null;
            return new UserVO
            {
                Id = origin.Id,
                Username = origin.Username,
                Email = origin.Email,
                Password = origin.Password,
                DisplayName = origin.DisplayName,
                CreatedDate = origin.CreatedDate
            };
        }

        public User Parse(UserVO origin)
        {
            if (origin == null) return null;
            return new User
            {
                Id = origin.Id,
                Username = origin.Username,
                Email = origin.Email,
                Password = origin.Password,
                DisplayName = origin.DisplayName,
                CreatedDate = origin.CreatedDate
            };
        }

        public List<User> Parse(List<UserVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
        public List<UserVO> Parse(List<User> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
