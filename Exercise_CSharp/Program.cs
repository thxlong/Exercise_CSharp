using Exercise_CSharp.Actions;
using Exercise_CSharp.Exercises;
using System;
using System.Text;

namespace Exercise_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string i;
            Console.OutputEncoding = Encoding.UTF8;
            ActionEx action = new ActionEx();

            action.InDeBai();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("VUI LÒNG NHẬP LỰA CHỌN BÀI TOÁN: ");
            Program program = new Program();
            i = Console.ReadLine();
            program.LuaChonBaiGiai(i);
        }

        private void LuaChonBaiGiai(string i)
        {
            Excercises ex = new Excercises();
            switch (i)
            {
                case "A1":
                    ex.XuatRaManHinh();
                    break;

                case "A2":
                    ex.KhaiBaoBien();
                    break;

                case "C1":
                    ex.TimXYKhiBietTongHieu();
                    break;

                case "C2":
                    ex.BMI();
                    break;
                case "D1":
                    ex.XepLoaiHocTapBangToanTu3Ngoi();
                    break;

                default:
                    Console.WriteLine("Lựa chọn nhập không hợp lệ!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
