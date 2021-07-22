using System.Collections.Generic;

namespace LessonMonitor.API.MyReflection
{
    public class GetStrustClass <T> 
    {
        public static List<StructClassModel> GetStructClassModels()
        {
            var typeUser = typeof(T);
            var propertys = typeUser.GetProperties();
            List<StructClassModel> namePropertys = new List<StructClassModel>();

            foreach (var item in propertys)
            {
                namePropertys.Add(new StructClassModel() 
                { Name = item.Name, 
                  Type = item.PropertyType.ToString() });
            }
            return namePropertys;
        }
    }

    public class StructClassModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
