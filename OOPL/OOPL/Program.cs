using System;
namespace OOPL
{
    public class Program
    {
        class TCar
        {
            string marka;
            int year;
            public TCar()
            {
                marka = "None";
                year = 0;
            }
            public TCar(string marka, int year)
            {
                this.marka = marka;
                this.year = year;
            }
            public string Marka
            {
                get { return marka; }
                set { marka = value; }
            }
            public int Year
            {
                get { return year; }
                set {
                    if ((value > 2013) || (value < 1900))
                        throw new Exception();
                    else
                        year = value;
                }
            }
            public bool IsEqual(int yearr)
            {
                if (year == yearr)
                    return true;
                else return false;
            }
            public void WriteAboutCar()
            {
                Console.WriteLine("Marka={0} , year={1}", marka, year);
            }
        }
    }
}