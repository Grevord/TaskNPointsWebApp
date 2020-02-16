using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskNPoints.Factory;
using TaskNPoints.Repository.Contract;

namespace TaskNPoints.Repository
{
    public class FactoryStudent : StudentRepository
    {
        public GenerateFake Context { get; set; }
        public FactoryStudent(GenerateFake generateFake)
        {
            Context = generateFake;
        }
        public bool LogInUser(string login, string password)
        {
          return Context.Students.Any(s => s.Login == login && s.Password == password);
        }
    }
}
