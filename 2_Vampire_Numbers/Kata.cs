/*************************************************************
    * Число вампира *
    
    Наше определение числа вампиров можно описать следующим образом:

        6 * 21 = 126
        6 и 21 были бы допустимыми "клыками" для числа вампиров, 
        поскольку цифры 6, 1 и 2 присутствуют как в произведении, так и в множителях

        10 * 11 = 110
        110 не является числом вампира, так как в множителях 
        есть три единицы, но только две единицы в произведении

    Создайте функцию, которая может принимать два "клыка" и определять, 
    является ли произведение двух чисел - числом вампира.

*************************************************************/


using System.Linq;

namespace Vampire_Numbers;


public static class Kata
{
    public static bool vampire_test(long x, long y)
    {
        if(x < 0 && y < 0)
        {
            return false;
        }

        long xAbs = Math.Abs(x);
        long yAbs = Math.Abs(y);

        List<int> productList = (xAbs * yAbs).ToString().Select(e => int.Parse(e.ToString())).ToList<int>();
        productList.Sort();
        List<int> x_and_y_List = (xAbs.ToString() + yAbs.ToString()).Select(e => int.Parse(e.ToString())).ToList<int>();
        x_and_y_List.Sort();

        if(productList.Count != x_and_y_List.Count)
        {
            return false;
        }

        for(int i = 0; i < productList.Count; i++)
        {
            if(productList[i] != x_and_y_List[i])
            {
                return false;
            }
        }

        return true;
    }
}


