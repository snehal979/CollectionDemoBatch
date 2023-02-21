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
                Console.WriteLine("hint 1.list 2.Stack 3.Dictionary 4.Queue 5.exit");
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
                        DoQueuesDemo();
                        break;
                    case 5:
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
            Console.WriteLine("-------------Using Enumerator--------------");
            List<string>.Enumerator enumerator = list.GetEnumerator();
            while (enumerator.MoveNext()) //bool condition return true
            {
                Console.WriteLine(enumerator.Current); // current position in queue list//It is get property
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
            Console.WriteLine("----------using enumrators-----------");
            Stack<string>.Enumerator enumerator = stack.GetEnumerator();
            while (enumerator.MoveNext()) //bool condition return true
            {
                Console.WriteLine(enumerator.Current); // current position in queue list//It is get property
            }
        }
        public static void DoDictionaryDemo()
        {
            Console.WriteLine("Dictionary Collection");
            Dictionary<int, string> dictionay = new Dictionary<int, string>();
            dictionay.Add(1, "Snehal");
            dictionay.Add(2, "Mayur");
            dictionay.Add(3, "Vaibhav");
            dictionay.Add(4, "Raju");
            dictionay.Add(5, "Lata");
            Console.WriteLine("Access of value using key "+dictionay[1]);//key value number
            foreach (var element in dictionay)
            {
                Console.WriteLine("key :"+element.Key+" value :"+element.Value);
            }
            Console.WriteLine("----------using enumrators-----------");
            Dictionary<int, string>.Enumerator enumerator = dictionay.GetEnumerator();
            while (enumerator.MoveNext()) //bool condition return true
            {
                Console.WriteLine(enumerator.Current); // current position in queue list//It is get property
            }
        }
        private static void DoQueuesDemo()
        {
            Console.WriteLine("Queue Collection");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Snehal");
            queue.Enqueue("Mayur");
            queue.Enqueue("Vaibhav");
            queue.Enqueue("Raju");
            queue.Enqueue("Lata");
            Console.WriteLine("element is peek is :"+queue.Peek()); //top element
            Console.WriteLine("element is dequeue is :"+queue.Dequeue()); //Top delete element
            foreach (var item in queue) //Display 
            {
                Console.WriteLine(item); ;
            }
            Console.WriteLine("----------using enumrators-----------");
            //Enumerators uses -read data ,not modify data.
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext()) //bool condition return true
            {
                Console.WriteLine(enumerator.Current); // current position in queue list//It is get property
            }
        }
    }
}
