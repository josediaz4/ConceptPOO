namespace ConceptPOO
{
    public class CommisionEmployee : Employee
    {
        public float CommisionPercentaje { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommisionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommision Percentaje: {$"{CommisionPercentaje:P2}",18}" +
                $"\n\tSales...............: {$"{Sales:C2}",18}" +
                $"\n\tValue to Pay........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
