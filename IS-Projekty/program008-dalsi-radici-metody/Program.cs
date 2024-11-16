using System.Globalization;
using System.Runtime.CompilerServices;

string again = "y";
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

            Console.WriteLine("\n\n==============================================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==============================================\n\n");

            //deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");
            for(int i=0; i<n; i++){
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write(" {0} ", myArray[i]);
            }
            
            // Proměnné pro výměnu a porovnání
            
            int selectionnumberCompare = 0;
            int selectionnumberChange = 0;

            // Selection sort
            for(int i = 0; i < n - 1; i++){
                int minIndex = i;
                // Prohledávání nesetříděné části
                for(int j = i + 1; j < n; j++){
                    selectionnumberCompare++;
                    if(myArray[j] < myArray[minIndex]){
                        minIndex = j;
                    }
                }
                if(minIndex != i){
                    int temp = myArray[i];
                    myArray[i] = myArray[minIndex]; 
                    myArray[minIndex] = temp;
                    selectionnumberChange++;
                }
            }
            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i = 0; i < n; i++){
                Console.Write(" {0} ", myArray[i]);
            }
            // Insertion sort
            // i = prvek, který chceme vložit na správné místo - od 1 jelikož se 1 považuje za seřazený
            int insertionnumberCompare = 0;
            int insertionnumberChange = 0;

            for(int i = 1; i < n; i++){
                int current = myArray[i];
                int j = i - 1;
                // Posouvání větších prvků doprava
                while(j >= 0){
                insertionnumberCompare++;
                    if(myArray[j] > current){
                        myArray[j + 1] = myArray[j];
                        j--;
                    } else {
                        break; // Ukočení smyčky pokud prvek není větší
                    }  
                }
                // Vložení prvku na správné místo
                myArray[j+1] = current;
                insertionnumberChange++;
 
            }
            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i = 0; i < n; i++){
                Console.Write(" {0} ", myArray[i]);
            }

            Console.WriteLine("\n\nSelection sort\nPočet porování: {0}", selectionnumberCompare);
            Console.WriteLine("Počet výměn: {0}", selectionnumberChange);

            Console.WriteLine("\n\nInsertion sort\nPočet porování: {0}", insertionnumberCompare);
            Console.WriteLine("Počet výměn: {0}", insertionnumberChange);


            // Opakování programu
            Console.WriteLine("\n\nChcete program opakovat y/n?: ");
            again = Console.ReadLine();


        }