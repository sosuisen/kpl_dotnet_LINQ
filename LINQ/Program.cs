List<Task> tasks = [
    new Task("Buy milk", DateTime.Now),
    new Task("Buy PC", new DateTime(2023, 12, 24), true),
    new Task("Buy chocolate", new DateTime(2024, 2, 14), true)
];

// query syntax
/*
 var results = from t in tasks
            select $"{t.Name}, {t.Deadline}";
*/
// var results = tasks.Select(t => $"{t.Name}, {t.Deadline}");

/*
var results = from t in tasks
              where t.Deadline < new DateTime(2024, 1, 1)
              select $"{t.Name}, {t.Deadline}";
*/
/*
var results = tasks.Where(t => t.Deadline < new DateTime(2024, 1, 1))
    .Select(t => $"{t.Name}, {t.Deadline}");
*/
/*
var results = from t in tasks
              where t.Name.Contains("milk")
              select $"{t.Name}, {t.Deadline}";
*/
/*
   var results = tasks.Where(t => t.Name.Contains("milk"))
    .Select(t => $"{t.Name}, {t.Deadline}");
*/
/*
var results = from t in tasks
              orderby t.Deadline descending
              select $"{t.Name}, {t.Deadline}";
*/
var results = tasks.OrderByDescending(t => t.Deadline)
    .Select(t => $"{t.Name}, {t.Deadline}");

var num = tasks.Where(t => t.Deadline > new DateTime(2024, 1, 1)).Count();
Console.WriteLine(num);

var num2 = tasks.Count(t => t.Deadline > new DateTime(2024, 1, 1));
Console.WriteLine(num2);

foreach (var item in results)
{
    Console.WriteLine(item);
}

class Task(string name, DateTime deadline, bool completed = false)
{
    public string Name { get; set; } = name;
    public DateTime Deadline { get; set; } = deadline;
    public bool Completed { get; set; } = completed;
}
