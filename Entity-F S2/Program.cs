using Entity_F_S1.Context;
using Entity_F_S1.Entities;

namespace Entity_F_S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();
            var result = dbContext.Departments.Where(d => d.DeptId == 30)
                                              .SingleOrDefault();
            Instructor instructor01 = new Instructor()
            {
                Name = "hamada",
                Salary = 88_000,
                Address = "mansoura",
                HourRate = 50,
                department = dbContext.Departments.Where(d => d.DeptId == 20)
                                              .SingleOrDefault()
            };
            


            //Department department01 = new Department()
            //{
            //    Name = "c++",
            //    HiringDate = null,
            //    instructor2 =instructor01 //new Instructor() { Name = "mohamed" }
            //};
            dbContext.Add(instructor01);
           // dbContext.Add(department01);
            dbContext.SaveChanges();
            Console.WriteLine(dbContext.Entry(instructor01).State);




        }
    }
}
