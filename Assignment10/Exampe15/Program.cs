public class Program
{
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