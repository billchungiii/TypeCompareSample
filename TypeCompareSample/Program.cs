using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCompareSample
{
    class Program
    {
        static void Main(string[] args)
        {
            object rect = new Rect();
            Console.WriteLine($"rect is IShape : {rect is IShape}");
            Console.WriteLine($"rect is Shape : {rect is Shape}");
            Console.WriteLine($"rect is Rect : {rect is Rect}");
            Console.WriteLine($"rect is object : {rect is object}");

            object i = 10;
            Console.WriteLine($"i is int : {i is int }");
            Console.WriteLine($"i is int : {i is ValueType }");

           

            Console.WriteLine($"int type IsValueType : {typeof(int).IsValueType}");
            Console.WriteLine($"ValueType IsValueType : {typeof(ValueType).IsValueType}");

            Console.WriteLine($"DayOfWeek IsEnum : {typeof(DayOfWeek).IsEnum}");
            Console.WriteLine($"int type IsEnum : {typeof(int).IsEnum}");

            Console.WriteLine($"Func<T> IsClass : {typeof(Func<>).IsClass }");
            Console.WriteLine($"Shape IsClass :{typeof(Shape).IsClass}");
            Console.WriteLine($"Circle IsClass :{typeof(Circle).IsClass}");
            Console.WriteLine($"IShape IsClass :{typeof(IShape).IsClass}");

            Console.WriteLine($"Func<T> IsInterface : {typeof(Func<>).IsInterface }");
            Console.WriteLine($"Shape IsInterface :{typeof(Shape).IsInterface}");
            Console.WriteLine($"Circle IsInterface :{typeof(Circle).IsInterface}");
            Console.WriteLine($"IShape IsInterface :{typeof(IShape).IsInterface}");

            Console.WriteLine($"Func<T> IsGenericType : {typeof(Func<>).IsGenericType }");
            Console.WriteLine($"List<T> IsGenericType : {typeof(List<>).IsGenericType }");
            Console.WriteLine($"IComparable<T> IsGenericType : {typeof(IComparable<>).IsGenericType }");
            Console.WriteLine($"int[] IsGenericType : {typeof(int[]).IsGenericType }");


            Console.WriteLine($"IShape IsAssignableFrom Rect {typeof(IShape).IsAssignableFrom(typeof(Rect))}");
            Console.WriteLine($"Object IsAssignableFrom Rect {typeof(object).IsAssignableFrom(typeof(Rect))}");
            Console.WriteLine($"Rect IsAssignableFrom Shape {typeof(Rect).IsAssignableFrom(typeof(Shape))}");


            Console.WriteLine($"Rect IsInstanceOfType rect {typeof(Rect).IsInstanceOfType(rect)}");
            Console.WriteLine($"Shape IsInstanceOfType rect {typeof(Shape).IsInstanceOfType(rect)}");
            Console.WriteLine($"IShape IsInstanceOfType rect {typeof(Shape).IsInstanceOfType(rect)}");

            Console.WriteLine($"Rect IsSubclassOf Shape {typeof(Rect).IsSubclassOf(typeof(Shape))}");
            Console.WriteLine($"Rect IsSubclassOf IShape {typeof(Rect).IsSubclassOf(typeof(IShape))}");
            Console.WriteLine($"int IsSubclassOf ValueType {typeof(int).IsSubclassOf(typeof(ValueType))}");
            Console.WriteLine($"DayOfWeek IsSubclassOf Enum {typeof(DayOfWeek).IsSubclassOf(typeof(Enum))}");


            Console.ReadLine(); 
        }
    }

    public interface IShape
    {
        double GetArea();
    }

    public abstract class Shape : IShape
    {
        public string Name { get; set; }

        public abstract double GetArea();
    }

    public class Rect : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height; 
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

   

}
