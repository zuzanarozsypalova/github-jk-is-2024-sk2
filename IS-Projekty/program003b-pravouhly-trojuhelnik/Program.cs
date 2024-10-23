// chci, aby se program opakoval po stisku klávesy a 
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Pravoúhlý trojúhelník +++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++ Jiří Kvajsar +++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();


            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo):  ");    
            }
            
            // for(int i = 1; i<=10; i++){
            //     Console.WriteLine(i);
            // }

            // int j = 1;
            // while(j <= 10){
            //     Console.WriteLine(j);
            //     j++;
            // }

            for(int i = 1; i<= height ;i++) {
                for(int j=1; j<=i ;j++) {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));

                }
                Console.WriteLine();
            }
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }            
