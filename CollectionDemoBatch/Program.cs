using System.Globalization;

namespace CollectionDemoBatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Collection Demo");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("hint 1.list 2.exit");
                int num = Convert.ToInt16(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        DoListDemo();
                        break;
                    case 2:
                        Console.WriteLine("Exit");
                        flag=false;
                        break;
                }
            }           Console.ReadLine();
        }
        private static void DoListDemo()
        {
            Console.WriteLine("List Collection");
            List<string> list = new List<string>();
            list.Add("Snehal");
            list.Add("Mayur");
            list.Add("Vaibhav");
            list.Add("Raju");
            list.Add("Lata");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
