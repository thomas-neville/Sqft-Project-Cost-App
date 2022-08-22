public class SqftCalculator
{
    public static void Main()
    {
        // Declare variables
        double lengthNum, widthNum, matCostNum, spaceSqft, projectCost;
        string lengthString, widthString, matCostString;
        
        // Collect the information from the user about
        System.Console.WriteLine("This is a calculator for determining the flooring cost of your project. We will ask for the length, width, and material cost to calculate this. Please start by entering the length of the space: ");
        lengthString = System.Console.ReadLine();
        lengthNum = Convert.ToDouble(lengthString);

        System.Console.WriteLine("Now enter the width of the space: ");
        widthString = System.Console.ReadLine();
        widthNum = Convert.ToDouble(widthString);

        System.Console.WriteLine("Finally, enter the cost per squarefoot of material for the project: ");
        matCostString = System.Console.ReadLine();
        matCostNum = Convert.ToDouble(matCostString);

        // Calculate the cost
        spaceSqft = lengthNum * widthNum;
        projectCost = spaceSqft * matCostNum;

        // Output the project cost to the user
        System.Console.WriteLine("The cost of your project will be {0:C} based on the total sqft of the space {1}", projectCost, spaceSqft);
    }
}