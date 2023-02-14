using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2A1B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
            Random r = new Random();
            string[] Data = new string[4];           
            for (int i = 0; i < 4; i++)
            {
                Data[i] = r.Next(1, 10).ToString();
                for (int j = 0; j < i; j++)
                {
                    if (Data[i] == Data[j])
                    {
                        j = 0;
                        Data[i] = r.Next(1, 10).ToString();
                    }
                }
              
            }
            string gm = Data[0] + Data[1] + Data[2] + Data[3];          
            string guess="";
            //Console.WriteLine($"答案是{gm}");
                do
                {
                    int a = 0, b = 0;
                    Console.WriteLine("來猜數字囉");
                    guess = Console.ReadLine();
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (guess[i] == gm[j])
                            {
                                if (i == j)
                                {
                                    a++;
                                }
                                else b++;
                            }
                        }

                    }
                    Console.WriteLine($"結果是{a}A{b}B");
                } while ( guess != gm);
                Console.WriteLine("你答對了");
                Console.WriteLine("繼續玩請按y");
            } while(Console.ReadLine() == "y" );
        }
        }
        }

    


