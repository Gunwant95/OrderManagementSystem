using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_01
{
    class Program
    {
      /*  static int a = 0, b = 1, c = 0;
        static void printFibo(int count)
        {
            if(count>0)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
                printFibo(count - 1);
            }
        }   */

        

        static void Main(string[] args)
        {

            // Fibonacci
            /*   int no;           
               Console.WriteLine("Enter No");
               no = Int32.Parse(Console.ReadLine());
               Console.Write(a + " " + b);

                    while (no>0)
                    {
                        c = a + b;
                        Console.Write(" " + c);
                        a = b;
                        b = c;
                        no--;
                    }  */

            // printFibo(no-2);   // Recursive Fibo

            // Prime
            /*  int no, flag=0,i;
              Console.WriteLine("Enter No");
              no = Int32.Parse(Console.ReadLine());

              if(no==0 || no ==1)
              {
                  Console.WriteLine("No is not prime");
              }
              for(i=2;i<=no/2;i++)
              {
                  if(no%i == 0)
                  {
                      Console.WriteLine("No is not prime");
                      flag = 1;
                      break;
                  }
              }
              if(flag == 0 )
              {
                  Console.WriteLine("No is prime");
              }  */

            /*     int firstno, lastno, flag=0,i;
                 Console.WriteLine("Enter first No");
                 firstno = Int32.Parse(Console.ReadLine());
                 Console.WriteLine("Enter last No");
                 lastno = Int32.Parse(Console.ReadLine());

                 if(firstno == 0 || firstno == 1)
                 {
                     firstno = 2;
                 }
                 if(firstno%2 == 0 && firstno !=2)
                 {
                     firstno = firstno + 1;
                 }

                 for(i=firstno;i<=lastno;i++)
                 {
                     flag = 0;
                     for(int j=2;j<=i/2;j++)
                     {
                         if(i%j == 0)
                         {
                             flag = 1;
                             break;
                         }
                     }
                     if(flag == 0)
                     {
                         Console.Write(i+" ");
                     }
                 }    */

            // palindrom 
            /*  int no, rev=0, rem=0,no1;
              Console.WriteLine("Enter No");
              no = Int32.Parse(Console.ReadLine());
              no1 = no;

              while(no>0)
              {
                  rem = no % 10;
                  rev = rev * 10 + rem;
                  no = no / 10;
              }

              if(no1 == rev)
              Console.WriteLine("Palindrom");   */

            //  Factorial  
            /*     int no,fact=1;
                 Console.WriteLine("Enter No");
                 no = Convert.ToInt32(Console.ReadLine());

                 for(int i=1;i<=no;i++)
                 {
                     fact = fact * i;
                 }
                 Console.WriteLine(fact);  */
              
            // Armstrong
            /*  int no, sum = 0, rem = 0, no1;
              Console.WriteLine("Enter No");
              no = Int32.Parse(Console.ReadLine());
              no1 = no;
              while(no>0)
              {
                  rem = no % 10;
                  sum = sum + rem * rem * rem;
                  no = no / 10;
              }
              if (no1 == sum)
                  Console.WriteLine("No is armstrong");
              else
                  Console.WriteLine("No is not armstrong"); */

            // Bubble Sort
            /*   int[] a = new int[] { 10,2,3,15,1,7,8};

               for(int i=0;i<a.Length;i++)
               {
                   for(int j=1;j<a.Length-i;j++)
                   {
                       if(a[j-1]>a[j])
                       {
                           int temp;
                           temp = a[j];
                           a[j] = a[j - 1];
                           a[j - 1] = temp;
                       }
                   }
               }

               for(int i=0;i<a.Length;i++)
               {
                   Console.WriteLine(a[i]+" ");
               }
               */
            // Selection sort
            /*   int[] a = new int[] { 10, 2, 3, 15, 1, 7, 8 };

               for (int i = 0; i < a.Length; i++)
               {
                   for (int j = i+1; j < a.Length; j++)
                   {
                       if (a[j] < a[i])
                       {
                           int temp;
                           temp = a[i];
                           a[i] = a[j];
                           a[j] = temp;
                       }
                   }
               }

               for (int i = 0; i < a.Length; i++)
               {
                   Console.WriteLine(a[i] + " ");
               }   */
            // Insertion Sort
         /*   int[] a = new int[] { 10, 2, 3, 15, 1, 7, 8 };
            int key,j;

            for (int i = 1; i < a.Length; i++)
            {
                key = a[i];
                j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = key;
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }    */










            Console.ReadLine();
        }
    }
}


