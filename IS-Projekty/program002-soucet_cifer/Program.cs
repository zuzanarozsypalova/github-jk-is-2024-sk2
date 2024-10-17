// chci, aby se program opakoval po stisku klávesy a 
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+++ Soucet a soucin cifer ++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Jiří Kvajsar +++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo:  ");    
            }

            // Kontrola výpisu vstupní hodnoty
            Console.WriteLine("==============================");
            Console.WriteLine("Uživatel zadal: {0}", number);
            Console.WriteLine("===============================\n\n");

            int suma = 0;
            int numberBackup = number;
            int digit;
            int multipling = 1;
            
            // Pokud je čislo záporné číslo odstraníme
            if(number < 0){
                number = -number;
            }

            while(number >= 10){
                digit = number % 10; // % operátor modulo - určení zbytku po dělení
                number = (number - digit) / 10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
                multipling = multipling * digit; 


            }
            Console.WriteLine("Digit = {0}", number);
            suma = suma + number;
            multipling = multipling * number;

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma);
            Console.WriteLine("\n\nSoučin cifer čísla {0} je {1}", numberBackup, multipling);


            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();


        }            