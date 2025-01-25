using Mission3Ass;

List<FoodItem> inventory = new List<FoodItem>();

Console.WriteLine("Welcome to your local food bank!");

while (true)
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add a food item");
    Console.WriteLine("2. Delete a food item");
    Console.WriteLine("3. Show all food items");
    Console.WriteLine("4. Exit the food bank");
    Console.WriteLine("Enter your choice (e.g. 3): ");

    if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
        continue;
    }

    if (choice == 1)
    {
        Console.WriteLine("Enter the food name: ");
        string name = Console.ReadLine();
    
        Console.WriteLine("Enter the food category: ");
        string category = Console.ReadLine();
    
        Console.WriteLine("Enter the quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int qty) || qty <= 0)
        {
            Console.WriteLine("Invalid quantity. Please enter a positive number.");
            continue;
        }

        Console.WriteLine("Enter the expiration date (e.g., MM/DD/YYYY): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime expDate))
        {
            Console.WriteLine("Invalid date. Please enter a valid date.");
            continue;
        }

        inventory.Add(new FoodItem(name, category, qty, expDate));
        Console.WriteLine("Food item added successfully!");
    }
    else if (choice == 2)
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("No food items to delete.");
            continue;
        }

        Console.WriteLine("Current food items:");
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {inventory[i]}");
        }

        Console.Write("Enter the number of the food item to delete: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > inventory.Count)
        {
            Console.WriteLine("Invalid choice. Please try again.");
            continue;
        }

        inventory.RemoveAt(index - 1);
        Console.WriteLine("Food item deleted successfully!");
    }
    else if (choice == 3)
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("No food items in inventory.");
        }
        else
        {
            Console.WriteLine("Current food items:");
            foreach (var item in inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
    else if (choice == 4)
    {
        Console.WriteLine("Thank you for using the food bank inventory system. Goodbye!");
        break;
    }
}
