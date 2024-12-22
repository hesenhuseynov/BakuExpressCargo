namespace BakuExpressCargo.Domain.Entities
{
    public class PackageSize
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public decimal Depth { get; set; }

        public decimal MaxWeight { get; set; }


        public PackageSize( decimal width ,decimal height ,decimal depth ,decimal maxWeight)
        {
            if (width<=0||height<=0||depth<=0||maxWeight<=0)
            {
                throw new ArgumentException("Dimensions and weight must be positive ");
                
                
            }


             

            Width = width;
            Height = height;
            Depth = depth;
            MaxWeight = maxWeight;  

           
        }

        public decimal Volume => Width * Height * Depth;

    }
}
