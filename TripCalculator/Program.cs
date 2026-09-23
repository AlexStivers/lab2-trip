/*
* Name: Alex Stivers
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 22, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

Console.WriteLine("=== Part 1: Road Trip ===");
Console.Write("How many miles is the round trip? ");
double totalMiles = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the miles per gallon for the car you drove? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the price per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = totalMiles / milesPerGallon;
double fuelCost = pricePerGallon * gallonsNeeded;

Console.WriteLine();

Console.WriteLine("Gallons needed:" + " " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost:" + " " + fuelCost.ToString("C"));

Console.WriteLine();

Console.WriteLine("=== Part 2: Pizza Party ===");
Console.Write("How many people are going to the pizza party? ");
double partyPeople = Convert.ToDouble(Console.ReadLine());
Console.Write("How many pizzas are you ordering? ");
double totalPizzas = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the price per pizza? ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

const double slicesPerPizza = 8;

double totalSlices = slicesPerPizza * totalPizzas;
double slicesPerPerson = totalSlices / partyPeople;
double pizzaCost = totalPizzas * pizzaPrice;

Console.WriteLine();

Console.WriteLine("Total slices:" + " " + totalSlices);
Console.WriteLine("Slices per person:" + " " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost:" + " " + pizzaCost.ToString("C"));

Console.WriteLine();

Console.WriteLine("=== Part 3: Paycheck ===");
Console.Write("How many hours did you work this week? ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());
Console.Write("How much do you make per hour? ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

const double taxRate = 0.18;

double grossPay = hoursWorked * hourlyRate;
double taxWithheld = grossPay * taxRate;
double netPay = grossPay - taxWithheld;

Console.WriteLine();

Console.WriteLine("Gross pay:"+ " " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld:" + " " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay:" + " " + netPay.ToString("C"));

Console.WriteLine();

double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal / partyPeople;
double netPayPerHour = netPay / hoursWorked;
double hoursToCoverCost = costPerPerson / netPayPerHour;

Console.WriteLine("=== Part 4: The Whole Trip ===");
Console.WriteLine("Trip total:" + " " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person:" + " " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour:" + " " + netPayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share:" + " " + hoursToCoverCost.ToString("F2"));
