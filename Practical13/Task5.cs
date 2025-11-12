using System;

namespace Pract13
{
    class Animal
    {
        public string Specie { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public int Age { get; set; }
        public Animal(string specie, string habitat, string diet, int age)
        {
            Specie = specie;
            Habitat = habitat;
            Diet = diet;
            Age = age;
        }
    }
    class Mammal : Animal
    {
        public string TypeOfFur { get; set; }
        public int DurationOfPregnancy { get; set; }
        public Mammal(string specie, string habitat, string diet, int age, string fur, int pregnancy) : base (specie, habitat, diet, age)
        {
            Specie = specie;
            Habitat = habitat;
            Diet = diet;
            Age = age;
            TypeOfFur = fur;
            DurationOfPregnancy = pregnancy;
        }
    }
    class Bird : Animal
    {
        public int Wingspan{ get; set; }
        public string TypeOfNesting { get; set; }
        public Bird(string specie, string habitat, string diet, int age, string nesting, int wingsnap) : base(specie, habitat, diet, age)
        {
            Specie = specie;
            Habitat = habitat;
            Diet = diet;
            Age = age;
            Wingspan = wingsnap;
            TypeOfNesting = nesting;
        }
    }
    class Reptile : Animal
    {
        public string TypeOfSkin { get; set; }
        public int TemperatureOfHabitat { get; set; }
        public Reptile(string specie, string habitat, string diet, int age, string skin, int temp) : base(specie, habitat, diet, age)
        {
            Specie = specie;
            Habitat = habitat;
            Diet = diet;
            Age = age;
            TypeOfSkin = skin;
            TemperatureOfHabitat = temp;
        }
    }
    class Fish : Animal
    {
        public string TypeOfScales { get; set; }
        public int HabibatDepth { get; set; }
        public Fish(string specie, string habitat, string diet, int age, string scales, int habibatDepth) : base(specie, habitat, diet, age)
        {
            Specie = specie;
            Habitat = habitat;
            Diet = diet;
            Age = age;
            TypeOfScales = scales;
            HabibatDepth = habibatDepth;
        }
    }
}