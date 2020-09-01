using System;

namespace GOGOGO
{
    class Program
    {
        static void Main(string[] args)
        {

            CAR car1 = new CAR(350f, 100f, 50f, 10f);
            CAR car2 = new CAR(350f, 50f, 20f, 5f);

            Console.WriteLine("Are you ready");
            for (int i = 3; i > 0; i--)
            {

                Console.WriteLine(i);
            }
            Console.WriteLine("Start");

            car1.Run(0);
            Console.WriteLine("Car1Position" + " " + car1.Position + "(m)");
            car2.Run(0);
            Console.WriteLine("Car2Position" + " " + car2.Position + "(m)");



            Console.WriteLine("Car1" + " " + car1.HP);
            Console.WriteLine("Car2" + " " + car2.HP);

            Console.WriteLine("---衝突---");
            car1.Attack(car2);
            car2.Attack(car1);

            Console.WriteLine("Car1" + " " + car1.HP);
            Console.WriteLine("Car2" + " " + car2.HP);


            if (car1.HP == car2.HP)
            {
                Console.WriteLine("ゴールまで同時に来ます");
            }

            else if (car1.HP > car2.HP)
            {
                Console.WriteLine("Car2よりCar1は早くゴールまで");

            }
            else if (car1.HP < car2.HP)
            {
                Console.WriteLine("Car1よりCar2は早くゴールまで");
            }


        }
    }
}
