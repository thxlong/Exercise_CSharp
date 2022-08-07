using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CSharp.Actions
{
    public class ActionEx
    {
        #region Variable
        const string divider = "---------------------------";
        const string dividerPlus = "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++";
        const string dividerEqual = "===============================================================================";
        #endregion

        #region Methods
        public void InDeBai()
        {
            Console.WriteLine(dividerEqual);
            Topic_A();
            DeBai_A1();
            DeBai_A2();
            Topic_B();
            Console.WriteLine(dividerEqual);
            Topic_C();
            DeBai_C1();
            DeBai_C2();
            Console.WriteLine(dividerEqual);
            Topic_D();
            DeBai_D1();
            DeBai_D2();
            Console.WriteLine(dividerEqual);
            Topic_E();
            DeBai_E1();
            Console.WriteLine(dividerEqual);
            Topic_F();
            DeBai_F1();
            Console.WriteLine(dividerEqual);
            Topic_G();
            DeBai_G1();
            Console.WriteLine(dividerEqual);
            Topic_H();
            DeBai_H1();
            DeBai_H2();
            DeBai_H3();
            DeBai_H4();
            DeBai_H5();
            Console.WriteLine(dividerEqual);
            Topic_I();
            DeBai_I1();
            DeBai_I2();
            DeBai_I3();
            Console.WriteLine(dividerEqual);
            Topic_J();
            DeBai_J1();
            Console.WriteLine(dividerEqual);
            Topic_K();
            DeBai_K1();
            DeBai_K2();
            DeBai_K3();
            DeBai_K4();
            DeBai_K5();
            Console.WriteLine(dividerEqual);
            Topic_L();
        }
        public void WriteTopic(string topic)
        {
            Console.WriteLine(dividerPlus);
            Console.WriteLine(topic);
            Console.WriteLine(dividerPlus);
        }
        #region Topic
        public void Topic_A()
        {
            string topic = "A. Thực hành với khởi tạo, log ra giá trị ";
            WriteTopic(topic);
        }
        public void Topic_B()
        {
            string topic = "B. Thực hành với các phép toán";
            WriteTopic(topic);
        }
        public void Topic_C()
        {
            string topic = "C. Thực hành với các toán tử gán";
            WriteTopic(topic);
        }
        public void Topic_D()
        {
            string topic = "D. Thực hành với if - else if";
            WriteTopic(topic);
        }
        public void Topic_E()
        {
            string topic = "E. Thực hành với Switch Case";
            WriteTopic(topic);
        }
        public void Topic_F()
        {
            string topic = "F. Thực hành với toán tử 3 ngôi";
            WriteTopic(topic);
        }
        public void Topic_G()
        {
            string topic = "G. Thực hành với While";
            WriteTopic(topic);
        }
        public void Topic_H()
        {
            string topic = "H. Thực hành với Foreach, For, Break";
            WriteTopic(topic);
        }
        public void Topic_I()
        {
            string topic = "I. Thực hành với String";
            WriteTopic(topic);
        }
        public void Topic_J()
        {
            string topic = "J. Thực hành với Array";
            WriteTopic(topic);
        }
        public void Topic_K()
        {
            string topic = "K. Thực hành với List";
            WriteTopic(topic);
        }
        public void Topic_L()
        {
            string topic = "L. Thực hành với Dictionary";
            WriteTopic(topic);
        }
        #endregion

        #region Đề bài
        public void DeBai_A1()
        {
            string deBai = "Bài A1: Viết khởi tạo, log ra giá trị \n Viết chương trình xuất ra màn hình các dòng sau: \n 1. Họ và tên \n 2. Năm sinh \n 3. Giới tính \n 4. Tuổi";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_A2()
        {
            string deBai = "Bài A2: Viết chương trình khai báo các biến sau: \n 1.hoTen \n 2.diemToan \n 3.dienVan \n Cho người dùng nhập vào họ tên, điểm Toán, điểm Văn \n Xuất ra màn hình: học sinh có điểm toán là 9.5, điểm Văn là 8.0(sử dụng float)";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void Debai4()
        {
            string deBai = "Bài 4: Tìm x, y khi biết tổng và hiệu của chúng";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_C1()
        {
            string deBai = "Bài tập C1: Viết chương trình cho phép người dùng nhập vào số nguyên a \n Nhập a = 5, thực hiện các phép tính sau đây và in ra kết quả màn hình \n A) a+=3 ? \n B) a-=5 ? \n C) a*=2 ? \n D) a/=9 ? \n E) a%=5 ? \n F) cho b=2, rút gọn biểu thức a=a-(b+7)";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_C2()
        {
            string deBai = "Bài tập C2: Viết chương trình nhập vào từ bàn phím bán kính r của đường tròn, in ra kết quả (cho pi=3.14 ) (—> Lấy Pi dài Math.PI) \n a. Chu vi = ? \n b. Diện tích = ? \n Gợi ý : \n chu vi = 2r3.14 \n dientich = 3.14* (r^2) // có thể dùng r*r để tính r bình phương";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_D1()
        {
            string deBai = "Bài tập D1: Viết chương trình nhập vào chiều cao, cân nặng, tính BMI và xuất ra thông báo \n BMI<15: Thân hình quá gầy \n BMI>=15 and BMI<16: Thân hình gầy \n BMI>=16 and BMI<18.5: Thân hình hơi gầy \n BMI>=18.5 and BMI<25:Thân hình bình thường \n BMI>=25 and BMI < 30:Thân hình hơi béo \n BMI >=30 and BMI<35:Thân hình béo \n BMI >=35:Thân hình quá béo";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_D2()
        {
            string deBai = "Bài tập D2: Viết chương trình giải phương trình bậc 2 : \nax^2 + bx + c =0";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void Debai10()
        {
            string deBai = "Bài 10: Viết chương trình nhập vào điểm trung bình và kết quả xếp loại của học sinh theo tiêu chuẩn sau: (dùng toán tử 3 ngôi) \n Giỏi: Nếu điểm >= 8; \n Khá: Nếu 8 > điểm >= 6.5; \n Trung bình: Nếu 6.5 > Điểm >= 5; \n Yếu Nếu Điểm < 5";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_E1()
        {
            string deBai = "Bài tập E1: Áp dụng switch case \n Viết chương trình khung tìm kiếm: cho người dùng nhập vào lựa chọn \n 1. tìm theo tên \n 2. tìm theo tác giả \n 3. tìm theo nhà xuất bản \n 4. tìm theo tiêu đề \n Thoát nếu phím bấm không hợp lệ";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_F1()
        {
            string deBai = "Bài tập F1: \n Viết chương trình nhập vào điểm trung bình, và kết quả xếp loại của học \n sinh theo tiêu chuẩn sau: ( dùng toán tử 3 ngôi ) \n - Giỏi: Nếu Điểm >= 8 \n - Khá: Nếu 8 > Điểm >= 6.5 \n - Trung bình: Nếu 6.5 > Điểm >= 5 \n - Yếu: Nếu Điểm < 5 \n ";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_G1()
        {
            string deBai = "Bài tập G1: Viết chương trình nhập vào số n từ bàn phím. \n n phải nằm trong khoảng từ 1 đến 99 \n Nhập sai bắt nhập lại \n";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_H1()
        {
            string deBai = "Bài tập H1: Viết chương trình cho người dùng nhập vào 1 tháng bất kỳ từ 1 - 12 ⇒ Cho biết tháng đó có bao nhiêu ngày?";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_H2()
        {
            string deBai = "Bài tập H2: \n a) Viết chương trình tính tổng các số lẻ từ 1 đến n, n nhập từ bàn phím \n b) Nhập n = 7, Bỏ qua không cộng tổng với số 3 => in ra kết quả \n (gợi ý đáp án : 1+5+7 =13) \n c) Thử break khi vòng lặp chạy đến giá trị n=3 \n";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_H3()
        {
            string deBai = "Bai tập H3: Viết chương trình : \n Tìm những số chia hết cho 3 từ 10 đến 50.";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_H4()
        {
            string deBai = "Bài tập H4: \n Viết chương trình: \n Tính tổng S= 1!+2!+3!+....+10!";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_H5()
        {
            string deBai = "Bài tập H5: \n Viết chương trình nhập nhập số nguyên a> 0 từ bàn phím nhập vào 1 số từ bàn phím. Cho biết đó có phải số ng tố (số ng tố là số >1, và chỉ chia hết cho 1 và chính nó ).";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_I1()
        {
            string deBai = "Bài tập I1: \n Viết chương trình chuyển tin nhắn sang mật mã theo bảng : \n #a=\"abcdefghijklmnopqrstuvwxyz\" \n #b=\"zxcvbnmasdfghjklqwertyuiop\"";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_I2()
        {
            string deBai = "Bài tập I2 : \n Cho chuỗi : \n a= \" \n tôi chăm học \n tôi chịu khó \n tôi xinh gái \n \" \n đếm từ tôi trong string a trên";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_I3()
        {
            string deBai = "Bài tập I3 : (chuỗi có khoảng cách) \n Viết chương trình tách số và chữ từ chuỗi nhập vào thành 2 chuỗi : \n Ví dụ nhập vào : abc123 sẽ tách và in ra thành 2 chuỗi abc và 123 \n ";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_J1()
        {
            string deBai = "Bài tập J1. \n 1. Viết chương trình tạo 1 mảng 1 chiều gồm các phần tử là số nguyên, có n phần tử ngẫu nhiên, n do người dùng nhập từ bàn phím \n 2. Xuất các giá trị trong mảng \n 3. Đảo ngược mảng, và xuất mảng sau khi đảo ngược \n 4. Sắp xếp mảng tăng dần \n 5. Tính tổng các phần tử trong mảng \n 6. Cho người dùng nhập 1 số bất kỳ, kiểm tra số đó có tồn tại trong mảng hay không, nếu có xuất ra vị trí index của số đó trong mảng \n";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_K1()
        {
            string deBai = "Bài tập K1: \nViết chương trình tạo ra 1 list có n phần tử, n nhập từ bàn phím \n Các phần tử là số ngẫu nhiên từ (1,100).";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_K2()
        {
            string deBai = "Bài tập K2: \n Viết chương trình nhập vào 1 danh sách list sau đó: \n 1. tạo ra 1 list mới bình phương các phần từ \n 2.Xác định bao nhiêu phần tử lớn hơn 50.";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_K3()
        {
            //string deBai = "Bài tập K3: \n Viết chương trình trả lời kết quả các phép tính \n quest = {\"2 + 5 + 7 = \",\"5 * 10 = \",\"sqrt(16) = \",\"12 % 2 = \",\"5//2=\"}";
            //Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_K4()
        {
            string deBai = "Bài tập K4 \n Viết chương trình nhập vào 1 list \n - 1 in ra có bao nhiêu số nhỏ hơn 5 \n - 2 và in ra vị trí index các số đó \n ";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        public void DeBai_K5()
        {
            string deBai = "Bài tập K5: \n - 1: Viết chương trình in số lớn thứ 2 và số nhỏ thứ 2 trong list \n - 2: in ra vị trí index số đó \n Ví dụ list: \n lst={1,2,3,4,5} \n số lớn thứ 2: 4 , vị trí index trong list là 3 \n số nhỏ thứ 2 trong list là 2, vị trí index trong list là 1";
            Console.WriteLine(deBai);
            Console.WriteLine(divider);
        }
        #endregion
        public void ActionChooseFromKeyboard(int i)
        {
            if (i < 0 || i > 10)
            {
                Console.Write("Số nhập không hợp lệ, vui lòng nhập lại:");
                i = int.Parse(Console.ReadLine());
            }
        }
        #endregion
    }
}