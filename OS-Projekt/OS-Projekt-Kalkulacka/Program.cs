

        // chci, aby se program opakoval po stisku klávesy y 
        string again = "y";
        while(again == "y" || again == "Y") {
            //Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Kalkulacka metrik obrazců +++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++ Jiří Kvajsar +++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();

            int choice;

           // Vstup od uživatele při vybírání obrazce
            Console.WriteLine("Vyberte si z následující nabídky obrazec pro který chcete provést výpočet obsahu/obvodu: \n");
            Console.WriteLine("Pro ctverec - 1");
            Console.WriteLine("Pro obdelnik - 2");
            Console.WriteLine("Pro trojuhelnik - 3");
            while(!int.TryParse(Console.ReadLine(), out choice)){
                Console.Write("Nezadali jste celé číslo 1-3. Zadejte prosím číslo 1-3.: ");
            }

            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine("Uzivatel vybral: {0}", choice);
            Console.WriteLine("++++++++++++++++++++++++++++");

            if (choice == 1){

                Console.WriteLine("Vybrali jste si čtverec!");
                int a;
                Console.WriteLine("Zadejte délku strany a (celé číslo): \n");
            
                // Zpracování vstupu s ověřením platnosti                
                if(int.TryParse(Console.ReadLine(), out a)){
                    Console.WriteLine($"\nObvod čtverce = {4 * a}");
                    Console.WriteLine($"Obsah čtverce = {a * a}");
                }
                else{
                    Console.WriteLine("Zadaná hodnota není platné celé číslo. Zadejte prosím celé číslo.");
                }
            }

            else if(choice == 2){
                Console.WriteLine("Vybrali jste si obdelník!");
                int a, b;
                Console.WriteLine("Zadejte délku strany a (celé číslo): ");
                while (!int.TryParse(Console.ReadLine(), out a)){
                    Console.WriteLine("Zadaná hodnota není platné celé číslo. Zadejte prosím celé číslo.");   
                }
                Console.WriteLine("Zadejte délku strany b (celé číslo): ");
                while (!int.TryParse(Console.ReadLine(), out b)){
                    Console.WriteLine("Zadaná hodnota není platné celé číslo. Zadejte prosím celé číslo.");
                }
                Console.WriteLine($"\nObvod obdelníku = {2 * (a+b)}");
                Console.WriteLine($"Obsah obdelníku = {a * b}");               

            }
            else if (choice == 3){
                Console.WriteLine("Vybrali jste si trojúhelník!");
                int a, b, c;
                Console.WriteLine("Zadejte délku strany a (celé číslo): ");
                while (!int.TryParse(Console.ReadLine(), out a)){
                    Console.WriteLine("Zadaná hodnota není platné celé číslo. Zadejte prosím celé číslo.");   
                }
                Console.WriteLine("Zadejte délku strany b (celé číslo): ");
                while (!int.TryParse(Console.ReadLine(), out b)){
                    Console.WriteLine("Zadaná hodnota není platné celé číslo. Zadejte prosím celé číslo.");
                }
                Console.WriteLine("Zadejte délku strany c (celé číslo): ");
                while(!int.TryParse(Console.ReadLine(), out c)){
                   Console.WriteLine("Zadaná hodnota není platné celé číslo. Zadejte prosím celé číslo."); 
                }
                Console.WriteLine($"\nObvod obdelníku = {a + b +c}");

            }
            else{
                Console.WriteLine("Neplatná volba, zadejte číslo 1, 2 nebo 3. \n");
            }
            // Opakování programu
            Console.WriteLine("\nChcete spustit kalkulačku znovu (y/n): ");
            again = Console.ReadLine();


        }       
