using System;
using System.Linq;
using System.Collections.Generic;

namespace dotnet_linq_to_object
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello GC!");
            // var md1 = new MyData();
            /* List<MyData> list = new List<MyData>();
            for(int i = 0; i < 10; i++){
              // System.Console.WriteLine(i);
              // new MyData();
              list.Add(new MyData());
            } */
            // System.Console.WriteLine(list.Where(md => md.id % 2 == 0).GetType().Name);
            /* System.Console.WriteLine(
              list.Where(md => ((md.id % 2 == 0) && (md.id > 0 && md.id < 11)))
                // .OrderByDescending(md => md.id)
                .Select((md) => {
                  switch(md.id){
                    case 2 : return "two";
                    case 4 : return "four";
                    case 6 : return "six";
                    case 8 : return "eight";
                    case 10 : return "ten";
                    default : return "";
                  }
                })
                .OrderBy(idString => idString).GetType().Name
            ); */
            /* var list2 =
              list.Where(md => ((md.id % 2 == 0) && (md.id > 0 && md.id < 11)))
                // .OrderByDescending(md => md.id)
                .Select((md) => {
                  switch(md.id){
                    case 2 : return "two";
                    case 4 : return "four";
                    case 6 : return "six";
                    case 8 : return "eight";
                    case 10 : return "ten";
                    default : return "";
                  }
                })
                .OrderBy(idString => idString)
                .Skip(1)
                .Take(2)
                .ToList();
            foreach(var item in list2) {
              System.Console.WriteLine(item);
            } */

            List<Group> groups = new List<Group>() {
              new Group(){id = 30, name = "PSV 30-18" },
              new Group(){id = 12, name = "PPV 30-18" }
            };

            List<Student> students = new List<Student>() {
              new Student(){id = 3, firstName = "A1", lastName = "B10", age = 18, avgScore = 9.5, groupId = 30 },
              new Student(){id = 1, firstName = "A5", lastName = "B1", age = 20, avgScore = 10.5, groupId = 12 },
              new Student(){id = 5, firstName = "A4", lastName = "B100", age = 18, avgScore = 8, groupId = 30 },
              new Student(){id = 4, firstName = "A7", lastName = "B2", age = 19, avgScore = 8, groupId = 12 },
              new Student(){id = 6, firstName = "A9", lastName = "B3", age = 18, avgScore = 8.5, groupId = 13 }
            };

            var result = students
                .Where(s => s.lastName.Length <= 2)
                .GroupBy(s => s.groupId)
                .Select(
              (gr) => new {
                GroupName = groups.Where(g => g.id == gr.Key).SingleOrDefault()?.name ?? "Unknown Group",
                StudentsCount = gr.Count(),
                StudentsAvgScore = gr.Average((s) => s.avgScore)
              }
            );

            foreach (var item in result)
            {
              Console.WriteLine(item);
            }
        }
    }
}
