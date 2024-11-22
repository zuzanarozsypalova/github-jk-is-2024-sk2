using System.Security.Cryptography.X509Certificates;

string again = "y";
        while(again == "y" || again == "Y") {
            //Console.Clear();
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Výpočet PI +++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Jiří Kvajsar +++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte přesnost(na kolik desetinných míst): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):  ");    
            }
            Console.Write("Zadejte hodnotu x: ");
            double hodnota_x;
            while(!double.TryParse(Console.ReadLine(), out hodnota_x)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):  ");    
            }

            double i = 1;
            double piCtvrt = 1;
            double znamenko = 1;

            while((1/i) >= presnost){
                i = i+2;
                znamenko = -znamenko;
                piCtvrt = piCtvrt + znamenko * (1/i);
                // if(znamenko == 1){
                //     Console.WriteLine("Zlomek: +1/{0}; aktuální hodnota PI = {1}", i, piCtvrt*4);
                // }
                // else
                //     Console.WriteLine("Zlomek: -1/{0}; aktuální hodnota PI = {1}", i, piCtvrt*4);
            }

            double pi = 4 * piCtvrt;
            Console.WriteLine("Hodnota PI: {0}", pi);
            Console.WriteLine("Hodnota PI: {0:f4}", pi);

        
            double n = 1;
            double znamenko_ln = 1;
            double ln = 1;

            while((1/n) >= presnost){
                n = n+1;
                znamenko_ln = -znamenko_ln;
                ln = ln + znamenko_ln * (1/n);
            
            }

            double ln2 = ln;
            Console.WriteLine("Hodnota ln 2: {0}", ln2);

            int k = 20;
            double j = 1;
            double znamenko_ex = 1;
            double eul = 1;
            

            for(int u = 1; u <= k; u++){
                j *= u;
                double xpower = Math.Pow(hodnota_x, u); // x na u 
                double temp = xpower/j;
                if(Math.Abs(temp) < presnost)
                    break;

                eul = eul + znamenko_ex * temp;
                
              }
            
            Console.WriteLine("Hodnota e na x: {0}", eul);


            // Opakování programu
            Console.WriteLine("Chcete program opakovat y/n?");
            again = Console.ReadLine();


        }            
