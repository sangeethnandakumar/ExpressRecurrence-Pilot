using Express.Recurrence.Builder.Interfaces;
using Express.Recurrence.Interfaces;

IPattern pattern = new RecurrenceBuilder()
                    .Every(6)
                    .OfEvery(4)
                    .Months();

var generatedDates = pattern.Generate(DateTime.Now, DateTime.Now.AddYears(1));


Console.WriteLine("Generating Dates");

foreach (var date in generatedDates)
{
    Console.WriteLine(date);
}

Console.Read();