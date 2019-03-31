using GreenHouseApp.Domain.Interfaces;

namespace GreenHouseApp.Domain
{
    public class GenericName : IName
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public GenericName() { }

        public GenericName(string name)
        {
            Name = name;
        }
    }
}
