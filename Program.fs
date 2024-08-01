// For more information see https://aka.ms/fsharp-console-apps
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

type Director = {
    FullName: string
    TotalMovies: int
}

type Movie = {
    Title: string
    Duration: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

let movie1 = { 
    Title = "CODA"; 
    Duration = 111; 
    Genre = Drama; 
    Director = { FullName = "Sian Heder"; TotalMovies = 9 }; 
    IMDBRating = 8.1 
}

let movie2 = { 
    Title = "Belfast"; 
    Duration = 98; 
    Genre = Comedy; 
    Director = { FullName = "Kenneth Branagh"; TotalMovies = 23 }; 
    IMDBRating = 7.3 
}

let movie3 = { 
    Title = "Don't Look Up"; 
    Duration = 138; 
    Genre = Comedy; 
    Director = { FullName = "Adam McKay"; TotalMovies = 27 }; 
    IMDBRating = 7.2 
}

let movie4 = { 
    Title = "Drive My Car"; 
    Duration = 179; 
    Genre = Drama; 
    Director = { FullName = "Ryusuke Hamaguchi"; TotalMovies = 16 }; 
    IMDBRating = 7.6 
}

let movie5 = { 
    Title = "Dune"; 
    Duration = 155; 
    Genre = Fantasy; 
    Director = { FullName = "Denis Villeneuve"; TotalMovies = 24 }; 
    IMDBRating = 8.1 
}

let movie6 = { 
    Title = "King Richard"; 
    Duration = 144; 
    Genre = Sport; 
    Director = { FullName = "Reinaldo Marcus Green"; TotalMovies = 15 }; 
    IMDBRating = 7.5 
}

let movie7 = { 
    Title = "Licorice Pizza"; 
    Duration = 133; 
    Genre = Comedy; 
    Director = { FullName = "Paul Thomas Anderson"; TotalMovies = 49 }; 
    IMDBRating = 7.4 
}

let movie8 = { 
    Title = "Nightmare Alley"; 
    Duration = 150; 
    Genre = Thriller; 
    Director = { FullName = "Guillermo Del Toro"; TotalMovies = 22 }; 
    IMDBRating = 7.1 
}

let allMovies = [movie1; movie2; movie3;  movie4;  movie5; movie6; movie7; movie8]


let oscarProbables = List.filter (fun movie -> movie.IMDBRating > 7.4) allMovies

let formatRunLength duration =
    let hours = duration / 60
    let minutes = duration % 60
    sprintf "%d h %d min" hours minutes

let formattedDurations = List.map (fun movie -> formatRunLength movie.Duration) allMovies
printfn"Collection of all movies :%s" allMovies 
printfn "Probable Oscar Winners:"
oscarProbables |> List.iter (fun movie -> printfn "%s" movie.Title)

printfn "\nRun Lengths in Hours and Minutes:"
formattedDurations |> List.iter (printfn "%s")
