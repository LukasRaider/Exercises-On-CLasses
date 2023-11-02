using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle;

    public class Rectangle
    {
        private float lenght;
        private float width;

        public Rectangle(){
            lenght = 1.0f;
            width = 1.0f;
        }
        public Rectangle(float lengh,float widt) { 
            lenght=lengh;
            width = widt;   
        }
        public float getLength()
        { 
            return lenght;
        }
        public void setLength(float lengh)
        {
            this.lenght = lengh;
        }
        public float getWidth()
        {
            return width;
        }
        public void setWidth(float width)
        {
            this.width = width;
        }
        public double getArea() {
            return lenght * width;
        }
        public double getParimeter() {
            return 2 * (lenght + width);
        }
        public String toString() {
            return($"Obdelnik[delka= {lenght}, sirka= {width}]");
        }
    }
    public class TestRectangle {
        public static void Mainx()
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine(r1.toString());
            Rectangle r2 = new Rectangle(8,6);
            Console.WriteLine(r2.toString());
            Rectangle r3 = new Rectangle();
            Console.WriteLine( $"Delka obdelniku {r3.getLength()} a sirka {r3.getWidth()}");
            Console.WriteLine($"Obsah obdelniku je {r3.getArea()} a jeho obvod je {r3.getParimeter()}");
            Rectangle r4 = new Rectangle();
            r4.setLength(6);
            Console.WriteLine($"Delka obdelniku je {r4.getLength()}");
            r4.setWidth(4);
            Console.WriteLine($"Sirka obdelniku je {r4.getWidth()}");

        }
    }

