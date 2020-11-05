using RentACar.DataAccess.Interfaces;
using RentACar.Dto;
using RentACar.Services.Interfaces;

namespace RentACar.Services
{
    public class UserService : BusinessService<User, string>, IUserService
    {
        public UserService(IRepository<User, string> repository) : base(repository)
        {}
      
        public User UpdateUserName(string id, string newUserName)
        {
            var user = GetById(id);
            if (user == null)
            {
                throw new System.Exception($"No user found with id = {id}");
            }
            if(newUserName == user.UserName)
            {
                return user;
            }
            user.UserName = newUserName;
            return Update(id,user);
        }
    }
}
