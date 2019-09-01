using System;
using System.Collections.Generic;

namespace PracticeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackPractice();
            //QueuePractice();
            //BinarySearchPractice();
            //ClassPractice();
            //InterfacePractice();
            //OutAndRefPractice();
            //LambdaExpPractice();
            //ExtensionMethodsPractice();
            //OptionalArgumentPractice();
            //EventPractice();
            //DisplayingStringsInterpolation();

            Console.ReadKey();
        }

        private static void DisplayingStringsInterpolation()
        {
            string myName = "James";
            Console.WriteLine("Hello, my name is " + myName);
            Console.WriteLine("Hello, my name is {0}", myName);
            Console.WriteLine($"Hello, my name is {myName}");
        }


        static public event Action FormSubmitted;
        private static void EventPractice()
        {
            FormHandler formHandler = new FormHandler();
            Console.WriteLine("Hello");
            Console.WriteLine("Press Enter To Submit Form");
            Console.ReadKey();
            FormSubmitted();
        }

        private static void OptionalArgumentPractice()
        {
            DefaultPractice.printClassName("I specified a class name");
            DefaultPractice.printClassName();
        }

        private static void ExtensionMethodsPractice()
        {
            int starNumber = 5;
            Console.WriteLine("I will make some stars: " + starNumber.toStars());
        }

        private static void LambdaExpPractice()
        {
            RecyclingBin bin = new RecyclingBin("Garage", 2);
            RecyclingBin bin2 = new RecyclingBin("Bathroom", 8);

            List<RecyclingBin> bins = new List<RecyclingBin>();
            bins.Add(bin);
            bins.Add(bin2);

            var found = bins.Find(LambdaPractice.CheckFunction);
            Console.WriteLine("Was the bin found: " + found);

            //Using Lambda
            found = bins.Find(myBin => myBin.GetName() == "Garage");
            Console.WriteLine("Was the bin found: " + found);
        }


        private static void OutAndRefPractice()
        {
            Helper testClass = new Helper();

            int myValue = 6;
            testClass.FiveOut(out myValue);
            Console.WriteLine(myValue);

            myValue = 6;
            testClass.AddFiveRef(ref myValue);
            Console.WriteLine(myValue);
        }

        private static void InterfacePractice()
        {
            List<IBin> bins = new List<IBin>();

            RecyclingBin firstBin = new RecyclingBin("Kitchen", 7);
            RecyclingBin secondBin = new RecyclingBin("Bathroom", 12);
            RecyclingBin thirdBin = new RecyclingBin("Garage", 8);

            bins.Add(firstBin);
            bins.Add(secondBin);
            bins.Add(thirdBin);

            Console.WriteLine("Bin: {0}  Is it empty: {1}", firstBin.GetName(), firstBin.isEmpty);
            Console.WriteLine("Bin: {0}  Is it empty: {1}", secondBin.GetName(), secondBin.isEmpty);
            Console.WriteLine("Bin: {0}  Is it empty: {1}", thirdBin.GetName(), thirdBin.isEmpty);

            foreach (IBin bin in bins)
            {
                bin.Empty();
            }

            Console.WriteLine("Bins have been emptied");

            Console.WriteLine("Bin: {0}  Is it empty: {1}", firstBin.GetName(), firstBin.isEmpty);
            Console.WriteLine("Bin: {0}  Is it empty: {1}", secondBin.GetName(), secondBin.isEmpty);
            Console.WriteLine("Bin: {0}  Is it empty: {1}", thirdBin.GetName(), thirdBin.isEmpty);
        }

        private static void ClassPractice()
        {
            Lorry myLorry = new Lorry("James Lorry", 8, Vehicle.vehicleColor.BLACK);
            myLorry.PrintLorryColor();
            myLorry.Print();
            myLorry.Print("not so sure");
            myLorry.Move();
            myLorry.RemoveVehicle();
        }


        private static void BinarySearchPractice()
        {
            int[] array = new int[] { 1, 2, 5, 7, 8, 12, 20};
            BinarySearch bs = new BinarySearch(array);

            Console.WriteLine(bs.search(2));
        }


        //FIFO
        private static void QueuePractice()
        {
            Queue myQueue = new Queue();

            myQueue.enqueue(5);
            myQueue.enqueue(10);
            myQueue.enqueue(20);
            myQueue.print();
            myQueue.dequeue();
            myQueue.print();

        }

        //LIFO
        private static void StackPractice()
        {
            Stack myStack = new Stack();

            myStack.push(10);
            myStack.push(12);
            myStack.push(20);
            myStack.pop();
            myStack.print();

        }
    }
}
