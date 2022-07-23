using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CSharp.Exercises
{
    public class Excercises
    {
        public void XuatRaManHinh()
        {
            string hoTen, gioiTinh;
            int namSinh, tuoi;

            Console.Write("Vui lòng nhập họ và tên: ");
            hoTen = Console.ReadLine();

            Console.Write("Vui lòng nhập giới tinh: ");
            gioiTinh = Console.ReadLine();

            Console.Write("Vui lòng nhập năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());

            Console.WriteLine("Tên của bạn là {0}, giới tính {1}, năm sinh: {2} ", hoTen, namSinh, gioiTinh);
            Console.ReadLine();
        }

        public void BMI()
        {
            float height, weight, BMI;
            Console.Write("Vui lòng nhập chiều cao của bạn (m): ");
            height = float.Parse(Console.ReadLine());

            Console.Write("Vui lòng nhập cân nặng của bạn (kg): ");
            weight = float.Parse(Console.ReadLine());
            BMI = (float)(weight / (Math.Pow(height, 2))); // BMI = Can Nang/(ChieuCao ^ 2)

            Console.WriteLine("Chỉ số BMI của bạn là: " + BMI);

            if (BMI < 15)
                Console.WriteLine("Thân hình quá gầy");
            else if (BMI >= 15 && BMI < 16)
                Console.WriteLine("Thân hình gầy");
            else if (BMI >= 16 && BMI < 18.5)
                Console.WriteLine("Thân hình hơi gầy");
            else if (BMI >= 18.5 && BMI < 25)
                Console.WriteLine("Thân hình bình thường");
            else if (BMI >= 25 && BMI < 30)
                Console.WriteLine("Thân hình hơi béo");
            else if (BMI >= 30 && BMI < 35)
                Console.WriteLine("Thân hình béo");
            else
                Console.WriteLine("Thân hình quá béo");
            Console.ReadKey();
        }

        public void KhaiBaoBien()
        {
            string hoTen;
            float toan, van;

            Console.Write("Vui lòng nhập họ và tên: ");
            hoTen = Console.ReadLine();

            Console.Write("Vui lòng nhập điểm toán: ");
            toan = float.Parse(Console.ReadLine());

            Console.Write("Vui lòng nhập điểm văn: ");
            van = float.Parse(Console.ReadLine());

            Console.WriteLine("Tên của bạn là {0}, có điểm toán = {1} và điểm văn = {2} ", hoTen, toan, van);
            Console.ReadLine();
        }

        public void TimXYKhiBietTongHieu()
        {
            float x, y, tong, hieu;
            Console.Write("Nhập Tổng của 2 số = ");
            tong = float.Parse(Console.ReadLine());

            Console.Write("Nhập Hiệu của 2 số = ");
            hieu = float.Parse(Console.ReadLine());
            x = (hieu + tong) / 2;
            y = (tong - hieu) / 2;

            Console.WriteLine("Giá trị x cần tìm là: " + x);
            Console.WriteLine("Giá trị y cần tìm là: " + y);
            Console.ReadLine();
        }

        public void XepLoaiHocTapBangToanTu3Ngoi()
        {
            double diemTrungBinh;
            Console.Write("Mời nhập vào điểm trung bình: ");
            diemTrungBinh = double.Parse(Console.ReadLine());

            string kq = 
                (diemTrungBinh >= 8) ? "Giỏi" : 
                ((diemTrungBinh < 8 && diemTrungBinh >= 6.5) ? "Khá" : 
                ((diemTrungBinh > 5)) ? "Trung binh" : "Yếu");

            Console.Write("Điểm trung bình của bạn là {0}, bạn xếp loại {1}", diemTrungBinh, kq);
            Console.ReadKey();
        }
    }
}
