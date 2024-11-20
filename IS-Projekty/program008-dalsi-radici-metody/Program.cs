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
            // Shaker sort
            int shakerNumberCompare = 0;
            int shakerNumberChangeRight = 0;
            int shakerNumberChangeLeft = 0;
            
            int start = 0; // Počáteční index (první číslo)
            int end = myArray.Length - 1; // Konečný index (poslední číslo)
            bool swapped = true; // Indikátor, zda došlo k výměně


            while(swapped){
                swapped = false;

                // Směrem doprava
                for(int i = start; i < end; i++){
                    shakerNumberCompare++;
                    if(myArray[i] > myArray[i + 1]){
                        // Prohození prvků
                        shakerNumberChangeRight++;
                        int temp = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = temp;
                        swapped = true; // Záznam, že došlo k výměně
                    }
                }
                end--; // Posunutí horní hranice

                // Směrem doleva
                for(int i = end; i > start; i--){
                    shakerNumberCompare++;
                    if (myArray[i] < myArray[i-1]){
                        // Prohození prvků
                        shakerNumberChangeLeft++;
                        int temp = myArray[i];
                        myArray[i] = myArray[i-1];
                        myArray[i-1] = temp;
                        swapped = true; // Záznam, že došlo k výměně
                    }
                }
                start++; // Posunutí dolní hranice
            }
            int shakerNumberChangeSum = shakerNumberChangeRight + shakerNumberChangeLeft;
            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i = 0; i < n; i++){
                Console.Write(" {0} ", myArray[i]);
            }

            // Comb Sort
            int combNumberCompare = 0;
            int combNumberChange = 0;

            double shrinkFactor = 1.3; // Zmenšovací faktor
            int gap = myArray.Length; // Počáteční mezera
            bool combswapped = true; // Indikátor, zda došlo k výměně

            while(gap > 1 || combswapped){
                // Aktualizace mezery
                gap = (int)(gap / shrinkFactor);
                if(gap < 1) gap = 1;

                combswapped = false;

                for (int i = 0; i + gap < myArray.Length; i++){
                    combNumberCompare++;
                    if (myArray[i] > myArray[i + gap]){
                        int temp = myArray[i];
                        myArray[i] = myArray[i+gap];
                        myArray[i + gap] = temp;

                        combNumberChange++;
                        combswapped = true;

                    }
                }
            }
            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i = 0; i < n; i++){
                Console.Write(" {0} ", myArray[i]);
            }
            
            //Shell sort
            int shellNumberCompare = 0;
            int shellNumberChange = 0;

            int shellgap = myArray.Length;

            while(gap > 1){
                gap = gap / 2;

                for(int i = gap; i < myArray.Length; i++){

                    int current = myArray[i];
                    int j = i;

                    // Posouvání větších prvků na správné místo v rámci podpole
                    while(j >= gap && myArray[j - gap] > current){
                        shellNumberCompare++;
                        myArray[j] = myArray[j - gap];
                        j -= gap; // Posun zpět o mezeru
                        shellNumberChange++;
                    }
                    // Vložení aktuálního prvku na správné místo
                    myArray[j] = current;
                }
            }
            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i = 0; i < n; i++){
                Console.Write(" {0} ", myArray[i]);
            }
            
            

            Console.WriteLine("\n\nSelection sort\nPočet porování: {0}", selectionnumberCompare);
            Console.WriteLine("Počet výměn: {0}", selectionnumberChange);

            Console.WriteLine("\n\nInsertion sort\nPočet porování: {0}", insertionnumberCompare);
            Console.WriteLine("Počet výměn: {0}", insertionnumberChange);

            Console.WriteLine("\n\nShaker sort\nPočet porovnání: {0}", shakerNumberCompare);
            Console.WriteLine("Počet výměn: {0}", shakerNumberChangeSum);

            Console.WriteLine("\n\nComb sort\nPočet porovnání: {0}", combNumberCompare);
            Console.WriteLine("Počet výměn: {0}", combNumberChange);
            
            Console.WriteLine("\n\nShell sort\nPočet porovnání: {0}", shellNumberCompare);
            Console.WriteLine("Počet výměn: {0}", shellNumberChange);
            // Opakování programu
            Console.WriteLine("\n\nChcete program opakovat y/n?: ");
            again = Console.ReadLine();


        }