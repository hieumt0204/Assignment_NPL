using System.Text;

namespace NPL.M.A005.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = " Nguyen van tRan long ";
            Console.WriteLine($"\"{name}\" should be format to : \"{NormalizeName(name)}\"");


        }
        static string NormalizeName(string name)
        {
            name = name.Trim().ToLower();
            var arr = name.Split(' ');
            StringBuilder result = new StringBuilder();
            foreach(var word in arr)
            {
                if(!string.IsNullOrEmpty(word))
                {
                    result.Append(word.Substring(0,1).ToUpper() + word.Substring(1) + " ");
                }
            }
            return result.ToString().Trim();

        }
    }
}