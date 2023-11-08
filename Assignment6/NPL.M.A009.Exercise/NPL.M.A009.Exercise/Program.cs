using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace NPL.M.A009.Exercise_
{
    public class Program
    {
        public static List<Fixedwings> fixedWings = new List<Fixedwings>();
        public static List<Helicopters> helicopters = new List<Helicopters>();
        public static List<Airports> airports = new List<Airports>();
        static void Main(string[] args)
        {
            //LoadData();

            Console.WriteLine("Welcome to Airport Management System");

            bool running = true;
            
            while (running)
            {
                
                Console.WriteLine("1. Input data from keyboard");
                Console.WriteLine("2. Airport management");
                Console.WriteLine("3. Fixed wing airplane management");
                Console.WriteLine("4. Helicopter management");
                Console.WriteLine("5. Exit");
                Console.Write("Please select an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InputData();
                        break;
                    case 2:
                        AirportManagement();
                        break;
                    case 3:
                        FixedWingManagement();
                        break;
                    case 4:
                        HelicopterManagement();
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            //SaveData();
            Console.WriteLine("Thank you for using Airport Management System. Goodbye!");

        }

      

        static void LoadData()
        {
            try
            {
                // Read the fixed wing airplanes from FixedWing.txt file
                using (StreamReader sr = new StreamReader("FixedWing.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] fields = line.Split(',');
                        Fixedwings fixedWing = new Fixedwings(fields[0], fields[1], double.Parse(fields[2]), double.Parse(fields[3]), double.Parse(fields[4]),
                        fields[5], double.Parse(fields[6]));
                        fixedWings.Add(fixedWing);
                    }
                }

                // Read the helicopters from Helicopter.txt file
                using (StreamReader sr = new StreamReader("Helicopter.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        Helicopters helicopter = new Helicopters(fields[0], fields[1], double.Parse(fields[2]), double.Parse(fields[3]), double.Parse(fields[4]),
                        double.Parse(fields[5]));
                        helicopters.Add(helicopter);
                    }
                }

                // Read the airports from Airport.txt file
                using (StreamReader sr = new StreamReader("Airport.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        Airports airport = new Airports(fields[0], fields[1], double.Parse(fields[2]), int.Parse(fields[3]),
                        int.Parse(fields[5]));
                        if (fields[4] != "None")
                        {
                            airport.ListOfFixedWingID.AddRange(fields[4].Split(' '));
                        }
                        if (fields[6] != "None")
                        {
                            airport.ListOfHelicopterID.AddRange(fields[6].Split(' '));
                        }
                        airports.Add(airport);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while loading data: {e.Message}");
            }
        }
        static void SaveData()
        {
            try
            {
                // Ghi các máy bay cánh bằng vào tệp FixedWing.txt
                using (StreamWriter sw = new StreamWriter("FixedWing.txt"))
                {
                    foreach (Fixedwings fixedWing in fixedWings)
                    {
                        sw.WriteLine($"{fixedWing.ID},{fixedWing.Model},{fixedWing.CruiseSpeed},{fixedWing.EmptyWeight},{fixedWing.MaxTakeoffWeight},{fixedWing.RunwaySize},{fixedWing.MinNeededRunwaySize}");
                    }
                }

                // Ghi các trực thăng vào tệp Helicopter.txt
                using (StreamWriter sw = new StreamWriter("Helicopter.txt"))
                {
                    foreach (Helicopters helicopter in helicopters)
                    {
                        sw.WriteLine($"{helicopter.ID},{helicopter.Model},{helicopter.CruiseSpeed},{helicopter.EmptyWeight},{helicopter.MaxTakeoffWeight},{helicopter.Range},{helicopter.MaxTakeoffWeight}");
                    }
                }

                // Hiển thị một thông báo để cho biết việc lưu dữ liệu thành công
                Console.WriteLine("Lưu dữ liệu thành công.");
            }
            catch (Exception e)
            {
                // Hiển thị một thông báo để cho biết việc lưu dữ liệu không thành công
                Console.WriteLine($"Không thể lưu dữ liệu. Đã xảy ra lỗi: {e.Message}");
            }
        }

        static void HelicopterManagement()
        {
            // A boolean variable to control the loop
            bool running = true;

            // A menu-based feature in the console application
            while (running)
            {
                // Display the menu options
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create a helicopter");
                Console.WriteLine("2. Delete a helicopter");
                Console.WriteLine("3. Display list of all helicopter information, sorted by helicopter ID");
                Console.WriteLine("4. Display the status of one helicopter, selected by helicopter ID");
                Console.WriteLine("5. Return to main menu");

                // Get the user's choice
                int choice = int.Parse(Console.ReadLine());

                // Perform different actions based on the choice
                switch (choice)
                {
                    case 1:
                        // Create a helicopter
                        CreateHelicopter();
                        break;
                    case 2:
                        // Delete a helicopter
                        DeleteHelicopter();
                        break;
                    case 3:
                        // Display list of all helicopter information, sorted by helicopter ID
                        DisplayAllHelicopterInfo();
                        break;
                    case 4:
                        // Display the status of one helicopter, selected by helicopter ID
                        DisplayOneHelicopterStatus();
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

        static void DisplayOneHelicopterStatus()
        {
            try
            {
                // Prompt the user to enter a helicopter ID
                Console.WriteLine("Please enter a helicopter ID:");

                // Get the user's input and convert it to an integer
                string id = Console.ReadLine();

                // Find the helicopter with the matching ID using LINQ
                var helicopter = helicopters.FirstOrDefault(h => h.ID == id);

                // Check if the helicopter exists
                if (helicopter != null)
                {
                    // Display the helicopter's name and status
                    Console.WriteLine($"The helicopter with ID {id} is {helicopter.Model} and its CruiseSpeed is {helicopter.CruiseSpeed}.");
                }
                else
                {
                    // Display a message to indicate no matching helicopter found
                    Console.WriteLine($"No matching helicopter found with ID {id}.");
                }
            }
            catch (Exception e)
            {
                // Display a message to indicate the display is unsuccessful
                Console.WriteLine($"Failed to display a helicopter status. An error occurred: {e.Message}");
            }
        }
        static void DisplayAllHelicopterInfo()
        {
            try
            {
                // Sort the list of helicopters by their ID using LINQ
                var sortedHelicopters = helicopters.OrderBy(h => h.ID).ToList();

                // Check if the list is empty
                if (sortedHelicopters.Count == 0)
                {
                    // Display a message to indicate no helicopters in the list
                    Console.WriteLine("No helicopters in the list.");
                }
                else
                {
                    // Display a message to indicate the number of helicopters in the list
                    Console.WriteLine($"There are {sortedHelicopters.Count} helicopters in the list.");

                    // Loop through each helicopter in the sorted list
                    foreach (var helicopter in sortedHelicopters)
                    {
                        // Display the detailed information of each helicopter, including ID, model, cruise speed, empty weight, max takeoff weight, range and max flight time
                        Console.WriteLine($"ID: {helicopter.ID}, Model: {helicopter.Model}, Cruise Speed: {helicopter.CruiseSpeed} km/h, Empty Weight: {helicopter.EmptyWeight} kg, Max Takeoff Weight: {helicopter.MaxTakeoffWeight} kg, Range: {helicopter.Range} km, MaxTakeoffWeight: {helicopter.MaxTakeoffWeight} hours");
                    }
                }
            }
            catch (Exception e)
            {
                // Display a message to indicate the display is unsuccessful
                Console.WriteLine($"Failed to display helicopter information. An error occurred: {e.Message}");
            }
        }
        static void DeleteHelicopter()
        {
            try
            {
                // Prompt the user to enter a helicopter ID
                Console.WriteLine("Please enter a helicopter ID:");

                // Get the user's input and convert it to an integer
                string id = Console.ReadLine();

                // Find the helicopter with the matching ID using LINQ
                var helicopter = helicopters.FirstOrDefault(h => h.ID == id);

                // Check if the helicopter exists
                if (helicopter != null)
                {
                    // Remove the helicopter from the list of helicopters
                    helicopters.Remove(helicopter);

                    // Display a message to indicate the deletion is successful
                    Console.WriteLine($"Deleted the helicopter with ID {id} successfully.");
                }
                else
                {
                    // Display a message to indicate no matching helicopter found
                    Console.WriteLine($"No matching helicopter found with ID {id}.");
                }
            }
            catch (Exception e)
            {
                // Display a message to indicate the deletion is unsuccessful
                Console.WriteLine($"Failed to delete a helicopter. An error occurred: {e.Message}");
            }
        }

        static void CreateHelicopter()
        {
            try
            {
                // Prompt the user to enter the helicopter's ID
                Console.WriteLine("Please enter the helicopter's ID:");

                // Get the user's input and convert it to an integer
                string id = Console.ReadLine();

                // Check if the ID is valid (positive and unique)
                if (id.Count() > 0 && !helicopters.Any(h => h.ID == id))
                {
                    // Prompt the user to enter the helicopter's model
                    Console.WriteLine("Please enter the helicopter's model:");

                    // Get the user's input
                    string model = Console.ReadLine();

                    // Prompt the user to enter the helicopter's cruise speed
                    Console.WriteLine("Please enter the helicopter's cruise speed (in km/h):");

                    // Get the user's input and convert it to a double
                    double cruiseSpeed = double.Parse(Console.ReadLine());

                    // Prompt the user to enter the helicopter's empty weight
                    Console.WriteLine("Please enter the helicopter's empty weight (in kg):");

                    // Get the user's input and convert it to a double
                    double emptyWeight = double.Parse(Console.ReadLine());

                    // Prompt the user to enter the helicopter's max takeoff weight
                    Console.WriteLine("Please enter the helicopter's max takeoff weight (in kg):");

                    // Get the user's input and convert it to a double
                    double maxTakeoffWeight = double.Parse(Console.ReadLine());

                    // Prompt the user to enter the helicopter's range
                    Console.WriteLine("Please enter the helicopter's range (in km):");

                    // Get the user's input and convert it to a double
                    double range = double.Parse(Console.ReadLine());

                    // Prompt the user to enter the helicopter's max flight time
                    Console.WriteLine("Please enter the helicopter's max flight time (in hours):");

                    // Get the user's input and convert it to a double
                    double maxFlightTime = double.Parse(Console.ReadLine());

                    // Create a new helicopter object with the user's input
                    Helicopters helicopter = new Helicopters(id, model, cruiseSpeed, emptyWeight, maxTakeoffWeight, range);

                    // Add the new helicopter to the list of helicopters
                    helicopters.Add(helicopter);

                    // Display a message to indicate the creation is successful
                    Console.WriteLine($"Created a new helicopter with ID {id} successfully.");
                }
                else
                {
                    // Display a message to indicate the ID is invalid
                    Console.WriteLine($"Invalid ID. The ID must be positive and unique.");
                }
            }
            catch (Exception e)
            {
                // Display a message to indicate the creation is unsuccessful
                Console.WriteLine($"Failed to create a new helicopter. An error occurred: {e.Message}");
            }
        }

        static void FixedWingManagement()
        {
            // A boolean variable to control the loop
            bool running = true;

            // A menu-based feature in the console application
            while (running)
            {
                // Display the menu options
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create a fixed wing airplane");
                Console.WriteLine("2. Delete a fixed wing airplane");
                Console.WriteLine("3. Display list of all fixed wing airplane information, sorted by airplane ID");
                Console.WriteLine("4. Display the status of one fixed wing airplane, selected by airplane ID");
                Console.WriteLine("5. Return to main menu");

                // Get the user's choice
                int choice = int.Parse(Console.ReadLine());

                // Perform different actions based on the choice
                switch (choice)
                {
                    case 1:
                        // Create a fixed wing airplane
                        CreateFixedWing();
                        break;
                    case 2:
                        // Delete a fixed wing airplane
                        DeleteFixedWing();
                        break;
                    case 3:
                        // Display list of all fixed wing airplane information, sorted by airplane ID
                        DisplayAllFixedWingInfo();
                        break;
                    case 4:
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

        static void DisplayAllFixedWingInfo()
        {
            try
            {
                // Sort the list of fixed wing airplanes by their ID using LINQ
                var sortedFixedWings = fixedWings.OrderBy(f => f.ID).ToList();

                // Check if the list is empty
                if (sortedFixedWings.Count == 0)
                {
                    // Display a message to indicate no fixed wing airplanes in the list
                    Console.WriteLine("No fixed wing airplanes in the list.");
                }
                else
                {
                    // Display a message to indicate the number of fixed wing airplanes in the list
                    Console.WriteLine($"There are {sortedFixedWings.Count} fixed wing airplanes in the list.");

                    // Loop through each fixed wing airplane in the sorted list
                    foreach (var fixedWing in sortedFixedWings)
                    {
                        // Display the detailed information of each fixed wing airplane, including ID, model, cruise speed, empty weight, max takeoff weight, plane type and min needed runway size
                        Console.WriteLine($"ID: {fixedWing.ID}, Model: {fixedWing.Model}, Cruise Speed: {fixedWing.CruiseSpeed} km/h, Empty Weight: {fixedWing.EmptyWeight} kg, Max Takeoff Weight: {fixedWing.MaxTakeoffWeight} kg, Plane Type: {fixedWing.RunwaySize}, Min Needed Runway Size: {fixedWing.MinNeededRunwaySize} m");
                    }
                }
            }
            catch (Exception e)
            {
                // Display a message to indicate the display is unsuccessful
                Console.WriteLine($"Failed to display fixed wing airplane information. An error occurred: {e.Message}");
            }
        }

        static void DeleteFixedWing()
        {
            try
            {
                // Prompt the user to enter an airplane ID
                Console.WriteLine("Please enter an airplane ID:");

                // Get the user's input and convert it to an integer
                string id = Console.ReadLine();

                // Find the airplane with the matching ID using LINQ
                var fixedWing = fixedWings.FirstOrDefault(f => f.ID == id);

                // Check if the airplane exists
                if (fixedWing != null)
                {
                    // Remove the airplane from the list of fixed wing airplanes
                    fixedWings.Remove(fixedWing);

                    // Display a message to indicate the deletion is successful
                    Console.WriteLine($"Deleted the airplane with ID {id} successfully.");
                }
                else
                {
                    // Display a message to indicate no matching airplane found
                    Console.WriteLine($"No matching airplane found with ID {id}.");
                }
            }
            catch (Exception e)
            {
                // Display a message to indicate the deletion is unsuccessful
                Console.WriteLine($"Failed to delete an airplane. An error occurred: {e.Message}");
            }
        }

        static void CreateFixedWing()
        {
            try
            {
                // Prompt the user to enter the airplane's ID
                Console.WriteLine("Please enter the airplane's ID:");

                // Get the user's input and convert it to an integer
                string id = Console.ReadLine();

                // Check if the ID is valid (positive and unique)
                if (id.Count() > 0 && !fixedWings.Any(f => f.ID == id))
                {
                    // Prompt the user to enter the airplane's model
                    Console.WriteLine("Please enter the airplane's model:");

                    // Get the user's input
                    string model = Console.ReadLine();

                    // Prompt the user to enter the airplane's cruise speed
                    Console.WriteLine("Please enter the airplane's cruise speed (in km/h):");

                    // Get the user's input and convert it to a double
                    double cruiseSpeed = double.Parse(Console.ReadLine());

                    // Prompt the user to enter the airplane's empty weight
                    Console.WriteLine("Please enter the airplane's empty weight (in kg):");

                    // Get the user's input and convert it to a double
                    double emptyWeight = double.Parse(Console.ReadLine());

                    // Prompt the user to enter the airplane's max takeoff weight
                    Console.WriteLine("Please enter the airplane's max takeoff weight (in kg):");

                    // Get the user's input and convert it to a double
                    double maxTakeoffWeight = double.Parse(Console.ReadLine());

                    // Prompt the user to enter the airplane's plane type
                    Console.WriteLine("Please enter the airplane's plane type (CAG, LGR, VTOL):");

                    // Get the user's input and convert it to an enum
                    string runwaySize = Console.ReadLine();

                    // Prompt the user to enter the airplane's min needed runway size
                    Console.WriteLine("Please enter the airplane's min needed runway size (in m):");

                    // Get the user's input and convert it to a double
                    double minNeededRunwaySize = double.Parse(Console.ReadLine());

                    // Create a new fixed wing airplane object with the user's input
                    Fixedwings fixedWing = new Fixedwings(id, model, cruiseSpeed, emptyWeight, maxTakeoffWeight, runwaySize, minNeededRunwaySize);

                    // Add the new fixed wing airplane to the list of fixed wing airplanes
                    fixedWings.Add(fixedWing);

                    // Display a message to indicate the creation is successful
                    Console.WriteLine($"Created a new fixed wing airplane with ID {id} successfully.");
                }
                else
                {
                    // Display a message to indicate the ID is invalid
                    Console.WriteLine($"Invalid ID. The ID must be positive and unique.");
                }
            }
            catch (Exception e)
            {
                // Display a message to indicate the creation is unsuccessful
                Console.WriteLine($"Failed to create a new fixed wing airplane. An error occurred: {e.Message}");
            }
        }

        static void AirportManagement()
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

        static void InputData()
        {
            {
                try
                {
                    // Ask the user to enter the number of fixed wing airplanes to input
                    Console.Write("Enter the number of fixed wing airplanes to input: ");
                    int n = int.Parse(Console.ReadLine());

                    // Loop n times to input each fixed wing airplane information
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter information for fixed wing airplane {i + 1}:");
                        Console.Write("ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Model: ");
                        string model = Console.ReadLine();
                        Console.Write("Cruise Speed: ");
                        double cruiseSpeed = double.Parse(Console.ReadLine());
                        Console.Write("Empty Weight: ");
                        double emptyWeight = double.Parse(Console.ReadLine());
                        Console.Write("Max Takeoff Weight: ");
                        double maxTakeoffWeight = double.Parse(Console.ReadLine());
                        Console.Write("Plane Type: ");
                        string planeType = Console.ReadLine();
                        Console.Write("Min Needed Runway Size: ");
                        double minNeededRunwaySize = double.Parse(Console.ReadLine());

                        // Create a new fixed wing airplane object with the input data and add it to the list of fixed wing airplanes
                        Fixedwings fixedWing = new Fixedwings(id, model, cruiseSpeed, emptyWeight, maxTakeoffWeight, planeType, minNeededRunwaySize);
                        fixedWings.Add(fixedWing);
                    }

                    // Ask the user to enter the number of helicopters to input
                    Console.Write("Enter the number of helicopters to input: ");
                    int m = int.Parse(Console.ReadLine());

                    // Loop m times to input each helicopter information
                    for (int i = 0; i < m; i++)
                    {

                        Console.WriteLine($"Enter information for helicopter {i + 1}:");
                        Console.Write("ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Model: ");
                        string model = Console.ReadLine();
                        Console.Write("Cruise Speed: ");
                        double cruiseSpeed = double.Parse(Console.ReadLine());
                        Console.Write("Empty Weight: ");
                        double emptyWeight = double.Parse(Console.ReadLine());
                        Console.Write("Max Takeoff Weight: ");
                        double maxTakeoffWeight = double.Parse(Console.ReadLine());
                        Console.Write("Range: ");
                        double range = double.Parse(Console.ReadLine());

                        // Create a new helicopter object with the input data and add it to the list of helicopters
                        Helicopters helicopter = new Helicopters(id, model, cruiseSpeed, emptyWeight, maxTakeoffWeight, range);
                        helicopters.Add(helicopter);
                    }

                    // Ask the user to enter the number of airports to input
                    Console.Write("Enter the number of airports to input: ");
                    int k = int.Parse(Console.ReadLine());

                    // Loop k times to input each airport information
                    for (int i = 0; i < k; i++)
                    {
                        Console.WriteLine($"Enter information for airport {i + 1}:");
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
                    }

                    // Display a message to indicate the input data is successful
                    Console.WriteLine("Input data successfully.");
                }
                catch (Exception e)
                {
                    // Display a message to indicate the input data is unsuccessful
                    Console.WriteLine($"Input data unsuccessfully. An error occurred: {e.Message}");
                }
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