using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {        
     
        static void Main(string[] args)
        {
            //int[,] sayilar = new int[4, 3];
            //Random rnd = new Random();

            //for (int i = 0; i < sayilar.GetLength(0); i++)
            //{

            //    for (int j = 0; j < sayilar.GetLength(1); j++)
            //    {

            //        sayilar[i, j] = rnd.Next(10, 100);
            //    }
            //}
            //for (int i = 0; i < sayilar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sayilar.GetLength(1); j++)
            //    {         
            //        Console.WriteLine(sayilar[i,j] + " ");
            //    }
            //    Console.WriteLine();               
            //}

            //Console.WriteLine("Kaç adet öğrenci kaydetmek istiyorsunuz? ");
            //int adet = int.Parse(Console.ReadLine());
            //string[,] parametreler = new string[adet + 1, 3];
            //parametreler[0, 0] = "AD";
            //parametreler[0, 1] = "SOYAD";
            //parametreler[0, 2] = "NUMARA";
            //for (int i = 1; i < parametreler.GetLength(0); i++)
            //{
            //    for (int j = 0; j < parametreler.GetLength(1); j++)
            //    {
            //        if (j == 0)
            //        {
            //            Console.WriteLine($"{i}.Öğrencinin ismini giriniz");
            //            parametreler[i, j] = Console.ReadLine();
            //        }
            //        else if (j == 1)
            //        {
            //            Console.WriteLine($"{i}.Öğrencinin soyadını giriniz:");
            //            parametreler[i, j] = Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{i}.Öğrencinin numarasını giriniz:");
            //            parametreler[i, j] = Console.ReadLine();
            //        }

            //    }

            //}
            //for (int i = 0; i < parametreler.GetLength(0); i++)
            //{
            //    for (int j = 0; j < parametreler.GetLength(1); j++)
            //    {
            //        Console.Write(parametreler[i, j] + " ");
            //    }
            //    Console.WriteLine();

            //}

            try
            {
                Console.WriteLine("Kaç adet öğrenci kaydetmek istiyorsunuz?");
                int adet = int.Parse(Console.ReadLine());
                string[,] liste = new string[adet + 1, 4];
                liste[0, 0] = "Ad";
                liste[0, 1] = "Soyad";
                liste[0, 2] = "Sınıf"; 
                liste[0, 3] = "Numara";

                for (int i = 1; i < liste.GetLength(0); i++)
                {
                    for (int j = 0; j < liste.GetLength(1); j++)
                    {
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine($"{i}.Öğrencinin ismini giriniz");
                                liste[i, j] = Console.ReadLine();
                                break;
                            case 1:
                                Console.WriteLine($"{i}. Öğrencinin soyadını giriniz");
                                liste[i, j] = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine($"{i}.Öğrencinin sınıfını giriniz");
                                liste[i, j] = Console.ReadLine();
                                break;
                            case 3: Console.WriteLine($"{i}.Öğrencinin numarasını giriniz");
                                liste[i, j] = Console.ReadLine();
                                break;
                            default: Console.WriteLine("Hatalı giriş"); break;
                        }
                    }
                }
                for (int i = 0; i < liste.GetLength(0); i++)
                {
                    for (int j = 0; j < liste.GetLength(1); j++)
                    {
                        Console.Write(liste[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen sayı giriniz"); 
                
            } 

        }
    }
}
