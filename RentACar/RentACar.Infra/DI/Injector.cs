using System;
using System.Collections.Generic;

namespace RentACar.Infra.DI
{
    public static class Injector
    {
        private static IDictionary<string, object> _objectsStore = new Dictionary<string, object>();

        internal static void AddToStore(Type type, object obj)
        {
            _objectsStore.Add(type.FullName,obj);
        }

        public static T Inject<T>()
        {
            _objectsStore.TryGetValue(typeof(T).FullName, out var result);
            if(result != null)
            {
                return (T)result;
            }
            return default(T);
        }
    }
}
