using Moja_aplikacja;

Console.WriteLine("Moja biblioteka filmów 4K");
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine("++ Tworzenie nowego użytkownika. ++");
Console.WriteLine("Podaj login:");
string NewUser = Console.ReadLine();
var user1 = new UserInMemory(NewUser);
//var user1 = new UserInFile(NewUser);
Console.WriteLine();

if (user1 != null)
{
    Console.WriteLine("Użytkownik o loginie " + NewUser + " został Utworzony.");
}
Console.WriteLine();

while (true)
{
    Console.WriteLine("1. Wciśniej '1' aby dodać nowy film do listy.");
    Console.WriteLine("2. Wciśniej '2' aby wyświetlić listę filmów.");
    Console.WriteLine("3. Wciśniej '3' aby wyświetlić statystyki");
    Console.WriteLine("4. Wciśniej 'q' aby wyjść z programu.");
    var input = Console.ReadLine(); 

    if (input == "1")
    {
        Console.WriteLine();
        Console.WriteLine("Podaj tytuł filmu:");
        user1.AddMovie(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Podaj ocenę filmu:");
        try
        {
            user1.AddGrade(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
        Console.WriteLine();
        Console.WriteLine("Dodano nowy film do biblioteki.");
        Console.WriteLine();
    }

    
    else if (input == "2")
    {
        Console.WriteLine();
        Console.WriteLine("=== Lista Filmów ===");
        user1.ShowMovies();
        Console.WriteLine("====================");
        Console.WriteLine();
    }

    else if (input == "3")
    {
        var statistics = user1.GetStatistics();
        Console.WriteLine();
        Console.WriteLine("=== Statystyki ocen Filmów ===");
        Console.WriteLine($"Średnia ocen filmów: {statistics.Average:N2}");
        Console.WriteLine($"Najniższa ocena: {statistics.Min}");
        Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
        Console.WriteLine("==============================");
        Console.WriteLine();
    }

    else if (input == "q")
    {
        break;
    }

    else
    {
        Console.WriteLine();
        Console.WriteLine("===========================================");
        Console.WriteLine("Zła komenda");
        Console.WriteLine("===========================================");
        Console.WriteLine();
    }

}

    //try
    //{
    //    user1.AddGrade(input);
    //}
    //catch (Exception e)
    //{
    //    Console.WriteLine($"Exception catched: {e.Message}");
    //}

// Pierwsza wersja


//Console.WriteLine("Moja biblioteka filmów 4K");
//Console.WriteLine("===========================================");
//Console.WriteLine();

//var movie = new MovieInFile("Meg");
//movie.AddScore(2);
//var statistics = movie.GetStatistics();
//Console.WriteLine(movie.Title)

//while (true)
//{
//    Console.WriteLine("1. Wciśniej '1' aby dodać nowy film do listy.");
//    Console.WriteLine("2. Wciśniej '2' aby wyświetlić listę filmów.");
//    Console.WriteLine("3. Wciśniej 'q' aby wyjść z programu.");
//    var input = Console.ReadLine();

//    if (input == "1")
//    {
//        Console.WriteLine("Podaj tytuł filmu");
//        string NewMovie = Console.ReadLine();
//        var movie = new MovieInMemory(NewMovie);
//        Console.WriteLine("Podaj ocenę filmu:");
//        movie.AddScore(Console.ReadLine());
//    }

//    else if (input == "2")
//    {
//        var statistics = movie.GetStatistics(); 
//    }

//    else if (input == "3")
//    {

//    }

//    else if (input == "q")
//    {
//        break;
//    }

//    else
//    {
//        Console.WriteLine("===========================================");
//        Console.WriteLine("Zła komenda");
//        Console.WriteLine("===========================================");
//        Console.WriteLine();
//    }
//}


//while (true)
//{
//    Console.WriteLine("Dodaj nowy film do listy: (Podaj tytuł i ocenę)");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }
//    else if(input)

//try
//{
//    movie.AddMovie(input);
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Exception catched: {e.Message}");
//}
//}