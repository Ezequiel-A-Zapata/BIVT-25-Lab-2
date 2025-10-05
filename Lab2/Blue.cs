using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here

            double exp = 1.0; 
            for (int i = 1; i <= n; i++)
            {
                double top = Math.Sin(i * x);
                answer += top / exp;   
                exp *= x;              
            }

            // end

                return answer;
        }
        public double Task2(int n)
        {
            double answer = 0.0;

            double pow = 1.0; // 5^0
            int fact = 1;     // 0!
            int sign = -1;    // (-1)^1

            for (int i = 1; i <= n; i++)
            {
                pow *= 5.0;        // 5^i
                fact *= i;         // i!
                answer += sign * (pow / fact);
                sign *= -1;        // alternar signo
            }

            return answer;
        }

        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n <= 0)
            {
                answer = 0;
            }
            else
            {
                long sum = 0;
                long a = 0;
                long b = 1;

                for (int i = 0; i < n; i++)
                {
                    sum += a;
                    long next = a + b;
                    a = b;
                    b = next;
                }

                answer = sum;
            }
            // end

                return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            int num = 0;
            for (int i = 1; s < L; i++)
            {
                int sequence = a + (i - 1) * h;
                s += sequence;
                num ++;
            }
            answer = num;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0.0;
            // code here
            double ch = 0.0, zn = 1.0;
            double elem = ch / zn;  // 0 al inicio
            int i = 1;

            do
            {
                ch += i;        
                zn *= x;        
                answer += elem; 
                elem = ch / zn; 
                i++;           
            }
            while (elem > 0.0001);
            // end

            return answer;
        }

        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            if (S >= L)
            {
                return answer;
            }
            else
            {
                int initialQuantity = S;
                int time = 0;
                while (initialQuantity < L)
                {
                    initialQuantity *= 2;
                    time += h;
                }
                answer = time;
            }

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double KM = S;
            for (int i = 1; i <= 7; i++)
            {
                KM += KM + (I / 100);
            }
            a = KM;
            double limitKM = 100;
            double initialKm = S;
            int days = 1;
            for (; initialKm < limitKM; days++)
            {
                initialKm += S + (I / 100);
            }
            b = days;
            double km = S;
            int days2 = 1;
            for (; km < 42; days2++)
            {
                km = km + (I / 100);
            }
            c = days2;
                // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
                // double x = a;
                // double result;
                // int i = 1;
                // double exp = x;
                // for (; a < b; a += h)
                // {
                // result = (2 * i + 1) * x;
                //     i++;
                //     x = a;
                // }
            // end

                return (SS, SY);
        }
    }
}





