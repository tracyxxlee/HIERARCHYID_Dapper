using Microsoft.SqlServer.Types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Hierarchy;

namespace EntityFramworkLibrary
{
    public class Department
    {
        [Key]
        public SqlHierarchyId No { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Path { get; }

        public override string ToString()
        {
            return $"Name={Name}, No={No}, Level={Level}";
        }
    }

    public class DepSale
    {
        [Key]
        public SqlHierarchyId Dep { get; set; }
        public int Amount { get; set; }
    }

    public class DepUser
    {
        [Key, Column(Order = 0)]
        public SqlHierarchyId Dep { get; set; }
        [Key, Column(Order = 1)]
        public string Name { get; set; }
    }


    #region Query Result

    public class SalesByDepartment
    {
        public SqlHierarchyId No { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string Path { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return $"Name={Name},\tLevel={Level},\tPath={Path.ToString()},\tAmount={Amount}";
        }
    }

    #endregion
}
