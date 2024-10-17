// chci, aby se program opakoval po stisku klávesy a 
using System.Diagnostics.CodeAnalysis;

string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Součet cifer vlastní řešení +++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++ Jiří Kvajsar ++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();

            // Vstup od uživatele
            Console.Write("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo:  ");    
             }

            Console.WriteLine("==============================");
            Console.WriteLine("Uživatel zadal: {0}", number);
            Console.WriteLine("===============================\n\n");

            // Proměnné pro výpočty
            int soucet = 0;
            int soucin = 1;
            
            // Převod čísla na string
            string numberString = number.ToString();

            // Procházení každé cifry čísla
            foreach(char digit in numberString){
                int numericValue = digit - '0';
                soucet = soucet + numericValue;
                soucin = soucin * numericValue;
            }

            // Výstup součtu a součinu
            Console.WriteLine("\n\nSoučet cifer {0} je {1}", number, soucet);
            Console.WriteLine("Součin cifer {0} je {1}", number, soucin);


            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
}