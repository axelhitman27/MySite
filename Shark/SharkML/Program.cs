using SharkML.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace SharkML
{
    internal class Program
    {
        public static List<Letters> lettersCount;

        private static void Main(string[] args)
        {
            lettersCount = new List<Letters>();
            var nameList = GetNames();
            ShowMostLetters(nameList);
            Console.ReadLine();
        }

        private static void ShowMostLetters(IEnumerable<RandomData> nameList)
        {
            foreach (var name in nameList)
            {
                var nameArray = name.Name.ToArray();
                var alhpabetList = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => new Letters()
                {
                    Count = 0,
                    Letter = ((Char)i).ToString()
                }).ToList();

                SetLettersArray(alhpabetList, nameArray);
            }

            var result = lettersCount.GroupBy(y => y.Letter).Select(x => new Letters()
            {
                Letter = x.First().Letter,
                Count = x.Sum(z => z.Count)
            }).ToList();

            Console.WriteLine("Result:");
            foreach (var r in result)
            {
                Console.WriteLine(r.Letter + " : " + r.Count);
            }
        }

        private static void SetLettersArray(List<Letters> alhpabetList, char[] nameArray)
        {
            try
            {
                foreach (var c in nameArray)
                {
                    alhpabetList.First(x => x.Letter.Equals(((Char)c).ToString())).Count++;
                }

                lettersCount.AddRange(alhpabetList);
            }
            catch (Exception ex)
            {
            }
        }

        public static List<RandomData> GetNames()
        {
            var list = new List<RandomData>();

            var lines = File.ReadAllLines(@"C:\Projects\MyWebsite\Shark\SharkML\data\randomdata.txt");

            foreach (var line in lines)
            {
                var linearray = line.Trim().Split();
                if (linearray.Length > 0)
                {
                    var id = linearray[0];
                    var name = new string(linearray[1].Where(x => char.IsWhiteSpace(x) || char.IsLetterOrDigit(x)).ToArray()); ;
                    var date = linearray[2];

                    list.Add(
                        new RandomData()
                        {
                            Id = Int32.Parse(id),
                            Name = name,
                            Created = DateTime.Parse(date)
                        });
                }
            }
            return list;
        }
    }
}