using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void kabarcikSirala(int[] siralanacakDizi)
        {

            int i = 1, j, deger;
            int diziAdet = siralanacakDizi.Length;
            while (i < diziAdet)
            {
                j = diziAdet - 1;
                while (j >= 1)
                {
                    if (siralanacakDizi[j - 1] > siralanacakDizi[j])
                    {
                        deger = siralanacakDizi[j];
                        siralanacakDizi[j] = siralanacakDizi[j - 1];
                        siralanacakDizi[j - 1] = deger;
                    }
                    j--;
                }
                i++;
            }
        }
        static int func(int i)
        {
            if (i % 2 == 0) return 0;
            else return 1;
        }
        static decimal divide(int p1,int p2)
        {
            int c = -1;
         
            try
            {
                c = p1 / p2;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

            }
            finally
            {
                Console.WriteLine("finallt");
            }
            return c;


        }
        static int index(List<int> list,int x)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]==x)
                {
                    return i;
                }
            }
            return -1;
        }
        static int maxval(List<int> enu)
        {
            int count = enu.Count;
            int max;
            int maxvalue;
            int temp;
            int res=0;
            for (int i =count-1; i >= 0; i--)
            {
                max = enu[i];

                for (int j = 0; j < i; j++)
                {
                    temp = enu[i] - enu[j];
                    if (temp > res)
                    {
                        res = temp;
                    }                              

                }

            }
            
            return res;
    



        }
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 7,2,3,10,2,4,8,1 };
            Console.WriteLine(maxval(list));

            //int i = 4;
            //i = func(i);
            //i = func(i);
            //Console.WriteLine(i);
            ////Console.WriteLine(divide(4,0));
            Console.ReadKey();
        }
    }
}
