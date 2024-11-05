string again = "y";
while(again == "y" || again == "Y") {
    Console.WriteLine("************************************************");
    Console.WriteLine("********** Generování různých obrazců **********");
    Console.WriteLine("****************** Jiří Kvajsar ****************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

    Console.Write("Zadejte výšku obrazce (celé číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height)) {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo): ");
    }

    // Přesýpací hodiny
    for(int n = height; n >= 1; n--) {
        for(int c = 1; c <= height - n; c++) {
            Console.Write(" ");
        }
        for(int d = 1; d <= 2 * n; d++) {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for(int i = 1; i <= height; i++) { // Počet řádků, který se vygeneruje
        for(int j = 1; j <= height - i; j++) {
            Console.Write(" ");
        }
        for(int t = 1; t <= 2 * i; t++) {
            Console.Write("*");
        }
        Console.WriteLine(); // Přechod na nový řádek
    }
    Console.WriteLine("\n\n");
   
   // Generování Z
    Console.Write("Zadejte výšku obrazce (celé číslo): ");
    int height2;
    while(!int.TryParse(Console.ReadLine(), out height2)) {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo): ");
    }

    for(int u = 1; u <= height2; u++) {
        if(u == 1 || u == height2) {
            for(int s = 1; s <= height2; s++) {
                Console.Write("*");
            }
        } else {
            for(int s = 1; s <= height2; s++) {
                if(s == height2 - u + 1) {
                    Console.Write("*");
                } else {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n\n");
    
    // Šachovnice
    Console.Write("Zadejte výšku obrazce (celé číslo): ");
    int height3;
    while(!int.TryParse(Console.ReadLine(), out height3)) {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo): ");
    }
    for(int w = 0; w < height3; w++){
        for(int y = 0; y < height3; y++){
            if((w + y) % 2 == 0){
                Console.Write("* ");
            }
            else{
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }

    // Opakování programu
    Console.WriteLine("\nChcete program opakovat y/n: ");
    again = Console.ReadLine();
}
