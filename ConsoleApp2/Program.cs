//Prosty program generujący pseudolosowe wyniku rzutu kością o zadanej ilości ścianek
//zainicjuj generator liczb losowych
Random rng = new Random();
//prygotuj zmienną na wynik rzutu
int randomThrow = 0;
char choice;
do
{
    Console.WriteLine("Podaj jaką kością chcesz rzucić:");
    Console.WriteLine("1. K3");
    Console.WriteLine("2. K4");
    Console.WriteLine("3. K6");
    Console.WriteLine("q. Wyjście");
    Console.Write("Wybrna opcja: ");
    choice = Console.ReadKey().KeyChar;
    //pusta linia - separator
    Console.WriteLine();
    //w zależności od wyboru użytkownika...
    switch (choice)
    {
        case '1':
            //przypadek jeśli użytkownik wybierze 1
            randomThrow = rng.Next(1, 3);
            Console.WriteLine("Rzut kością K3: " + randomThrow.ToString());
            break;
        case '2':
            //przypadek jeśli wybierze 2
            randomThrow = rng.Next(1, 4);
            Console.WriteLine("Rzut kością K4: " + randomThrow.ToString());
            break;
        case '3':
            //przypadek jeśli 3
            randomThrow = rng.Next(1, 6);
            Console.WriteLine("Rzut kością K6: " + randomThrow.ToString());
            break;
        case 'q':
            break;
        default:
            Console.WriteLine("Podałeś złą opcję!");
            break;
    }
}
while (choice != 'q');
