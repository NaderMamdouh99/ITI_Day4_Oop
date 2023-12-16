using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AnswerDay6
{
    internal class Complex
    {
        private int _real;
        private int _imaginary;

        public Complex(int real, int imagaginary)
        {
            _real = real;
            _imaginary = imagaginary;
        }
        public Complex():this(1,1)
        {
            
        }
        //public Complex(int real, int imagaginary) : this(real, imagaginary)
        //{


        //}

        #region Property


        public int Real
        {
            get { return _real; }
            set { _real = value; }
        }

        public int Imaginary
        {
            get { return _imaginary; }
            set { _imaginary = value; }
        }

        #endregion

        #region Method
        public double GetMagnitude()
        {
            
           return Math.Sqrt(Math.BigMul(Math.Abs(_real), Math.Abs(_imaginary)));
        }

        public static bool operator >=  (Complex c1,Complex c2)
        {
            return c1.Real >= c2.Real && c1.Imaginary >= c2.Imaginary;
        }
        public static bool operator  <=  (Complex c1,Complex c2)
        {
            return c1.Real <= c2.Real && c1.Imaginary <= c2.Imaginary;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
             
            return new Complex(c1._real + c2._real, c1.Imaginary + c2.Imaginary);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
             
            return new Complex(c1._real - c2._real, c1.Imaginary - c2.Imaginary);
        }
        public static Complex operator ++(Complex c1)
        {
             
            return new Complex(c1._real + 1, c1.Imaginary+1);
        }
        public static Complex operator --(Complex c1)
        {
             
            return new Complex(c1._real -1, c1.Imaginary-1);
        }
        public override string ToString()
        {
            return  ""+_real +"+"+Imaginary+"i";
        }

        //casting 
        
        public static implicit operator Complex(int value)
        {
            
            return new Complex(value,200);
        }

        public static explicit operator int(Complex c)
        {
            return c.Real;
        }

        //equals
        public override bool Equals(object obj)
        {
            Complex c = (Complex)obj;
             return c._real == this._real && c._imaginary == this._imaginary;
        }

        #endregion


    }
}
