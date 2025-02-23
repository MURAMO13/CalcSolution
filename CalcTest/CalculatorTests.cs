using Calc;
namespace CalcTest;
/// <summary>
/// Тесты для класса Calculator
/// </summary>
class CalculatorTests
{

    [Test]
    public void AdditionalTest()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Additional(1, 2);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void SubtractionTest()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Subtraction(1, 2);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void MiltiplicationTest()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Miltiplication(1, 2);
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void DivisionTest() 
    {
        Calculator calculator = new Calculator();
        int result = calculator.Division(1, 2);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void DivisionByZeroTest()
    {
        Calculator calculator = new Calculator();
        
        var ex = Assert.Throws<Exception>(() => calculator.Division(1, 0));

        Assert.That(ex.Message, Is.EqualTo("На ноль делить нельзя!"));
    }


}
