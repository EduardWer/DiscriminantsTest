using Discriminants;

namespace Discriminants.Test;

public class Tests
{
    public DiscriminantCalc _discriminants;

    [SetUp]
    public void Setup()
    {
        _discriminants = new DiscriminantCalc();
    }

    [Test]
    public void DiscriminantCalcCollection__exeptionNullRoot()
    {
        var result = _discriminants.DiscriminantCalcCollection(1, 2, 3);
         CollectionAssert.AllItemsAreUnique(new[] {result},"Значения не одинаковые или их нет"); // проверка на одинаковые значения 
    }
    [Test]
    public void DiscriminantCalcCollection_1min2_1_exeptionOneRoot() // ноль
    {
        var exepted = (1,1);
        var result = _discriminants.DiscriminantCalcCollection(1, -2, 1);
       CollectionAssert.AreEquivalent(new[] {exepted},new[] {result});
       CollectionAssert.AllItemsAreUnique(new[] {result},"Значения не одинаковые ");
        
    }
    [Test]
    public void DiscriminantCalcCollection_1min32_exeptionTwoRoots()
    {
        var exepted = (2.0, 1.0);
        var result = _discriminants.DiscriminantCalcCollection(1, -3, 2);
        CollectionAssert.AreEqual(new[] { exepted },new[] { result });
        CollectionAssert.IsSubsetOf(new[] { exepted },new[] { result });
    }
    
    
    [Test]
    public void CalculatePercentage__exepted()
    {
        double number = 100;
        double percentage = 10;
        double expected = 20;
        double delta = 10;

        double result = _discriminants.CalculatePercentage(number, percentage);
        Assert.AreEqual(expected, result, delta);
    }
    
}

public class DiscriminantsCalc
{
}