using System;

namespace Practice_Exam.Exam2;
class Animal
{
    protected double weight;
    protected string name;

    public void SetMe(double weight, string name)
    {
        this.weight = weight;
        this.name = name;
    }

    public virtual void Show()
    {
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Name: " + name);
    }
}

class Lion : Animal
{
    public Lion(double weight, string name)
    {
        SetMe(weight, name);
    }

    public override void Show()
    {
        Console.WriteLine("Lion Information");
        base.Show();
    }
}

class Tiger : Animal
{
    public Tiger(double weight, string name)
    {
        SetMe(weight, name);
    }

    public override void Show()
    {
        Console.WriteLine("Tiger Information");
        base.Show();
    }
}


