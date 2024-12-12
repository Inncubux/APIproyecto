using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Microsoft.Extensions.DependencyInjection;
using API.src.Models;
using API.src.Data;

namespace api.src.Data
{
    public class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDBContext>();
                var existingEmails = new HashSet<string>();

                context.Database.EnsureCreated();

                if (!context.Students.Any())
                {
                    SeedStudents(context, existingEmails);
                }
                if(!context.Admins.Any()){
                    SeedAdmins(context, existingEmails);
                }
                if(!context.Subjects.Any()){
                    SeedSubjects(context);
                }
            }
        }

        private static void SeedStudents(ApplicationDBContext context, HashSet<string> existingEmails)
        {
            var studentFaker = new Faker<Student>()
                .RuleFor(s => s.Name, f => f.Name.FirstName())
                .RuleFor(s => s.LastName, f => f.Name.LastName())
                .RuleFor(s => s.UserName, f => f.Internet.UserName())
                .RuleFor(s => s.PersonalEmail, f => GenerateUniqueEmail(f, existingEmails))
                .RuleFor(s => s.EmpresarialEmail, f => GenerateUniqueEmail(f, existingEmails))
                .RuleFor(s => s.IdMentor, f => f.Random.Int(1, 10)) // Assuming mentors exist
                .RuleFor(s => s.RoleId, f => f.Random.Int(1, 3)); 

            var students = studentFaker.Generate(50);
            context.Students.AddRange(students);
            context.SaveChanges();
        }
        private static void SeedAdmins(ApplicationDBContext context, HashSet<string>existingEmails){
            var adminFaker= new Faker<Admin>()
                .RuleFor(s=> s.Name, f=>f.Name.FirstName())
                .RuleFor(s => s.Email, f => GenerateUniqueEmail(f, existingEmails))
                .RuleFor(s=> s.PersonalEmail, f=> GenerateUniqueBusinessEmail(f, existingEmails))
                .RuleFor(s=> s.Password, f=> f.Internet.Password())
                .RuleFor(a=> a.RoleId, f=>f.Random.Int(1,5));
            var admins = adminFaker.Generate(10);
            context.Admins.AddRange(admins);
            context.SaveChanges();

        }


        private static void SeedSubjects(ApplicationDBContext context)
        {
            var diccSubject= new List<(string Id, string Name)>{
                ("TIHI14", "Taller de Integración de Software"),
                ("TIGS01", "Introducción a las TI")

            };
            var subjectFaker = new Faker<Subject>()
                .RuleFor(s =>s.Id, (f, s) => diccSubject.First(p=>p.Id == s.Id).Id)
                .RuleFor(s => s.Name, (f,s) => diccSubject.First(p=> p.Id == s.Id).Name)
                .RuleFor(s => s.Hour, f => f.Random.Int(6, 72))
                .RuleFor(s => s.Section, f => f.Random.String2(1, "ABCD"))
                .RuleFor(s => s.CountStudent, f => f.Random.Int(1, 17))
                .RuleFor(s => s.State, f => f.PickRandom("Active", "Inactive"))
                .RuleFor(s => s.Students, f => new List<Student>()); 

            var subjects = subjectFaker.Generate(20);
            context.Subjects.AddRange(subjects);
            context.SaveChanges();
        }

        private static string GenerateUniqueEmail(Faker faker, HashSet<string> existingEmails)
        {
            string email;
            do
            {
                email = faker.Internet.Email();
            } while (existingEmails.Contains(email));
            existingEmails.Add(email);
            return email;
        }

        private static string GenerateUniqueBusinessEmail(Faker faker, HashSet<string> existingEmails){
            string email;
            do{
                var userName = faker.Internet.UserName();
                email= $"{userName}@nadian007.cl";
            }while(existingEmails.Contains(email));
            existingEmails.Add(email);
            return email;
        }
    }
}
