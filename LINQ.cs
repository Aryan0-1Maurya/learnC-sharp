using System;
using System.Linq;

//Simple Linq Example
namespace AryanMaurya
{
    class SimplelinqExample
    {
        static void Main(string[] args)
        {
            string[] words = { "welcome", "to", "the", "world", "of", "programming", "hub" };
            //get only 2 letter words
            var twoLetterWords = from word in words
                             where word.Length == 2
                             select word;
            //get all words starting with w
            var wordsWithW = from word in words
                             where word.StartsWith("w")
                             select word;

            //Print each word out
            foreach (var word in twoLetterWords)
            {
                Console.WriteLine(word);
            }

            foreach (var word in wordsWithW)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }

    }
}





using System;
using System.Collections.Generic;
using System.Linq;


//Linq To Objects Example
namespace AryanMaurya
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentClass { get; set; }
        public string StudentDivision { get; set; }
        public string StudentCity { get; set; }
    }
    class LinqToObjectsExample
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { StudentID = 1, StudentName = "Avinash", StudentClass = "Seventh", StudentDivision = "A", StudentCity = "Ram Nagar" });
            students.Add(new Student { StudentID = 2, StudentName = "Miten", StudentClass = "Fifth", StudentDivision = "B", StudentCity = "Vasant Vihar" });
            students.Add(new Student { StudentID = 3, StudentName = "Prasanna", StudentClass = "First", StudentDivision = "C", StudentCity = "Jain Colony" });

            var studentList = from s in students
                                 select s;

            foreach (var stud in studentList)
            {
                Console.WriteLine("Student {0} lives in {1}.",
                                  stud.StudentName, stud.StudentCity);
            }
            
            Console.ReadKey();
        }


    }
}







using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

//Linq to XML Example
namespace AryanMaurya
{
    class LinqToXMLExample
    {

        static void Main(string[] args)
        {
            //string with xml content
            string studentXML = @"<Students>
                       <StudentName>Avinash</StudentName>
                       <StudentName>Miten</StudentName>
                       <StudentName>Prasanna</StudentName>
                       <StudentName>Anoop</StudentName>
                       </Students>";

        //object for holding xml document
        XDocument xdoc = new XDocument();
        xdoc = XDocument.Parse(studentXML);

        //returns a collection of descendant for the xml document/element
        var result = xdoc.Element("Students").Descendants();

        foreach (XElement item in result)
        {
           Console.WriteLine("Student Name is " + item.Value);
        }

        Console.ReadKey();
     }
        }

    }













using System;
using System.Linq;

//Linq Example with Lambda Syntax
namespace AryanMaurya
{
    class LinqLambdaSyntax
    {
        static void Main(string[] args)
        {
            string[] words = { "welcome", "to", "the", "world", "of", "programming", "hub" };
            //get only 2 letter words
            var twoLetterWords = words.Where(w => w.Length == 2);
            //get all words starting with w
            var wordsWithW = words.Where(w => w.StartsWith("w"));

            //Print each word out
            foreach (var word in twoLetterWords)
            {
                Console.WriteLine(word);
            }

            foreach (var word in wordsWithW)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }

    }
}