// See https://aka.ms/new-console-template for more information
var fizzBuzz = new FizzBuzz();
Enumerable.Range(1, 100)
    .ToList()
        .ForEach(
                c => Console.WriteLine(fizzBuzz.GetOutput(c))
                );

