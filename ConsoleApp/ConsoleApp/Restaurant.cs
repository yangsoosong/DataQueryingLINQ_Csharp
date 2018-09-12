using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Restaruarnt
{
    //instance variables
    private string name;
    private string address;
    private double gratuityRate;

    //properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public double GratuityRate
    {
        get { return gratuityRate; }
        set
        {
            if (value >= 0)
            {
                gratuityRate = value;
            }
        }
    }

    //constructor
    public Restaruarnt(string name, string address, double gratuityRate)
    {
        Name = name;
        Address = address;
        GratuityRate = gratuityRate;
    }

    // Using a sentinel-controlled WHILE loop, the method will collect theprice for each food item ordered,
    // and will collect the price for each food item ordered, and it will keep a subtotal for an arbitrary number of food items.
    // Once the subtotla of all food itmes has been calculated, the method will then dertemine the amount for gratuity
    // if the party consisted of 6 or more people. The grand total will be the subtotla plus gratuity. 
    // The method also display the amounts for subtotal, gratuity, and grand total.
    public void GenerateReceipt()
    {
        double price = 0;
        double subTotal = 0;
        double gratuityAmount = 0;
        int people = 0;
        double grandTotal = 0;

        while (price != -1)
        {
            subTotal += price;
            Console.Write("Enter price of food item [-1 to quit] : ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        Console.Write("How many people in your party: ");
        people = Convert.ToInt32(Console.ReadLine());
        if (people >= 6)
        {
            gratuityAmount = subTotal * gratuityRate;
        }

        grandTotal = subTotal + gratuityAmount;

        Console.WriteLine("Subtotal: {0}", subTotal);
        Console.WriteLine("{0} Gratuity: {1}", gratuityRate, gratuityAmount);
        Console.WriteLine("Total: {0}", grandTotal);
    }
}


