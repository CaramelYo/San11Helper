using System;
using System.Reflection;


namespace San11Helper
{
    public static class SpecialtyIDExtensions
    {
        public static string ToString<T>(this SpecialtyID id)
        {
            return ToString(id, typeof(T));
        }

        public static string ToString(this SpecialtyID id, Type type)
        {
            foreach (FieldInfo field in type.GetFields(BindingFlags.GetField | BindingFlags.Public | BindingFlags.Static))
            {
                if ((field.FieldType == typeof(SpecialtyID)) && id.Equals(field.GetValue(null)))
                {
                    return string.Format("{0}.{1}", type.ToString().Replace('+', '.'), field.Name);
                }
            }

            foreach (Type nestedType in type.GetNestedTypes())
            {
                string asNestedType = ToString(id, nestedType);
                if (asNestedType != null)
                {
                    return asNestedType;
                }
            }

            return null;
        }
    }
}
