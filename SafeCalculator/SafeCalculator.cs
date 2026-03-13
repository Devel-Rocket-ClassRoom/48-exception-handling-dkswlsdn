using System;
using System.Collections.Generic;
using System.Text;

public class SafeCalculator
{
    public void SafeDivide(string num1, string num2)
    {
        try
        {
            Divide(num1, num2);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("계산기를 종료합니다");
        }
    }


    public void Divide(string num1, string num2)
    {
        if (int.TryParse(num1, out int n) && int.TryParse(num2, out int m))
        {
            if (m == 0)
            {
                throw new DivideByZeroException("0으로 나눌 수 없습니다.");
            }

            Console.WriteLine($"{n} / {m} = {n / m}");
            return;
        }

        throw new FormatException("올바른 숫자를 입력하세요.");
    }
}