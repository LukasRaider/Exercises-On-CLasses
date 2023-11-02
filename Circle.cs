using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle; 
    public class Circle
    {
        private double radius;
        private String color;

        public Circle() {

            radius = 1.0;
            color = "red";
        }
        public Circle(double r) {
            this.radius = r;
            color = "red";
        }
        public Circle(double r,string col)
        {
            radius = r;
            color = col;
        }
        public void setRadius(double newRadius) { 
            this.radius = newRadius;
        }
        public void setColor(string newColor) {
            this.color = newColor;
        }
        public double GetRadius()
        {
            return radius;  
        }
        public string GetColor()
        {
            return color;
        }
        public double getArea() { 
            return radius * radius * Math.PI;
        }
        public String toString() {
            return ($"Kruh[radius= {radius}, barva = {color}]");
        }
    }
    public class TestCircle {
        public static void Mainx()
        {
            Circle c1 = new Circle(5.0);
            Console.WriteLine(c1.toString());
            //Console.WriteLine($"Radius kruhu {c1.GetRadius} a jeho obsah {c1.getArea}");
            Circle c2 = new Circle(1.2);
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c2);
            Console.WriteLine($"Operator predela na retezec taky: {c2}");
            //Console.WriteLine($"Radius kruhu {c2.GetRadius} a jeho obsah {c2.getArea}");
            Circle c3 = new Circle(3.0,"black");
            Console.WriteLine($"Radius kruhu {c3.GetRadius()} , barva {c3.GetColor()} a jeho obsah {c3.getArea()}");
            Circle c4 = new Circle();
            c4.setRadius(5.0);
            Console.WriteLine($"Radius je {c4.GetRadius()}");
            c4.setColor("blue");
            Console.WriteLine($"Barva je {c4.GetColor()}");
            
        }
    }
    

