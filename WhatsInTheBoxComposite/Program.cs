namespace WhatsInTheBoxComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var harddrive = new Leaf("Hard drive ", 2000, 2);
            var ram = new Leaf("Ram", 1000, 2);
            var cpu = new Leaf("CPU", 6000, 1);
            var mouse = new Leaf("Mouse", 1500, 4);
            var keyboard = new Leaf("Keyboard", 1700, 4);

            Composite motherboard = new Composite("Motherboard", 5000, 1);
            Composite cabinet = new Composite("Cabinet", 2000, 1);
            Composite peripherals = new Composite("Peripherals", 0, 0);
            Composite computer = new Composite("Computer", 0, 0);

            motherboard.AddItem(ram);
            motherboard.AddItem(cpu);

            cabinet.AddItem(harddrive);
            cabinet.AddItem(motherboard);

            peripherals.AddItem(keyboard);
            peripherals.AddItem(mouse);

            computer.AddItem(cabinet);
            computer.AddItem(peripherals);

            Console.WriteLine("Total price is :"+
                computer.CalculateTotalPrice());
            Console.ReadLine();

        }
    }
}
