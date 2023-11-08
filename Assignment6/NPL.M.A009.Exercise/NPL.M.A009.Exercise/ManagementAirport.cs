namespace NPL.M.A009.Exercise_
{
    public class ManagementAirport
    {
        public static List<Airports> airports = new List<Airports>();
        public static void AirportManagement()
        {
            // A boolean variable to control the loop
            bool running = true;

            // A menu-based feature in the console application
            while (running)
            {
                // Display the menu options
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create an airport");
                Console.WriteLine("2. Delete an airport");
                Console.WriteLine("3. Display list of all airport information, sorted by airport ID");
                Console.WriteLine("4. Display the status of one airport, selected by airport ID");
                Console.WriteLine("5. Return to main menu");

                // Get the user's choice
                int choice = int.Parse(Console.ReadLine());

                // Perform different actions based on the choice
                switch (choice)
                {
                    case 1:
                        // Create an airport
                        CreateAirport();
                        break;
                    case 2:
                        // Delete an airport
                        DeleteAirport();
                        break;
                    case 3:
                        // Display list of all airport information, sorted by airport ID
                        DisplayAllAirportInfo();
                        break;
                    case 4:
                        // Display the status of one airport, selected by airport ID
                        DisplayOneAirportStatus();
                        break;
                    case 5:
                        // Return to the main menu
                        running = false;
                        break;
                    default:
                        // Invalid choice
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void CreateAirport()
        {
            try
            {
                // Ask the user to enter the information for the new airport
                Console.WriteLine("Enter information for the new airport:");
                Console.Write("ID: ");
                string id = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Runway Size: ");
                double runwaySize = double.Parse(Console.ReadLine());
                Console.Write("Max Fixed Wing Parking Place: ");
                int maxFixedWingParkingPlace = int.Parse(Console.ReadLine());
                Console.Write("Max Rotated Wing Parking Place: ");
                int maxRotatedWingParkingPlace = int.Parse(Console.ReadLine());

                // Create a new airport object with the input data and add it to the list of airports
                Airports airport = new Airports(id, name, runwaySize, maxFixedWingParkingPlace, maxRotatedWingParkingPlace);
                airports.Add(airport);

                // Display a message to indicate the creation is successful
                Console.WriteLine($"Created a new airport with ID {id} successfully.");
            }
            catch (Exception e)
            {
                // Display a message to indicate the creation is unsuccessful
                Console.WriteLine($"Failed to create a new airport. An error occurred: {e.Message}");
            }
        }

        static void DeleteAirport()
        {
            try
            {
                // Ask the user to enter the ID of the airport to delete
                Console.Write("Enter the ID of the airport to delete: ");
                string id = Console.ReadLine();

                // Find the airport that matches the ID using LINQ
                var airport = airports.FirstOrDefault(a => a.ID == id);

                // Check if there is a matching airport
                if (airport != null)
                {
                    // Remove the matching airport from the list of airports
                    airports.Remove(airport);

                    // Display a message to indicate the deletion is successful
                    Console.WriteLine($"Deleted the airport with ID {id} successfully.");
                }
                else
                {
                    // Display a message to indicate no matching airport found
                    Console.WriteLine($"No matching airport found with ID {id}.");
                }
            }
            catch (Exception e)
            {
                // Display a message to indicate the deletion is unsuccessful
                Console.WriteLine($"Failed to delete an airport. An error occurred: {e.Message}");
            }
        }
        static void DisplayAllAirportInfo()
        {
            try
            {
                // Sắp xếp danh sách các sân bay theo mã của chúng bằng LINQ
                var sortedAirports = airports.OrderBy(a => a.ID).ToList();

                // Kiểm tra xem danh sách có rỗng hay không
                if (sortedAirports.Count == 0)
                {
                    // Hiển thị một thông báo để cho biết không có sân bay nào trong danh sách
                    Console.WriteLine("There are no airports listed.");
                }
                else
                {
                    // Hiển thị một thông báo để cho biết số lượng sân bay trong danh sách
                    Console.WriteLine($"Has {sortedAirports.Count} airport in the list.");

                    // Duyệt qua mỗi sân bay trong danh sách đã sắp xếp
                    foreach (var airport in sortedAirports)
                    {
                        // Hiển thị thông tin chi tiết của mỗi sân bay, bao gồm mã, tên, thành phố và quốc gia
                        Console.WriteLine($"ID: {airport.ID}, Name: {airport.Name}, MaxFixedWingParkingPlace: {airport.MaxFixedWingParkingPlace}, RunwaySize: {airport.RunwaySize},MaxRotatedWingParkingPlace:  {airport.MaxRotatedWingParkingPlace}");
                    }
                }
            }
            catch (Exception e)
            {
                // Hiển thị một thông báo để cho biết việc hiển thị thông tin sân bay không thành công
                Console.WriteLine($"Unable to display airport information. Error! An error occurred. Please try again later: {e.Message}");
            }
        }


        static void DisplayOneAirportStatus()
        {
            try
            {
                // Prompt the user to enter an airport ID
                Console.WriteLine("Please enter an airport ID:");

                // Get the user's input
                string id = Console.ReadLine();

                // Find the airport with the matching ID using LINQ
                var airport = airports.FirstOrDefault(a => a.ID == id);

                // Check if the airport exists
                if (airport != null)
                {
                    // Display the airport's name and status
                    Console.WriteLine($"The airport with ID {id} is {airport.Name} and its RunwaySize is {airport.RunwaySize}.");
                }
                else
                {
                    // Display a message to indicate no matching airport found
                    Console.WriteLine($"No matching airport found with ID {id}.");
                }
            }
            catch (Exception e)
            {
                // Display a message to indicate the display is unsuccessful
                Console.WriteLine($"Failed to display an airport status. An error occurred: {e.Message}");
            }
        }


    }

}
