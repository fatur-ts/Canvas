using System;
using System.Collections.Generic;

namespace Canvas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var canvas = new Canvas();
            canvas.AddShape(new Lingkaran());
            canvas.AddShape(new Kotak());
            canvas.AddShape(new Segitiga());
            canvas.AddShape(new SegiEnam());
            canvas.Draw();


            Console.ReadLine();
        }
    }

    class Canvas
    {
       
        private IList<Shape> shapes=new List<Shape>();

        internal void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        internal void Draw()
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }

    abstract class Shape
    {
        protected abstract string GetBentuk();
        internal void Draw()
        {
            Console.WriteLine($"{GetBentuk()}");
        }
    }

    class Lingkaran : Shape
    {
        protected override string GetBentuk()
        {
            return "Lingkaran";
        }
    }
    class Segitiga : Shape
    {
        protected override string GetBentuk()
        {
            return "Segitiga";
        }
    }
    class Kotak : Shape
    {
        protected override string GetBentuk()
        {

            return "Kotak";
        }
    }
    class SegiEnam : Shape
    {
        protected override string GetBentuk()
        {
            return "Segienam";
        }
    }
}
