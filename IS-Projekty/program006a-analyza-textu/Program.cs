// chci, aby se program opakoval po stisku klávesy a 
        string again = "y";
        while(again == "y" || again == "Y") {
            //Console.Clear();
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Název programu +++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Jiří Kvajsar +++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte text pro analýzu: ");
            string myText = Console.ReadLine();
            string samohlasky = "aáeéiíoóuůyý";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
            string cislice = "0123456789";

            int pocetsouhlasek = 0;
            int pocetsamohlasek = 0;
            int pocetcislic = 0;
            int pocetostatnichznaku = 0;

            foreach(char znak in myText){
                if(samohlasky.Contains(znak))
                    pocetsamohlasek++;
                else if (souhlasky.Contains(znak))
                    pocetsouhlasek++;
                else if (cislice.Contains(znak))
                    pocetcislic++;
                else
                    pocetostatnichznaku++;
            }
            
            Console.WriteLine("Počet samohlásek: {0} ", pocetsamohlasek);
            Console.WriteLine("Počet souhlásek: {0}", pocetsouhlasek);
            Console.WriteLine("Počet číslic: {0}", pocetcislic);
            Console.WriteLine("Počet ostatních: {0}", pocetostatnichznaku);
            
            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText[0]);
            Console.WriteLine(myText.Length);
            Console.WriteLine(myText[myText.Length-1]);
            

            // Opakování programu
            Console.WriteLine("Chcete program opakovat y/n: ");
            again = Console.ReadLine();


        }            