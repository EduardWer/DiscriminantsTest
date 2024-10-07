namespace Discriminants;

public class DiscriminantCalc
{
    public (double, double) DiscriminantCalcCollection(double a ,double b,double c)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            throw new InvalidOperationException("Дискриминант меньше нуля"); // обработка ошибки чтоб приведение типов не ломать 
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            return (root, root);
        }
        else
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return (root1, root2);
        }
    }
    
    public double CalculatePercentage(double number, double percentage)
    {
        return (number * percentage) / 100;
    }
}