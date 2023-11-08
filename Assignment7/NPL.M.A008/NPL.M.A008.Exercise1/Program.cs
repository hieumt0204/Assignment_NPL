namespace NPL.M.A008.Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            {
                Name = "Hieu",
                Class = "SE1644",
                Gender = "Male",
                EntryDate = new DateTime(2002, 04, 02),
                Age = 21,
                Address = "Ha Tinh",
                Mark = 10,
            };


            //string formatteds1 = s1.ToString(true,true,true,true,true,true);
            //Console.WriteLine(formatteds1);

            //s1.DisplayInfo();
            Console.WriteLine("Name    Class   Gender  Relationship    Age     Gender");
            Student student1 = new Student("Cong", "Net06", "Male", DateTime.Now, 20, "Single", grade: "A");
            string formattedInfo1 = student1.ToString(true, true, true, true, true, true);
            Console.WriteLine(formattedInfo1);


            Student student2 = new Student("Linh", "Net07", "Male", DateTime.Now, 21, "Married", grade: "B");
            string formattedInfo2 = student2.ToString(true, true, true, true, true, true);
            Console.WriteLine(formattedInfo2);

            //Using Optional Arguments:

            //Student s1 = new Student("Trong Hieu", "10A", "Male", new DateTime(2002, 04, 12), 16, "Ha Tinh, City");
            //s1.Graduate();
            //string student1Info = s1.ToString(true, true, true, true, true, true);
            //Console.WriteLine(student1Info);



            //Using Named Arguments:
            Student s2 = new Student(
                name: "Viet Ha",
                @class: "Net04",
                gender: "Female",
                entryDate: new DateTime(2023, 10, 15),
                age: 17,
                address: "Hung Yen",
                grade: "A-"
            );
            s2.Graduate(88.0m);
            string student2Info = s2.ToString(true, true, true, true, true, true);
            Console.WriteLine(student2Info);


        }

    }
}