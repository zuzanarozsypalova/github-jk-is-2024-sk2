﻿        string again = "y";
        while(again == "y" || again == "Y") {
            //Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Generátor pseudonáhodných čísel +++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++ Jiří Kvajsar +++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel (celé číslo):  ");    
            }
            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo):  ");    
            }
            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo):  ");    
            }

            Console.WriteLine("\n\n========================================================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("\n\n======================================================\n\n");

            //deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            int interval01 = 0;
            int interval02 = 0;
            int interval03 = 0;
            int interval04 = 0;

            for(int i=0; i<n; i++){
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0},", myArray[i]);

                if(myArray[i] <= (0.25 * hm)){
                    interval01++;
                }
                else if(myArray[i] <= (0.5 * hm)){
                    interval02++;
                }
                else if(myArray[i] <= (0.75 * hm)){
                    interval03++;
                }
                else
                    interval04++;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nInterval <{0};{1}>: {2}", dm, 0.25 * hm, interval01);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Interval <{0};{1}>: {2}", 0.25 * hm + 1, 0.5 * hm, interval02);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Interval <{0};{1}>: {2}", 0.5 * hm + 1, 0.75 * hm, interval03);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Interval <{0};{1}>: {2}", 0.75 * hm + 1, hm, interval04);
            Console.ForegroundColor = ConsoleColor.Green;









            // Opakování programu
            Console.WriteLine("\n\nChcete program opakovat y/n?: ");
            again = Console.ReadLine();


        }