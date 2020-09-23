using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovCompare
{
    class Program
    {
    	public class Triangle:IComparable<Triangle>
        {
            public double a;
            public double b;
            public double c;
            public double p;
            public double s{ get; set; }
            public Triangle(double A, double B, double C)
            {
                a = A;
                b=B;
                c=C;
                p=A+B+C;
                s=Math.Sqrt((A+B+C)/2*((A+B+C)/2-A)*((A+B+C)/2-B)*((A+B+C)/2-C));
            }
            public int CompareTo(Triangle T)
            {
            	return this.s.CompareTo(T.s);
            }
           
            
        }
        static void Main(string[] args)
        {
        	Random rand = new Random();
        	Triangle[] mas = new Triangle[10];
        	for(int i=0;i<mas.Length;i++)
        	{
        		int a =10;
        		int b =rand.Next(6,15);
        		int c= rand.Next(7,10);
        		mas[i]= new Triangle(a,b,c);
        	}
        	Console.WriteLine("Base array");
        	foreach (Triangle t in mas) Console.WriteLine(t.s);
        	Console.WriteLine(" ");
        	Array.Sort(mas);
        	Array.Reverse(mas);
        	Console.WriteLine("Sorted array");
        	foreach (Triangle t in mas) Console.WriteLine(t.s);
        	Console.ReadKey(true);
        }
    }
}
