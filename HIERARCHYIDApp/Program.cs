using System;

namespace HIERARCHYIDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryWithDapper();

            Console.ReadLine();
        }

        private static void QueryWithDapper()
        {
            string cmd = @"
-- 先查詢出人員所屬部門階層代號
DECLARE @GroupLevel HIERARCHYID
SELECT @GroupLevel = Dep FROM DepUsers WHERE Name='新竹總經理'

-- 取得銷售額階層為人員部門子系的資料
SELECT d.*, ISNULL(s.Amount, 0) AS Amount
FROM Departments d
LEFT JOIN DepSales s ON d.No=s.Dep
WHERE d.No.IsDescendantOf(@GroupLevel) = 1";

            Console.WriteLine(string.Join(Environment.NewLine, Repository.Query<Dapper.SalesByDepartment>(cmd)));
        }
    }
}
