using Practice_Exam.Exam1;
using Practice_Exam.Exam2;

namespace Practice_Exam
{
    internal class Run
    {
        static void Main1(string[] args) // Ex1
        {
            Cylinder c1 = new Cylinder(38.64, 22.48);
            c1.Process();
            c1.Result();
        }
        static void Main(string[] args) // Ex2:
        {
            Lion l1 = new Lion(100, "Lion");
            l1.Show();
            Tiger t1 = new Tiger(200, "Tiger");
            t1.Show();
        }
    }
}
