// 1 SOLUTION
class MovieLibrary {
   constructor() {
     this.movies = [];
   }
 
   addMovie(command) {
     const [_, name] = command.split("addMovie ");
     this.movies.push({ name });
   }
 
   addDirector(command) {
     const [movieName, directorName] = command.split(" directedBy ");
     const movie = this.movies.find((m) => m.name === movieName);
 
     if (movie) {
       movie.director = directorName;
     }
   }
 
   addDate(command) {
     const [movieName, date] = command.split(" onDate ");
     const movie = this.movies.find((m) => m.name === movieName);
 
     if (movie) {
       movie.date = date;
     }
   }
 }
 
 function createMovieLibrary() {
   let movies = [];
 
   return {
     addMovie: (command) => {
       const [_, name] = command.split("addMovie ");
       movies.push({ name });
     },
     addDirector: (command) => {
       const [movieName, directorName] = command.split(" directedBy ");
       const movie = movies.find((m) => m.name === movieName);
 
       if (movie) {
         movie.director = directorName;
       }
     },
     addDate: (command) => {
       const [movieName, date] = command.split(" onDate ");
       const movie = movies.find((m) => m.name === movieName);
 
       if (movie) {
         movie.date = date;
       }
     },
     getMovies() {
       return movies;
     },
   };
 }
 
 function solve(input) {
   const movieLibrary = new MovieLibrary();
 
   input.forEach((command) => {
     if (command.includes("addMovie")) {
       movieLibrary.addMovie(command);
     } else if (command.includes("directedBy")) {
       movieLibrary.addDirector(command);
     } else if (command.includes("onDate")) {
       movieLibrary.addDate(command);
     }
   });
 
   movieLibrary.movies
     .filter((m) => m.name && m.director && m.date)
     .forEach((m) => console.log(JSON.stringify(m)));
 }
  
  solve([
    "addMovie Fast and Furious",
    "addMovie Godfather",
    "Inception directedBy Christopher Nolan",
    "Godfather directedBy Francis Ford Coppola",
    "Godfather onDate 29.07.2018",
    "Fast and Furious onDate 30.07.2018",
    "Batman onDate 01.08.2018",
    "Fast and Furious directedBy Rob Cohen",
  ]);
  
  solve([
    "addMovie The Avengers",
    "addMovie Superman",
    "The Avengers directedBy Anthony Russo",
    "The Avengers onDate 30.07.2010",
    "Captain America onDate 30.07.2010",
    "Captain America directedBy Joe Russo",
  ]);

  // JUDGE 100/100
  
//function solve(input) {
//    let movies = [];
//
//    input.forEach((command) => {
//    if(command.includes("addMovie")) {
//        const [_,name] = command.split("addMovie ");
//        movies.push({ name });
//    } else if (command.includes("directedBy")) {
//        const [movieName, directorName] = command.split(" directedBy ");
//        const movie = movies.find((m) => m.name === movieName);
//
//        if (movie) {
//            movie.director = directorName;
//        }
//    } else if (command.includes("onDate")) {
//        const [movieName, date] = command.split(" onDate ");
//        const movie = movies.find((m) => m.name === movieName);
//
//        if (movie) {
//            movie.date = date;
//        }
//    }
//});
//
//movies
//    .filter((m) => m.name && m.director && m.date)
//    .forEach((m) => console.log(JSON.stringify(m)));
//}
//
//solve([
//    "addMovie Fast and Furious",
//    "addMovie Godfather",
//    "Inception directedBy Christopher Nolan",
//    "Godfather directedBy Francis Ford Coppola",
//    "Godfather onDate 29.07.2018",
//    "Fast and Furious onDate 30.07.2018",
//    "Batman onDate 01.08.2018",
//    "Fast and Furious directedBy Rob Cohen",
//  ]);
//  
//  solve([
//    "addMovie The Avengers",
//    "addMovie Superman",
//    "The Avengers directedBy Anthony Russo",
//    "The Avengers onDate 30.07.2010",
//    "Captain America onDate 30.07.2010",
//    "Captain America directedBy Joe Russo",
//  ]);
