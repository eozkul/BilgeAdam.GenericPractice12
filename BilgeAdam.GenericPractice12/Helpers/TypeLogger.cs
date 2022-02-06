using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.GenericPractice12.Helpers
{
    public class TypeLogger
    {
        public string GetTypeProperties<T>()
        {
            var type = typeof(T);
            var str = new StringBuilder();
            str.Append(type.FullName+",");
            str.Append(type.Name + ",");
            if (type.IsClass) str.Append("Class,");
            if (type.IsEnum) str.Append("Enum,");
            if (type.IsInterface) str.Append("Interface,");
            if (type.IsAbstract) str.Append("Abstract,");
            if (type.IsPrimitive) str.Append("Primitive,");
            var interfaces = type.GetInterfaces();
            if (interfaces.Any())
            {
                foreach (var _interfaces in interfaces)
                {
                    str.Append(_interfaces.Name+",");
                }
            }
           
            return str.ToString();           

        }
    }
}
