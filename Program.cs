using System; //Виталий Войтов

namespace homework_C_sharp_3._1 //Дописать структуру Complex, добавив метод вычитания комплексных чисел

{
    struct Complex
    {
        public double re;
        public double im;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public void Print()
        {
            Console.WriteLine($"{re} + {im}i");
        }
    }


    class Program
    {
        static Complex Sum(Complex q, Complex w)
        {
            Complex result = new Complex();
            result.re = q.re + w.re;
            result.im = q.im + w.im;
            return result;
            
        }

        static Complex Diff(Complex t, Complex y)
        {
            Complex difference = new Complex();
            difference.re = t.re - y.re;
            difference.im = t.im - y.im;
            return difference;
        }



        static void Main(string[] args)
        {
            Complex z1 = new Complex(re: 123, im: 23);
           
            Complex z2 = new Complex(re: 142, im: 15);
            Complex z3 = Sum(z1, z2);
            Complex z4 = Diff(z1, z2);
            
          
            z1.Print();
            z2.Print();
            z3.Print();
            z4.Print();
        }
    }
}
