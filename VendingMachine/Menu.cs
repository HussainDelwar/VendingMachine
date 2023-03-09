namespace VendingMachine
{
    public class Menu
    {
        public void DisplayMenu()
        {
            bool run = true;
            Machine machine = new Machine();
            machine.DisplayBalance();
            while (run)
            {
                Console.WriteLine("Select from one of the following options:");
                Console.WriteLine("1. Insert coin");
                Console.WriteLine("2. Select product");
                Console.WriteLine("3. Return coins");
                if (machine.exactChange) 
                    Console.WriteLine("4. Switch to returning change");
                else
                    Console.WriteLine("4. Switch to exact change only");

                Console.WriteLine("5. Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        machine.InsertCoins();
                        machine.DisplayBalance();
                        break;
                    case "2":
                        machine.SelectProduct();
                        break;
                    case "3":
                        machine.ReturnCoins();
                        machine.DisplayBalance();
                        break;
                    case "4":
                        machine.exactChange = !machine.exactChange;
                        machine.DisplayBalance();
                        break;
                    case "5":
                        run = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
