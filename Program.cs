namespace List_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Task 1. Write a program that takes a list of integers as input and removes duplicate numbers,
           keeping only the unique elements. Implement a method that accepts the list and returns 
           a new list containing only the unique elements in the original order.

                       */
            Console.WriteLine("Task 1. Write a program that takes a list of integers as input and removes duplicate numbers," +
                "\r\nkeeping only the unique elements. Implement a method that accepts the list and returns " +
                "\r\na new list containing only the unique elements in the original order.");

            Console.WriteLine();
            Console.WriteLine("==========================");

            List<int> listWithDuoblicate = new List<int> { 1, 2, 3, 4, 3, 3, 2, 6, 8, 9, 7, 8, 5 };
            Console.WriteLine("With Duplicate Numbers");
            foreach (int element in listWithDuoblicate)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Without Duplicate Numbers");

            List<int> listWithoutDuoblicate = listWithDuoblicate.Distinct().ToList();


            foreach (int element in listWithoutDuoblicate)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Without Duplicate Numbers, With sort");
            listWithoutDuoblicate.Sort();
            foreach (int element in listWithoutDuoblicate)
            {
                Console.WriteLine(element);
            }


            /*
            Task 2. Implement a program that takes a list of strings as input and performs the following operations:
            Remove all elements that contain a specific character specified by the user.
            Sort the remaining elements in ascending order.
            Return the modified list.
            */

            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("2. Implement a program that takes a list of strings as input and performs the following operations:" +
                "\r\nRemove all elements that contain a specific character specified by the user.\r\nSort the remaining elements in ascending order." +
                "\r\nReturn the modified list.\r\n");

            List<String> stringList = new List<String>();
            stringList.Add("Ahmed");
            stringList.Add("Zayd");
            stringList.Add("Mohammed");
            stringList.Add("Muhanad");
            stringList.Add("saleh");
            stringList.Add("khalfan");
            stringList.Add("khalid");
            stringList.Add("Dawood");

            Console.WriteLine("Remove all elements that contain a specific character specified by the user. ");
            stringList.RemoveAll(x => x.Contains("k"));

            foreach (string element in stringList)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("Sort the remaining elements in ascending order. ");
            stringList.Sort();
            foreach (string element in stringList)
            {
                Console.WriteLine(element);
            }


            /*
           Task 3. Write a program that finds the maximum value in a list of integers.
           Implement a method that accepts the list as input and returns the maximum value.

           */

            Console.WriteLine("3. Write a program that finds the maximum and minimum value in a list of integers.\r\n" +
                "Implement a method that accepts the list as input and returns the maximum and minimum value.");
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("All number");
            Console.WriteLine();

            List<int> Numbers = new List<int> { 15, 5, 72, 49, 23, 35, 20, 16 };
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine($"The maximum number is {Numbers.Max()}");
            Console.WriteLine($"The Minimum number is {Numbers.Min()}");



            /*
            Task 4. Write a program that takes a string as an input and is a sentence. It should return a string with words in reverse order.
            Input : Hello!!! World. We are awesome.
            Output: awesome. are We World. Hello!!!
            */

            Console.WriteLine("4. Write a program that takes a string as an input and is a sentence. It should return a string with words in reverse order." +
                "\r\nInput : Hello!!! World. We are awesome.\r\nOutput: awesome. are We World. Hello!!!");

        }
    }
}
