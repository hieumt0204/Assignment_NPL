using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A008.Exercise1
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
        public DateTime EntryDate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Mark { get; set; }
        public string Grade { get; set; }

        public Student() { }
        public Student(string name, string @class, string gender, DateTime entryDate, int age, string address, string relationship = "Single",   decimal mark = 0, string grade = "F")
        {
            Name = name;
            Class = @class;
            Gender = gender;
            Relationship = relationship;
            EntryDate = entryDate;
            Age = age;
            Address = address;
            Mark = mark;
            Grade = grade;
        }


        public void Graduate(decimal gradePoint = 0)
        {
            if (gradePoint >= 85)
            {
                Grade = "A";
            }
            else if (gradePoint >= 80)
            {
                Grade = "A-";
            }
            else if (gradePoint >= 75)
            {
                Grade = "B+";
            }
            else if (gradePoint >= 70)
            {
                Grade = "B";
            }
            else if (gradePoint >= 65)
            {
                Grade = "B-";
            }
            else if (gradePoint >= 60)
            {
                Grade = "C+";
            }
            else if (gradePoint >= 55)
            {
                Grade = "C";
            }
            else if (gradePoint >= 50)
            {
                Grade = "D";
            }
            else
            {
                Grade = "F";
            }
        }
        public string ToString(bool includeName, bool includeClass, bool includeGender, bool includeRelationship, bool includeAge, bool includeGrade)
        {
            string result = "";
            if (includeName) result += $"{Name}\t";
            if (includeClass) result += $"{Class}\t";
            if (includeGender) result += $"{Gender}\t";
            if (includeRelationship) result += $"{Relationship}\t\t";
            if (includeAge) result += $"{Age}\t";
            if (includeGrade) result += $"{Grade}";

            return result;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Relationship: {Relationship}");
            Console.WriteLine($"Entry Date: {EntryDate.ToShortDateString()}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine($"Grade: {Grade}");
            
        }

    }
}

