using System;


namespace GreenHouseApp.Domain
{
    public class Plant
    {
        public int Id { get; private set; }

        public PlantType Type { get; private set; }

        /* Binomial Name */
        public GenericName GenericName { get; private set; }
        public SpecificName SpecificName { get; private set; }
        
        /* Common Name */
        public string CommonName { get; private set; }
        
        /* Flourishing Period */
        public DateTime FlourishStart { get; private set; }
        public DateTime FlourishEnd { get; private set; }

        /* Flower color */
        public Color Color { get; private set; }
        public long AverageHeight { get; private set; }
        public bool Evergreen { get; private set; }

        public Plant() { }

        public Plant(PlantType type, GenericName genericName, SpecificName specificName, string commonName,
                     DateTime flourishStart, DateTime flourishEnd, Color color, long averageHeight, bool evergreen)
        {
            Type = type;
            GenericName = genericName;
            SpecificName = specificName;
            CommonName = commonName;
            FlourishStart = flourishStart;
            FlourishEnd = flourishEnd;
            Color = color;
            AverageHeight = averageHeight;
            Evergreen = evergreen;
        }
    }
}
