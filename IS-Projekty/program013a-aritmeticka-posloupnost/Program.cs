        // chci, aby se program opakoval po stisku klávesy a 
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Název programu +++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Jiří Kvajsar +++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int digit_count;
            while(!int.TryParse(Console.ReadLine(), out digit_count)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):  ");    
            }
            int difference;
            while(!int.TryParse(Console.ReadLine(), out difference)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):  ");    
            }
            int first_digit;
            while(!int.TryParse(Console.ReadLine(), out first_digit)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):  ");    
            }

            int sum = 0;
            int momentary_number = first_digit;
            
            for(int i = 0; i < digit_count; i++){
                Console.Write(momentary_number);
                if(i < digit_count - 1){
                    Console.Write("; ");
                }
                sum = sum + momentary_number;
                momentary_number = momentary_number + difference;
            }

            Console.WriteLine();
            Console.WriteLine("Suma čísel je: {0}", sum);

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();


        }   