using Entity_F_S1.Entities;
using Entity_F_S2.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S1.Context
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = Iti_EF_S2 ; Trusted_Connection = True ; Encrypt = False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new InstructorConfig());
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new TopicConfig());
            //modelBuilder.Entity<Instructor>()
            //.HasOne(i => i.MangeDept)
            //.WithOne(d => d.ManageIns)
            //.HasForeignKey<Department>(d => d.insId)
            //.OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Courses_Inst { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Stud_Course> stud_Courses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Topic> topics { get; set; }


    }
}
