using System;
using System.Collections.Generic;
using System.Text;

namespace Entities {
    class Calculator {
        public double Width { get; set; }
        public double Height { get; set; }
        public Calculator() {
        }
        public Calculator(double width, double height) {
            Width = width;
            Height = height;
        }
        public double Area() {
            return Width * Height;
        }

        public double Perimeter() {
            return (2 * Width) + (2 * Height);
        }

        public double Diagonal() {
            return Math.Sqrt(Width*Width + Height*Height);
        }
        public override string ToString() {
            return "Area do retângulo: " + Area() + "\nPerimetro do retângulo: " + Perimeter() + "\nDiagonal do retângulo: " +Diagonal().ToString("F2");
        }
    }
}
