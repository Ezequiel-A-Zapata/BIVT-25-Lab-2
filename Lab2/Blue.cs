using System.Collections.Generic;
using System.ComponentModel;
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
            double answer = 0;

            // code here
            int num = 5;
            int fact = 0;
            for (int i = 1; i <= n; i++)
            {
                num *= 5;
                fact += i;
            }
            answer = num / fact;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            int sum = 0;
            int firstnum = 1;
            int secondnum = 0;
            if (n == 0)
            {
                answer = 0;
            }
            else if (n == 1)
            {
                answer = 1;
            }
            else 
            {
                for (int i = 2; i <= n; i++)
                {
                    int fibonacci = firstnum + secondnum;
                    secondnum = firstnum;
                    firstnum = fibonacci;
                    sum += fibonacci;
                }
            }
            answer = sum;
            // end

                return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            for (int i = 1; i <= L; i++)
            {
                int sequence = a + (i - 1) * h;
                s += sequence;
            }
            answer = s;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;


            // code here

            double ch = 0, zn = 1;
            double elem;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                elem = ch / zn;
                answer += elem;
                i++;
            } while (elem > 0.0001);

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
                int time = h;
                while (initialQuantity <= L)
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
            for (; km > 42; days2++)
            {
                km = km + (I / 100);
            }
            c = days;
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
