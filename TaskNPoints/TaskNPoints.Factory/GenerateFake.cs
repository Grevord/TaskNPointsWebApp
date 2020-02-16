using System;
using System.Collections.Generic;
using System.Linq;
using TaskNPoints.Entities;

namespace TaskNPoints.Factory
{
    public class GenerateFake
    {
        public List<Rank> Ranks { get; set; }
        public List<Reward> Rewards { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Student> Students { get; set; }
        public List<Teatcher> Teatchers { get; set; }

        public GenerateFake()
        {
            GenListOfRewards();
            GenListOfRanks();
            GenListOfTasks();
            GenListOfUsers();
        }
        private void GenListOfRewards()
        {
            this.Rewards = new List<Reward>
            {
                new Reward
                {
                    Id = 1,
                    Name = "stylo",
                    value = 10
                },
                 new Reward
                {
                    Id = 1,
                    Name = "gum",
                    value = 15
                },
                  new Reward
                {
                    Id = 1,
                    Name = "gomme",
                    value = 15
                }
                , new Reward
                {
                    Id = 1,
                    Name = "aide",
                    value = 50
                }
                , new Reward
                {
                    Id = 1,
                    Name = "+ de pauses",
                    value = 50
                }
                , new Reward
                {
                    Id = 1,
                    Name = "une intervention",
                    value = 100
                }
            };
        }
        private void GenListOfRanks()
        {
            this.Ranks = new List<Rank>
            {
                new Rank
                {
                    Id = 1,
                    Name = "beginner",
                    RewardsOfRank = Rewards.Where(r => r.value <= 20).ToList()
                },
                new Rank
                {
                    Id = 2,
                    Name = "Rookie",
                    RewardsOfRank = Rewards.Where(r => r.value <= 50).ToList()
                },
                new Rank
                {
                    Id = 3,
                    Name = "Newcomer",
                    RewardsOfRank = Rewards.Where(r => r.value <= 100).ToList()
                },
            };
        }
        private void GenListOfTasks()
        {
            this.Tasks = new List<Task>
            {
                new Task
                {
                    Id = 1,
                    Description = "Faire des gestions d'exeptions dans le code",
                    Name ="Gestion d'exeption",
                    PointsValue = 3
                },
                 new Task
                {
                    Id = 2,
                    Description = "Faire des Tos",
                    Name = "Pedagogie 2.0",
                    PointsValue = 5
                },
                  new Task
                {
                    Id = 3,
                    Description = "avoir 100% de code coverage",
                    Name ="It's over 9000",
                    PointsValue = 1000
                },
            };
        }
        private void GenListOfUsers()
        {
            this.Students = new List<Student>
            {
                new Student
                {
                    FirstName ="bob",
                    LastName ="Bricoleur",
                    Id = 1,
                    Login = "bobo",
                    Password ="azerty",
                    Points = 0,
                },
                new Student
                {
                    FirstName ="serge",
                    LastName ="LeConsierge",
                    Id = 2,
                    Login = "Sergion",
                    Password ="bababoum",
                    Points = 0,
                },

            };
            this.Teatchers = new List<Teatcher>
            {
                new Teatcher
                {
                    FirstName = "Micgi",
                    Id =1 ,
                    LastName ="ElDev",
                    Login = "Micgi",
                    Password ="azerty"
                }
            };
        }
    }
}
