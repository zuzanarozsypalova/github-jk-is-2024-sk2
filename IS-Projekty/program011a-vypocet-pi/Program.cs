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

            double i = 1;
            double piCtvrt = 1;
            double znamenko = 1;

            while((1/i) >= presnost){
                i = i+2;
                znamenko = -znamenko;
                piCtvrt = piCtvrt + znamenko * (1/i);
                if(znamenko == 1){
                    Console.WriteLine("Zlomek: +1/{0}; aktuální hodnota PI = {1}", i, piCtvrt*4);
                }
                else
                    Console.WriteLine("Zlomek: -1/{0}; aktuální hodnota PI = {1}", i, piCtvrt*4);
            }

            double pi = 4 * piCtvrt;
            Console.WriteLine("Hodnota PI: {0}", pi);
            Console.WriteLine("Hodnota PI: {0:f4}", pi);

        




            // Opakování programu
            Console.WriteLine("Chcete program opakovat y/n?");
            again = Console.ReadLine();


        }            
