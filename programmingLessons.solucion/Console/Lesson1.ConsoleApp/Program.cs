using System;

namespace Lesson1.ConsoleApp
{
    internal class Program
    {
        private static void ForExample(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"El numero de la impresiòn es{i}");
            }
            int K = 0;
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine($"El numero de la impresiòn es{K}");
                K++;
                if (K >= length)
                {
                    exit = true;
                }
            }
        }

        private static void Main()
        {
            Person person = new Person();
            person.Name = "Alejandro";
            person.Age = 56;
            person.Dni = 1000286721;
            person.Show();

            Account account = new Account(person);
            account.CashSum(1000);
            account.ShowAccountData();
            account.Cashres(500);
            account.ShowAccountData();
            account.CashSum(1000);
            account.ShowAccountData();

            YoungAccount young1 = new YoungAccount();
            young1.ShowAccountData();
        }

        private static void PrintCircleData(Circle circle1)
        {
            Console.WriteLine($"la figura es un {circle1.Name} tiene {circle1.Side},  al ser esta un {circle1.Name} encontramos que tiene un radio de {circle1.Radius} para asi calcular un area de {circle1.Area()}");
        }

        //print data de las figuras
        private static void PrintShapeData(Shape shape)
        {
            Console.WriteLine($"la figura es un {shape.Name} y tiene {shape.Side}");
        }

        private static void PrintSquareData(Square square1)
        {
            Console.WriteLine($"La figura es un {square1.Name} tiene {square1.Side} lados y posee un area de {square1.Area()} piñas cuadradas");
        }

        private static void PrintTriangleData(Triangle triaangle)
        {
            Console.WriteLine($"La figura es un {triaangle.Name}, tiene {triaangle.Side} lados con una base de {triaangle.Base} y una altura de {triaangle.Height} para dar asi una area de {triaangle.Area()} ");
        }

        private static void ShapeExercices()
        {
            // Shape shape1 = new Shape();
            //Console.WriteLine(shape1.Name);
            //Console.WriteLine(shape1.Side);
            //Console.WriteLine($"la figura es {shape1.Name} tiene {shape1.Side} lados, una base de {} ");

            //Shape triangle1 = new Triangle();
            //PrintShapeData(triangle1);

            Triangle triiangli = new Triangle();
            triiangli.Base = 4;
            triiangli.Height = 4;
            PrintTriangleData(triiangli);

            Circle circle1 = new Circle();
            circle1.Radius = 12;
            PrintCircleData(circle1);

            Square square1 = new Square();
            square1.Length = 4;
            PrintSquareData(square1);
        }

        //ha

        private static void VehicleExample(string[] args)
        {
            ForExample(3);
            Airplane airplane1 = new Airplane("Capa8");
            Console.WriteLine(airplane1.Started());
            Console.WriteLine(airplane1.Stopped());
        }
    }
}