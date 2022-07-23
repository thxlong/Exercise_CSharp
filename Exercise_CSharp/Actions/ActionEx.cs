using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CSharp.Actions
{
    public class ActionEx
    {
        public void InDeBai()
        {
            DeBai1();
            DeBai2();
            Debai4();
            Debai5();
            Debai10();
        }

        public void DeBai1()
        {
            string debai = string.Format("Bài 1: Viết khởi tạo, log ra giá trị \n Viết chương trình xuất ra màn hình các dòng sau: \n 1. Họ và tên \n 2. Năm sinh \n 3. Giới tính \n 4. Tuổi");
            Console.WriteLine(debai);
            Console.WriteLine("---------------------------");
        }

        public void DeBai2()
        {
            string debai2 = string.Format("Bài 2: Viết chương trình khai báo các biến sau: \n 1.hoTen \n 2.diemToan \n 3.dienVan \n Cho người dùng nhập vào họ tên, điểm Toán, điểm Văn \n Xuất ra màn hình: học sinh có điểm toán là 9.5, điểm Văn là 8.0(sử dụng float)");
            Console.WriteLine(debai2);
            Console.WriteLine("---------------------------");
        }

        public void Debai4()
        {
            string debai4 = string.Format("Bài 4: Tìm x, y khi biết tổng và hiệu của chúng");
            Console.WriteLine(debai4);
            Console.WriteLine("---------------------------");
        }

        public void Debai5()
        {
            string debai5 = string.Format("Bài 5: Viết chương trình nhập vào chiều cao, cân nặng, tính BMI và xuất ra thông báo \n BMI<15: Thân hình quá gầy \n BMI>=15 and BMI<16: Thân hình gầy \n BMI>=16 and BMI<18.5: Thân hình hơi gầy \n BMI>=18.5 and BMI<25:Thân hình bình thường \n BMI>=25 and BMI < 30:Thân hình hơi béo \n BMI >=30 and BMI<35:Thân hình béo \n BMI >=35:Thân hình quá béo");
            Console.WriteLine(debai5);
            Console.WriteLine("---------------------------");
        }

        public void Debai10()
        {
            string debai10 = string.Format("Bài 10: Viết chương trình nhập vào điểm trung bình và kết quả xếp loại của học sinh theo tiêu chuẩn sau: (dùng toán tử 3 ngôi) \n Giỏi: Nếu điểm >= 8; \n Khá: Nếu 8 > điểm >= 6.5; \n Trung bình: Nếu 6.5 > Điểm >= 5; \n Yếu Nếu Điểm < 5");
            Console.WriteLine(debai10);
            Console.WriteLine("---------------------------");
        }

        public void ActionChooseFromKeyboard(int i)
        {
            if (i < 0 || i > 10)
            {
                Console.Write("Số nhập không hợp lệ, vui lòng nhập lại: ");
                i = int.Parse(Console.ReadLine());
            }
        }
    }
}