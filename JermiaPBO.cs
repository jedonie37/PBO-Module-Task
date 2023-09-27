using System;

class Laptop
{
    public string Merk { get; }
    public string Tipe { get; }
    public Vga Vga { get; set; }
    public Processor Processor { get; set; }

    public Laptop(string merk, string tipe)
    {
        Merk = merk;
        Tipe = tipe;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}




class Asus : Laptop
{
    public Asus(string tipe) : base("Asus", tipe)
    {
    }
}

class Acer : Laptop
{
    public Acer(string tipe) : base("Acer", tipe)
    {
    }
}

class Lenovo : Laptop
{
    public Lenovo(string tipe) : base("Lenovo", tipe)
    {
    }
}

class ROG : Asus
{
    public ROG() : base("ROG")
    {
    }
}

class Vivobook : Asus
{
    public Vivobook() : base("Vivobook")
    {
    }
}

class Swift : Acer
{
    public Swift() : base("Swift")
    {
    }
}

class Predator : Acer
{
    public Predator() : base("Predator")
    {
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad() : base("IdeaPad")
    {
    }
}

class Legion : Lenovo
{
    public Legion() : base("Legion")
    {
    }
}

class Vga
{
    public string Merk { get; }
    public string Tipe { get; }

    public Vga(string merk, string tipe)
    {
        Merk = merk;
        Tipe = tipe;
    }
}

class AMD : Vga
{
    public AMD(string tipe) : base("AMD", tipe)
    {
    }
}

class Nvidia : Vga
{
    public Nvidia(string tipe) : base("Nvidia", tipe)
    {
    }
}

class Processor
{
    public string Merk { get; }
    public string Tipe { get; }

    public Processor(string merk, string tipe)
    {
        Merk = merk;
        Tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe)
    {
    }
}

class AMDProcessor : Processor
{
    public AMDProcessor(string tipe) : base("AMD", tipe)
    {
    }
}

class Corei3 : Intel
{
    public Corei3() : base("Core i3")
    {
    }
}

class Corei5 : Intel
{
    public Corei5() : base("Core i5")
    {
    }
}

class Corei7 : Intel
{
    public Corei7() : base("Core i7")
    {
    }
}

class Ryzen : AMDProcessor
{
    public Ryzen() : base("Ryzen")
    {
    }
}

class Athlon : AMDProcessor
{
    public Athlon() : base("Athlon")
    {
    }
}


class Program
{
    static void Main()
    {
        Laptop laptop1 = new Vivobook();
        laptop1.Vga = new Nvidia("VGA Nvidia");
        laptop1.Processor = new Corei5();

        laptop1.Ngoding();

        Console.WriteLine($"Merk VGA: {laptop1.Vga.Merk}");
        Console.WriteLine($"Merk Processor: {laptop1.Processor.Merk}");
        Console.WriteLine($"Tipe Processor: {laptop1.Processor.Tipe}");

        Laptop laptop2 = new IdeaPad();
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Predator predator = new Predator();
        predator.BermainGame();

    }
}
