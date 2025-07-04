List<string> trainees = new List<string>
{
    "Liya",
    "Neha" ,
    "Anjali",
    "Serin",
    "Thanmaya",
    "Tom"
};

var startsWithT = from p in trainees where p.StartsWith("T") select p;

foreach (var trainee in startsWithT)
{
    Console.WriteLine(trainee);
}

Console.WriteLine();

Console.WriteLine("Contains a");

var containsa = trainees.Where(p => p.Contains("a"));
foreach (var trainee in containsa)
{
    Console.WriteLine(trainee);
}


