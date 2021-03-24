using BackUpMe.Common.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BackUpMe.Common.Utilities
{
	public static class EnumExtensions
	{
		public static string ExtToString(this StatusType statusType)
		{
            Type type = statusType.GetType();
            string name = Enum.GetName(type, statusType);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }
	}
}
