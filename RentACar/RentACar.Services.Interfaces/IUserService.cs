using RentACar.Dto;

namespace RentACar.Services.Interfaces
{
    public interface IUserService: IBusinessService<User, string>
    { 
        User UpdateUserName(string id, string newUserName);    
    }
}
