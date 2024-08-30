using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

public class Training
{
    static void Main()
    {
        Console.WriteLine("Test second commit");
        Car car = new Car();
        car.color = "new_red";
        Console.WriteLine(car.color);

        Form myform = new Form();
    }
}

