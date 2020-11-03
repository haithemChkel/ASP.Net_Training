namespace ConsoleApp1
{
    public class Vehicle
    {
        public string Brand { get; set; }
    }

    public class Auto : Vehicle
    {
        public int NombreDePlace { get; set; }
    }

    public class Moto : Vehicle
    {
        public int Cylindre { get; set; }
    }
}
