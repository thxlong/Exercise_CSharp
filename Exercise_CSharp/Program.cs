using Exercise_CSharp.Actions;
using Exercise_CSharp.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.OutputEncoding = Encoding.UTF8;
            ActionEx action = new ActionEx();
            Excercises ex = new Excercises();

            action.InDeBai();
            Console.Write("Vui lòng nhập số từ bàn phím: ");
            i = int.Parse(Console.ReadLine());
            while (i < 0 || i > 10)
            {
                Console.Write("Số nhập không hợp lệ, vui lòng nhập lại: ");
                i = int.Parse(Console.ReadLine());
            }
            switch (i)
            {
                case 1:
                    ex.XuatRaManHinh();
                    break;

                case 2:
                    ex.KhaiBaoBien();
                    break;

                case 4:
                    ex.TimXYKhiBietTongHieu();
                    break;

                case 5:
                    ex.BMI();
                    break;
                case 10:
                    ex.XepLoaiHocTapBangToanTu3Ngoi();
                    break;

                default:
                    Console.WriteLine("Ko hợp lệ!");
                    break;
            }
        }
    }
}
