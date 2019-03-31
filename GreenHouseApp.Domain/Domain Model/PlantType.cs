using GreenHouseApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenHouseApp.Domain
{
    public class PlantType : IName
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public PlantType() { }

        public PlantType(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
