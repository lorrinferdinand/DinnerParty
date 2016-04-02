using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    public class DinnerParty
    {
        private int NumberofPeople;
        decimal CostOfBeveragesPerPerson;
        decimal CostOfDecorations;
        public bool HealthyOption;
        public const int CostOfFoodPerPerson = 25;

        public bool SetHealthyOption(bool Healthy)
        {
            HealthyOption = Healthy;
            return HealthyOption;
        }

        public void SetPartyOptions(int people, bool fancy)
        {
            NumberofPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        {
            return NumberofPeople;
        }

        public decimal CalculateCostOfDecorations(bool Fancy)
        {
            if (Fancy)
            {
                CostOfDecorations = 50.0M + (decimal)(NumberofPeople * 15.0M);

            }
            else
            {
                CostOfDecorations = 30.0M + (decimal)(NumberofPeople * 7.5M);
            }

            return CostOfDecorations;
        }

        public decimal CalculateCost(bool HealthyOption)
        {
            decimal TotalCost;


            if (HealthyOption)
            {
                CostOfBeveragesPerPerson = 5.0M;
                TotalCost = ((GetNumberOfPeople() * CostOfBeveragesPerPerson) + CostOfDecorations + (GetNumberOfPeople() * CostOfFoodPerPerson)) * .95M;

            }
            else {

                CostOfBeveragesPerPerson = 20.0M;
                TotalCost = ((GetNumberOfPeople() * CostOfBeveragesPerPerson) + CostOfDecorations + (GetNumberOfPeople() * CostOfFoodPerPerson));
            }
            return TotalCost;
        }

    }
}
