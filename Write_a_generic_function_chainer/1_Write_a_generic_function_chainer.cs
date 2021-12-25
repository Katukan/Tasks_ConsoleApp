/*****************************************************

    * Напишите цепочку универсальных функций *

    Напишите универсальный цепочку функций, которая принимает начальное значение, 
    и массив функций для выполнения на нем (массив символов для ruby).

    Входными данными для каждой функции являются выходные данные предыдущей функции 
    (за исключением первой функции, которая принимает начальное значение в качестве входного). 
    Верните окончательное значение после завершения выполнения.


    double input = 2;

    public static double add(double x) {
      return x + 1;
    }

    public static double mul(double x) {
       return x * 30;
    }
    Kata.Chain( input , new[] { (Func<double, double>)add, mul });
    //=> returns 90

******************************************************/


namespace Write_a_generic_function_chainer;

public static class Kata
{
    public static double Chain(double input, Func<double, double>[] fs)
    {
        double argument = input;

        for(int i = 0; i < fs.Length; i++)
        {
            argument = fs[i].Invoke(argument);
        }

        return argument;
    }
}