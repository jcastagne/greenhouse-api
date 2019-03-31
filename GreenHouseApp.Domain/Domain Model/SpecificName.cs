using GreenHouseApp.Domain.Interfaces;

namespace GreenHouseApp.Domain
{
    public class SpecificName : IName
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public SpecificName(){ }

        public SpecificName(string name)
        {
            Name = name;
        }
    }
}
