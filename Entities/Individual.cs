using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_7.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }


        public Individual()
        {

        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (HealthExpenditures > 0)
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.50;
            }
            return AnualIncome * 0.25;
        }


        
    }


}