using PetaPoco;
using RentACar.DataAccess;
using RentACar.DataAccess.Interfaces;
using RentACar.Dto;
using RentACar.Services;
using RentACar.Services.Interfaces;

namespace RentACar.Infra.DI
{
    public class Registration
    {
        public static void Register(string connectionName = null)
        {
            if (!string.IsNullOrEmpty(connectionName))
            {
                Injector.AddToStore(typeof(IDatabase), new Database(connectionName));
            }
            Injector.AddToStore(typeof(IRepository<User, string>), new Repository<User, string>(Injector.Inject<IDatabase>()));
            Injector.AddToStore(typeof(IRepository<Roles, int>), new Repository<Roles, int>(Injector.Inject<IDatabase>()));
            Injector.AddToStore(typeof(IUserService), new UserService(Injector.Inject<IRepository<User,string>>()));
            Injector.AddToStore(typeof(IBusinessService<Roles, int>), new BusinessService<Roles, int>(Injector.Inject<IRepository<Roles, int>>()));
        }
    }
}
