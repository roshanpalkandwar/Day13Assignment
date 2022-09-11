namespace AssignmentDay13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome to generic method");
            Console.WriteLine("enter chooes\n1.maximum number");
            int opt=Convert.ToInt32(Console.ReadLine());
            
            switch(opt)
            {
                case 1:
                    MaxNumber maxNumber = new MaxNumber();
                    int val = maxNumber.PrintMaxNumber<int>(23, 45, 60);
                    Console.WriteLine("max number is "+val);
                    break;
            }

            
        }
    }
}