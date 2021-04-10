﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    class Ellipse<T> : IComparable<T>
    {
        private double D1;

        private double D2;

        public int SomeNumber { get; set; }

        public double D1_DataChecking
        {
            get
            {
                if (D1 <= 0)
                {
                    return -1;
                }
                return D1;
            }
            set
            {
                D1 = value;
                if (D1 <= 0)
                {
                    Console.WriteLine("Первая диагональ задана некорректно");
                }
            }
        }

        public double D2_DataChecking
        {
            get
            {
                if (D2 <= 0)
                {
                    return -1;
                }
                return D2;
            }
            set
            {
                D2 = value;
                if (D2 <= 0)
                {
                    Console.WriteLine("Вторая диагональ задана некорректно");
                }
            }
        }

        public Ellipse(double D1, double D2)
        {
            D1_DataChecking = D1;
            D2_DataChecking = D2;
            Random Rand = new Random();
            SomeNumber = Rand.Next(-100, 100);
            //Console.WriteLine(SomeNumber);
        }

        public double S_Ellipse
        {
            get
            {
                return Math.PI * D1 * D2 / 4;
            }
        }

        public double P_Ellipse
        {
            get
            {
                return 4 * (Math.PI * D1 * D2 + Math.Pow(D1 - D2, 2)) / (D1 + D2);
            }
        }

        public int CompareTo(T Obj)
        {
            if (Obj is Ellipse<T>)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}