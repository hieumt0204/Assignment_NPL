public class Program
{
    /*
     *  Write a program in C# Sharp to count file extensions and group it using LINQ.
        Test Data :
        The files are : aaa.frx, bbb.TXT, xyz.dbf,abc.pdf
        aaaa.PDF,xyz.frt, abc.xml, ccc.txt, zzz.txt
         :
        Here is the group of extension of the files :
        1 File(s) with .frx Extension
        3 File(s) with .txt Extension
        1 File(s) with .dbf Extension
        2 File(s) with .pdf Extension
        1 File(s) with .frt Extension
        1 File(s) with .xml Extension

     */
    public static void Main(string[] args)
    {
        string[] files =
        {
            "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf",
            "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt"
        };

        var groupedExtensions = files
                                .Select(file => Path.GetExtension(file).ToLower())
                                .GroupBy(extension => extension)
                                .Select(group => new
                                {
                                    Extension = group.Key,
                                    Count = group.Count()
                                });
        Console.WriteLine("Here is group of extension of the files: ");
        foreach (var group in groupedExtensions)
        {
            Console.WriteLine($"{group.Count} File(s) with {group.Extension} Extension");
        }
    }
}