using System;

public class GCDCalculator
{
    // Bước 1: Hàm tính UCLN của 2 số (Sử dụng thuật toán Euclid)
    public static int FindGCD(int a, int b)
    {
        // Đảm bảo xử lý số dương
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

   
    public static int FindArrayGCD(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Mảng không được rỗng.");
        }

        // Lấy phần tử đầu tiên làm giá trị khởi tạo
        int result = arr[0];

        // Duyệt qua các phần tử còn lại
        for (int i = 1; i < arr.Length; i++)
        {
            result = FindGCD(result, arr[i]);

            // Tối ưu hóa: Thoát sớm nếu UCLN đã bằng 1
            if (result == 1)
            {
                break;
            }
        }

        return result;
    }

    public static void Main()
    {
        int[] numbers = { 24, 36, 48, 60 };
        int gcd = FindArrayGCD(numbers);
        
        Console.WriteLine($"UCLN của mảng là: {gcd}"); 
        // Kết quả sẽ in ra: 12
    }
}