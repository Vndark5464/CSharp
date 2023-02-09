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
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Weight: " + weight);
        
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
        base.Show();
    }
}


