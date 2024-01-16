

using System.Globalization;
using exercicio_7.Entities;

List <TaxPayer> taxPayers = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for(int count = 1; count <= n; count++)
{
    Console.WriteLine($"Tax payer #{count} data:");

    Console.Write("Individual or company (i/c)? ");
    char individualOrCompany = char.Parse(Console.ReadLine());
    
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(individualOrCompany == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
    }


    

    
}


double sum = 0.0;

Console.WriteLine("\nTAXES PAID: ");
foreach(TaxPayer payer in taxPayers)
{
    Console.WriteLine(payer);
    sum += payer.Tax();
}


Console.Write($"\nTOTAL TAXES: {sum:C}");