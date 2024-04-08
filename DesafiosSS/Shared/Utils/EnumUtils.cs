namespace DesafiosSS.Shared.Utils
{
    public static class EnumUtils
    {
        public static List<T> GetEnumList<T>()
        {
            var enumValues = Enum.GetValues(typeof(T));
            List<T> enumList = new List<T>();

            foreach (var value in enumValues)
            {
                enumList.Add((T)value);
            }

            return enumList;
        }
    }
}
