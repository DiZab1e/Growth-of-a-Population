using System;

class Arge
{

    public static int NbYear(int p0, double percent, int aug, int p)
    {
        double per = percent / 100;
        int year = 0;

        while (true)
        {
            p0 += (int)(p0 * per) + aug;
            year++;

            if (p0 >= p)
            {
                return year;
            }
        }
        return year;
    }
}