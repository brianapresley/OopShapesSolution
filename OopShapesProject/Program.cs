using System;

namespace OopShapesProject {
    class Program {
        static void Main(string[] args) {

            var sqrcomp = new SquareComp(5);
            var p = sqrcomp.GetPerimeter();
            var a = sqrcomp.GetArea();
            Console.WriteLine($"The SqrComp perimeter is {p} and the area is {a}");

            var quad1 = new Quad(5, 7, 13, 6);
            var perimeter = quad1.GetPerimeter();
            Console.WriteLine($"The quad perimeter is {perimeter}");

            var rect1 = new Rectangle(5, 13);
            var area = rect1.GetArea();
            perimeter = rect1.GetPerimeter();
            area = rect1.GetArea();

            Console.WriteLine($"The rectangle perimeter is {perimeter} and the area is {area}");

            var square1 = new Square(12);
            perimeter = square1.GetPerimeter();
            area = square1.GetArea();

            Console.WriteLine($"The square perimeter is {perimeter} and the area is {area}");



        }
    }
}
