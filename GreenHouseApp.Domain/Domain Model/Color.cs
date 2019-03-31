using GreenHouseApp.Domain.Interfaces;

namespace GreenHouseApp.Domain
{
    public class Color : IName
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Color() { }

        public Color(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
