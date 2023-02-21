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
                Console.WriteLine("hint 1.list 2.Stack 3.Dictionary 4.exit");
                int num = Convert.ToInt16(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        DoListDemo();
                        break;
                    case 2:
                        DoStackDemo();
                        break;
                    case 3:
                        DoDictionaryDemo();
                        break;
                    case 4:
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
            Console.WriteLine("Access of value using key "+list[1]);//Index number start with zero
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void DoStackDemo()
        {
            Console.WriteLine("Stack Collection"); //Last in First out
            Stack<string> stack = new Stack<string>();
            stack.Push("Snehal");  //1
            stack.Push("Mayur");  //2
            stack.Push("Vaibhav");  //3
            stack.Push("Raju");  //4
            stack.Push("Lata"); //5
            stack.Push("Hina"); //6
            Console.WriteLine("Top of the element"+stack.Peek());//Top element
            Console.WriteLine("the element pop is : "+stack.Pop()); //delect top element
            foreach (var item in stack)   //display
            {
                Console.WriteLine(item); ;
            }
        }
        public static void DoDictionaryDemo()
        {
            Console.WriteLine("Dictionary Collection");
            Dictionary<int, string> dictionay = new Dictionary<int, string>();
            dictionay.Add(1, "Snehal");
            dictionay.Add(2, "Mayur");
            dictionay.Add(3, "vaibhav");
            dictionay.Add(4, "raju");
            dictionay.Add(5, "lata");
            Console.WriteLine("Access of value using key "+dictionay[1]);//key value number
            foreach (var element in dictionay)
            {
                Console.WriteLine("key :"+element.Key+" value :"+element.Value);
            }
        }
    }
}
