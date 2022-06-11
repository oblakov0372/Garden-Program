using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();
            string data = null;
            string answer= null;
            Console.WriteLine("Enter data");
            do
            {
                data = Console.ReadLine();
                if (data != "end")
                {
                    answer += data +" ";
                }
            } while (data != "end");
            string[] answerSplit = answer.Split();
            List<string> className = new List<string>();
            List<int> count = new List<int>();
            for(int i = 0;i< answerSplit.Length-1; i+=2)
            {
                className.Add(answerSplit[i]);
                count.Add(Int32.Parse(answerSplit[i + 1]));
            }
            for(int i = 0;i< className.Count; i++)
            {
                if(className[i] == "Lily")
                {
                    for(int j = 1;j<= count[i]; j++)
                    {
                        Lily lily = new Lily();
                        garden.AddToList(lily);
                    }
                }else if(className[i] == "Carotte")
                {
                    for (int j = 1; j <= count[i]; j++)
                    {
                        Carotte carotte = new Carotte();
                        garden.AddToList(carotte);
                    }
                    
                }else if (className[i] == "Rose")
                {
                    for (int j = 1; j <= count[i]; j++)
                    {
                        Rose rose = new Rose();
                        garden.AddToList(rose);
                    }

                }else if (className[i] == "Strawberry")
                {
                    for (int j = 1; j <= count[i]; j++)
                    {
                        Strawberry strawberry = new Strawberry();
                        garden.AddToList(strawberry);
                    }

                }else if (className[i] == "Acacia")
                {
                    for (int j = 1; j <= count[i]; j++)
                    {
                        Acacia acacia = new Acacia();
                        garden.AddToList(acacia);
                    }

                }else if (className[i] == "Apricot")
                {
                    for (int j = 1; j <= count[i]; j++)
                    {
                        Apricot apricot = new Apricot();
                        garden.AddToList(apricot);
                    }

                }else if (className[i] == "Oak")
                {
                    for (int j = 1; j <= count[i]; j++)
                    {
                        Oak oak = new Oak();
                        garden.AddToList(oak);
                    }

                }else if (className[i] == "Peach")
                {
                    for (int j = 1; j <= count[i]; j++)
                    {
                        Peach peach = new Peach();
                        garden.AddToList(peach);
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine(garden.BeautyScore());
            Console.WriteLine(garden.WaterRequired());
            Console.WriteLine(garden.Energy());
            Console.ReadLine();
        }
    }
}
