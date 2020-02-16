using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNPoints.Repository.Contract
{
    public interface StudentRepository
    {
        bool LogInUser(string login, string password);
    }
}
