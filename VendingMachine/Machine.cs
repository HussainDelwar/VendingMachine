namespace VendingMachine
{
    public class Machine
    {
        public bool exactChange = false;
        private decimal balance = 0;
        private readonly decimal onePence = .01m;
        private readonly decimal twoPence = .02m;
        private readonly decimal fivePence = .05m;
        private readonly decimal tenPence = .10m;
        private readonly decimal twentyPence = .20m;
        private readonly decimal fiftyPence = .50m;
        private readonly decimal onePound = 1;
        private readonly decimal twoPound = 2;

        public void InsertCoins()
        {
            Console.WriteLine("");
            Console.WriteLine("Select from one of the following options:");
            Console.WriteLine("1. 1p");
            Console.WriteLine("2. 2p");
            Console.WriteLine("3. 5p");
            Console.WriteLine("4. 10p");
            Console.WriteLine("5. 20p");
            Console.WriteLine("6. 50p");
            Console.WriteLine("7. £1");
            Console.WriteLine("8. £2");
            Console.WriteLine("9. Invalid object (Buttons, Washers etc)");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    balance = decimal.Add(balance, onePence);
                    break;
                case "2":
                    balance = decimal.Add(balance, twoPence);
                    break;
                case "3":
                    balance = decimal.Add(balance, fivePence);
                    break;
                case "4":
                    balance = decimal.Add(balance, tenPence);
                    break;
                case "5":
                    balance = decimal.Add(balance, twentyPence);
                    break;
                case "6":
                    balance = decimal.Add(balance, fiftyPence);
                    break;
                case "7":
                    balance = decimal.Add(balance, onePound);
                    break;
                case "8":
                    balance = decimal.Add(balance, twoPound);
                    break;
                case "9":
                    RejectCoin();
                    break;
                default:
                    break;
            }
        }

        public void SelectProduct()
        {
            Console.WriteLine("");
            Console.WriteLine("Select from one of the following options:");
            Console.WriteLine("1. Cola Price £1.00");
            Console.WriteLine("2. Crisps Price £0.50");
            Console.WriteLine("3. Chocolate Price £0.65 (SOLD OUT)");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    PurchaseProduct(1);
                    break;
                case "2":
                    PurchaseProduct(.50m);
                    break;
                case "3":
                    SoldOut();
                    break;
            }
        }

        private void PurchaseProduct(decimal price)
        {
            if (balance > price)
            {
                Console.WriteLine("THANK YOU");
                ReturnCoins();
                Console.WriteLine("");
                InsertCoin();
            }
            else if (balance == price)
            {
                Console.WriteLine("THANK YOU");
                balance = 0;
                Console.WriteLine("");
                InsertCoin();
            }
            else if (balance < price)
            {
                Console.WriteLine($"PRICE £{price}");
                DisplayBalance();
            }
        }

        private void SoldOut()
        {
            Console.WriteLine("SOLD OUT");
            DisplayBalance();
        }

        public void InsertCoin()
        {
            if (exactChange)
            {
                Console.WriteLine("EXACT CHANGE ONLY");
            }
            else
            {
                Console.WriteLine("INSERT COIN");
            }
        }

        public void DisplayBalance()
        {
            if (balance != 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"BALANCE £{balance}");
            }
            else
            {
                Console.WriteLine("");
                InsertCoin();
            }
        }

        private void RejectCoin()
        {
        }

        public void ReturnCoins()
        {
            balance = 0;
        }
    }
}
