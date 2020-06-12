using Microsoft.SqlServer.Types;

namespace HIERARCHYIDApp.Dapper
{
    public class Departments
    {
        public SqlHierarchyId No { get; set; }
        public string Name { get; set; }
        public int Level { get; }
        public string Path { get; }

        public override string ToString()
        {
            return $"Name={Name}, No={No}, Level={Level}";
        }
    }

    public class DepSales
    {
        public SqlHierarchyId Dep { get; set; }
        public int Amount { get; set; }
    }

    public class DepUsers
    {
        public SqlHierarchyId Dep { get; set; }
        public string Name { get; set; }
    }


    #region Query Result

    public class SalesByDepartment
    {
        public SqlHierarchyId No { get; set; }
        public string Name { get; set; }
        public string Level { get; }
        public string Path { get; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return $"Name={Name},\tLevel={Level},\tPath={Path.ToString()},\tAmount={Amount}";
        }
    }

    #endregion
}
