using GenericCollectionOfClass2.Models;

List<Trainee> trainees = new List<Trainee>();

Trainee nathaniel = new Trainee
{
    Name = "Nathaniel",
    Location = "Kadavanthra",
    Points = 40
};

trainees.Add(nathaniel);

Trainee anjana = new Trainee
{
    Name = "Anjana",
    Location = "Malapuram",
    Points = 50
};

trainees.Add(anjana);

Trainee liya = new Trainee
{
    Name = "Liya",
    Location = "Malapuram",
    Points = 56
};

trainees.Add(liya);

var malapuram = trainees
    .Where(p => p.Location == "Malapuram");

foreach (var item in malapuram)
{
    Console.WriteLine($"{item.Name} \t {item.Location} \t {item.Points}");
}

Console.WriteLine();
Console.WriteLine("Sort");

var so = trainees.OrderBy(p => p.Name);
foreach (var item in so)
{
    Console.WriteLine($"{item.Name} \t {item.Location} \t {item.Points}");
}