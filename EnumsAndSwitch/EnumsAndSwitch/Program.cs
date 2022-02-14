﻿using System;
using System.Collections.Generic;

namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo { Description = "Task 1", EstimatedHours = 6, Status = Status.Completed },
                new Todo { Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress},
                new Todo { Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted},
                new Todo { Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted},
                new Todo { Description = "Task 5", EstimatedHours = 6, Status = Status.InProgress},
                new Todo { Description = "Task 6", EstimatedHours = 2, Status = Status.NotStarted},
                new Todo { Description = "Task 7", EstimatedHours = 14, Status = Status.NotStarted},
                new Todo { Description = "Task 8", EstimatedHours = 8, Status = Status.Completed},
                new Todo { Description = "Task 9", EstimatedHours = 8, Status = Status.InProgress},
                new Todo { Description = "Task 10", EstimatedHours = 8, Status = Status.Completed},
                new Todo { Description = "Task 11", EstimatedHours = 8, Status = Status.NotStarted},
                new Todo { Description = "Task 12", EstimatedHours = 8, Status = Status.Completed},
                new Todo { Description = "Task 13", EstimatedHours = 8, Status = Status.Deleted},
                new Todo { Description = "Task 14", EstimatedHours = 8, Status = Status.Completed}
            };

            Console.ForegroundColor = ConsoleColor.DarkRed;

            PrintAssessment(todos);

            // Console.ReadLine();
        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                //switch (todo.EstimatedHours)
                //{
                //    case 4:

                //        break;
                //    case 5:

                //        break;
                //    default:
                //        Console.WriteLine("Invalid input was given");
                //        break;
                //}
                //switch (todo.Status)
                //{
                //    case Status.Completed:

                //        break;
                //    case Status.Deleted:

                //        break;
                //    default:
                //        Console.WriteLine("Invalid status was given");
                //        break;
                //}
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);

            }
        }

    }

    internal class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }

}
