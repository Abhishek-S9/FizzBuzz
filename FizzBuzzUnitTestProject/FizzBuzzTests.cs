using NUnit.Framework;

[TestFixture]
public class FizzBuzzTests
{
    private IFizzBuzz fizzBuzz;

    [SetUp]
    public void SetUp()
    {
        fizzBuzz = new FizzBuzz();
    }

    [Test]
    public void GetOutput_DivideBy3_ReturnsFizz()
    {
        var output = fizzBuzz.GetOutput(3);
        Assert.AreEqual("Fizz", output);
    }

    [Test]
    public void GetOutput_DivideBy5_ReturnsBuzz()
    {
        var output = fizzBuzz.GetOutput(5);
        Assert.AreEqual("Buzz", output);
    }

    [Test]
    public void GetOutput_DivideBy3And5_ReturnsFizzBuzz()
    {
        var output = fizzBuzz.GetOutput(15);
        Assert.AreEqual("FizzBuzz", output);
    }

    [Test]
    public void GetOutput_NotDivideBy3Or5_ReturnsNumber()
    {
        var output = fizzBuzz.GetOutput(7);
        Assert.AreEqual("7", output);
    }
}
