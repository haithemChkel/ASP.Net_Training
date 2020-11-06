using PetaPoco;
using RentACar.DataAccess;
using RentACar.DataAccess.Interfaces;
using RentACar.Dto;
using RentACar.Services;
using RentACar.Services.Interfaces;
using System;
using Unity;

namespace RentACar.Infra.DI
{
    public class Registration
    {
        public static void RegisterWithUnity(Unity.IUnityContainer unityContainer, string connectionName = null)
        {
            if (!string.IsNullOrEmpty(connectionName))
            {
                unityContainer.RegisterInstance(typeof(IDatabase), new Database(connectionName));
            }
            unityContainer.RegisterType(typeof(IRepository<,>), typeof(Repository<,>));
            unityContainer.RegisterType(typeof(IBaseService<,>), typeof(BaseService<,>));
            unityContainer.RegisterType<IUserService,UserService>();
        }
    }
}
