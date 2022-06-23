using System;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = getInt();
            int num2 = getInt();
            int num3 = getInt();
            int num4 = getInt();

            Directions();

            int sum = calculateSum(num1, num2, num3, num4);

            double Average = calculateAverage(sum, num1, num2, num3, num4);

            Printresults(num1, num2, num3, num4, sum, Average);
        }

        public static void Directions()
        {
           //more code here
        }

        public static int getInt1()
        {
            int num1 = 0;
            //Add code from chart
            return num1;
           
        }
        public static int getInt2()
        {
            int num2 = 0;
            //Add code from chart
            return num2;
            
        }
        public static int getInt3()
        {
            int num3 = 0;
            //Add code from chart
            return num3;
            
        }
        public static int getInt()
        {
            int num4 = 0;
            //Add code from chart
            return num4;
            
        }
        public static int calculateSum(int n1, int n2, int n3, int n4)
        {
            int total = 0;
            total = n1 + n2 + n3 + n4;
            //Add code here 
            return total;
            
             
        }

        public static double calculateAverage(int sum, int num1, int num2, int num3, int num4)
        {
            double avg = 0.0; ;
            //Add code here
            return avg;
        }

        public static void Printresults(int num1, int num2, int num3,int num4, int sum, double Average)
        {
            int results = 0;
            //Add code here like "the 4 nums entered are this..."
            Printresults(num1, num2, num3, num4, sum, Average);
        }

        public static void mathV1()
        {
            

        }
    }
      
}

