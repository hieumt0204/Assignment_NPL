using System.Text;

public class Program
{
    /*
     *  Write a program in C# Sharp to calculate size of file using LINQ.

         Đọc tất cả các file trong 1 thư mục được nhập vào từ bàn phím sau đó tính 
        The Average file size is 3.4 MB
     */
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập đường dẫn thư mục: ");
        string dirPath = Console.ReadLine();

        if (Directory.Exists(dirPath))
        {
            var files = Directory.EnumerateFiles(dirPath);
            double averageSize = files.Select(file => new FileInfo(file).Length).Average();

            // Chuyển đổi byte sang megabyte
            averageSize = averageSize / (1024 * 1024);

            Console.WriteLine($"Kích thước trung bình của tệp là: {averageSize} MB");
        }
        else
        {
            Console.WriteLine("Thư mục không tồn tại.");
        }
    }
}