using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_and_Hexadecimal_Transformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int bin_sayı = 0, dec_sayı = 0, hex_sayı = 0;
            string binary = "", decim = "", hexadecim = "";

            for (int i = 1; i < 257; i++)
            {
                Console.Write("10'luk Sayı Sistemi = " + i + " ");

                bin_sayı = i;
                dec_sayı = i;
                hex_sayı = i;

                while (bin_sayı != 0)
                {
                    binary = Convert.ToString(bin_sayı % 2) + binary;
                    bin_sayı /= 2;
                }

                Console.Write("2'lik Sayı Sistemi = " + binary + " ");

                binary = "";

                while (dec_sayı != 0)
                {
                    decim = Convert.ToString(dec_sayı % 8) + decim;
                    dec_sayı /= 8;
                }

                Console.Write("8'lik Sayı Sistemi = " + decim + " ");

                decim = "";

                while (hex_sayı != 0)
                {
                    if (hex_sayı % 16 == 10)
                    {
                        hexadecim = "A" + hexadecim;
                    }
                    if ((hex_sayı % 16 == 11))
                    {
                        hexadecim = "B" + hexadecim;
                    }
                    if ((hex_sayı % 16 == 12))
                    {
                        hexadecim = "C" + hexadecim;
                    }
                    if ((hex_sayı % 16 == 13))
                    {
                        hexadecim = "D" + hexadecim;
                    }
                    if ((hex_sayı % 16 == 14))
                    {
                        hexadecim = "E" + hexadecim;
                    }
                    if ((hex_sayı % 16 == 15))
                    {
                        hexadecim = "F" + hexadecim;
                    }
                    if ((hex_sayı % 16 > -1) && (hex_sayı % 16 < 10))
                    {
                        hexadecim = Convert.ToString(hex_sayı % 16) + hexadecim;
                    }

                    hex_sayı /= 16;
                }

                Console.Write("16'lık Sayı Sistemi = " + hexadecim + " ");

                hexadecim = "";

                Console.WriteLine();

            }





        }
    }
}
