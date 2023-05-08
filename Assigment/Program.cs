using System;

using System.CodeDom.Compiler;

using System.Collections.Generic;

using System.Diagnostics.CodeAnalysis;

using System.Linq;

using System.Security.Cryptography.X509Certificates;

using System.Text;

using System.Threading.Tasks;

using System.Xml;


namespace Iteration_Recursion_Ex

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //find the sum of n to m natural numbers 

            //input a number: n=2 m=5 

            //Expected Output: The numerber of digits in the number is:14 



            int lowerBound, upperBound;, sum1, temp;





            Console.WriteLine("Enter two numbers: ");

            lowerBaound = int.Parse(Console.ReadLine());

            upperBaound = int.Parse(Console.ReadLine());



            Console.WriteLine($"The sum(by iteration) of numbers from {lowerBound} to " + $"{upperBound} is {sum}");

            if (upperBound < lowerBound)

            {

                temp = upperBound;

                upperBound = lowerBound;

                lowerBound = temp;

            }

            sum1 = SumByIteration(lowerBound, upperBound);  

] 

        }

        //By Iteration 

        static int SumByIteration(int m, int n)//m=2, n=5 

        {

            int sum = 0;



            for (int i = m; i <= n; i++)

            {

                sum = sum + i;  //sum = 0+2 = 2, i=3 

                //sum = 2+3=5,i=4 

                //sum=5+4=9, i=5 

                //sum=9+5=14, i=6 

            }

            return sum;

        }



    }

} 

//////////////////////////////////////////////////////////////////////////////////////////////////////////////using System; 

using System.CodeDom.Compiler; 

using System.Collections.Generic; 

using System.Diagnostics.CodeAnalysis; 

using System.Linq; 

using System.Security.Cryptography.X509Certificates; 

using System.Text; 

using System.Threading.Tasks; 

using System.Xml; 

 

namespace Iteration_Recursion_Ex

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //find the sum of n to m natural numbers 

            //input a number: n=2 m=5 

            //Expected Output: The numerber of digits in the number is:14 



            int lowerBound, upperBound, sum1, sum2, temp;





            Console.WriteLine("Enter two numbers: ");

            lowerBound = int.Parse(Console.ReadLine());

            upperBound = int.Parse(Console.ReadLine());





            if (upperBound < lowerBound)

            {

                temp = upperBound;

                upperBound = lowerBound;

                lowerBound = temp;

            }

            sum1 = SumByIteration(lowerBound, upperBound);

            sum2 = SumByRecursion(lowerBound, upperBound);



            Console.WriteLine($"The sum(by iteration) of numbers from {lowerBound} to " + $"{upperBound} is {sum1}");

        }

        //By Iteration 

        static int SumByIteration(int m, int n)//m=2 n=5 

        {

            int sum = 0;



            for (int i = m; i <= n; i++)

            {

                sum = sum + i;  //sum = 0+2 = 2, i=3 

                //sum = 2+3=5,i=4 

                //sum=5+4=9, i=5 

                //sum=9+5=14, i=6 

            }

            return sum;

        }

        //By Recursion  

        static int SumByRecursion(int m, int n)

        {

            int sum;



            if (m == n) //base case 

                sum = m; //2+3+4+5=14 



            else

            {

                sum = m + SumByRecursion(m + 1, n); //2+ sum(3,5) 

                //2+3+ Sum 



            }

            return sum;

        }

    }

}

