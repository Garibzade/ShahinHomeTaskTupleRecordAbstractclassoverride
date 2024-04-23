using Abstract_class__Virtual__Override.Calculate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override.Calculate
{
    
        internal class Calculate : Iadd, Idifference, Idivide, imultiply
        {
            public float Add(float num1, float num2) => (num1 + num2);
            public float Difference(float num1, float num2) => (num1 - num2);
            public float Divide(float num1, float num2) => (num1 / num2);
            public float Multiply(float num1, float num2) => (num1 * num2);
        }
}
