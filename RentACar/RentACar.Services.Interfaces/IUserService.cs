using RentACar.Dto;

namespace RentACar.Services.Interfaces
{
    public interface IUserService: IBaseService<User, string>
    { 
        User UpdateUserName(string id, string newUserName);    
    }
}
