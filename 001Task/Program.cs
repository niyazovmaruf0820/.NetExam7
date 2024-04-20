using System.Security.Cryptography.X509Certificates;
using _001Task;
using _001Task.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

await using var dataContext = new DataContext();


// Console.WriteLine(" Good look 😊😊😊 ");

//1
//Напишите запрос LINQ, чтобы получить всех людей, живущих в городе с населением более 3 милион человек.
//Write a LINQ query to retrieve all the people who live in a city with a population greater than 3 

// var people = (from p in dataContext.Peoples
//               join c in dataContext.Cities on p.CityId equals c.Id
//               where c.Population > 3000000
//               select new 
//               {
//                 People = p
//               });
// foreach (var item in people)
// {
//     System.Console.WriteLine($"{item.People.FirstName} {item.People.LastName}");
// }


//2
//Получите все города со средней численностью населения в соответствующей стране
//Retrieve all cities with their respective country's average population
// var avgOfPopulation = dataContext.Cities.Average(x => x.Population);
// //System.Console.WriteLine(avgOfPopulation);
// var cities = dataContext.Countries.Select(x => x.Cities.Where(i => i.Population == avgOfPopulation));

// foreach (var item in cities)
// {
//     System.Console.WriteLine($"CityName: {item} ");
// }

//3
//Получите города с самым высоким населением в каждой стране
//Retrieve the cities with the highest population in each country

// var cities = dataContext.Countries.Select(x => dataContext.Cities.OrderByDescending(i => i.Population).FirstOrDefault());

// foreach (var item in cities)
// {
//     System.Console.WriteLine($"{item.Name} {item.Population}");
// }


//4
//Получите среднее население городов в каждой стране
//Retrieve the average population of cities in each country

// var avgOfPopulations = dataContext.Countries.Select(x => x).Include(i => i.Cities);
// foreach (var item in avgOfPopulations)
// {
//     System.Console.WriteLine($"{item.Name} {item.Cities.Average(e => e.Population)}");
// }


//5
//Получить все города, в которых есть человек по имени "Марк".
//Retrieve all cities that have a person with by name "Mark"
// var cities = (from p in dataContext.Peoples
//               join c in dataContext.Cities on p.CityId equals c.Id
//               where p.FirstName == "Mark"
//               select new
//               {
//                 Cities = c
//               });

// foreach (var item in cities)
// {
//     System.Console.WriteLine($"{item.Cities.Name}");
// }

//6
//Получить всех людей вместе с соответствующими названиями городов и стран
//Retrieve all people along with their associated city and country names
// var people = (from p in dataContext.Peoples
//               join ci in dataContext.Cities on p.CityId equals ci.Id
//               join co in dataContext.Countries on ci.CountryId equals co.Id
//               select new
//               {
//                 FirstName = p.FirstName,
//                 LastName = p.LastName,
//                 City = ci.Name,
//                 Country = co.Name
//               });

// foreach (var item in people)
// {
//     System.Console.WriteLine($"{item.FirstName} {item.LastName} {item.City} {item.Country}");
// }

//7
//Получите все города вместе с соответствующими названиями стран, используя свойство навигации
//Retrieve all cities along with their associated country names using a navigation property
// var cities = dataContext.Cities.Select(t => t).Include(x => x.Country);

// foreach (var item in cities)
// {
//     System.Console.WriteLine($"{item.Name} {item.Country.Name}");
// }

//8
//Получить всех людей вместе с связанными с ними городом и страной.
//Retrieve all people along with their associated city and country 
// var people = dataContext.Peoples.Select(x => x).Include(x => x.City).ThenInclude(x => x.Country);


// foreach (var item in people)
// {
//     System.Console.WriteLine(item.FirstName);
//     System.Console.WriteLine("----");
//     System.Console.WriteLine($"City: {item.City.Name}");
//     System.Console.WriteLine($"Country: {item.City.Country.Name}");
//     System.Console.WriteLine("________________________________________________________________________________");
// }



//9
//Получить всех людей, живущих в "USA".
//Retrieve all people living in  "USA".
// var people = dataContext.Peoples.Select(x => x).Include(x => x.City).ThenInclude(x => x.Country).Where(x => x.City.Country.Name == "USA");

// foreach (var item in people)
// {
//     System.Console.WriteLine(item.FirstName);
//     System.Console.WriteLine(item.LastName);
//     System.Console.WriteLine("______________________________________________________");
// }
//10
//Получить всех людей вместе с соответствующим населением города и страны
//Retrieve all people along with their associated city and country populations 



// var people = dataContext.Peoples.Select(x => x).Include(x => x.City).ThenInclude(x => x.Country);


// foreach (var item in people)
// {
//     System.Console.WriteLine(item.FirstName);
//     System.Console.WriteLine("----");
//     System.Console.WriteLine($"City: {item.City.Population}");
//     System.Console.WriteLine($"Country: {item.City.Country.Cities.Sum(e => e.Population)}");
//     System.Console.WriteLine("________________________________________________________________________________");
// }







































