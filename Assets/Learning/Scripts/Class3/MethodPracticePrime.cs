
/*
        Methodokon bel�l vannak f�ggv�nyek/functions �s elj�r�sok/ is
        Ha f�ggv�ny akkor kell a return, ha elj�r�s, akkor kil�p a f�hhv�nyb�l
 */

using UnityEngine;

public class MethodPracticePrime : MonoBehaviour
{
    void Start()
    {
        int count = 0;
        int number = 2;
        while (count < 100)
        {
            bool isPrime = IsPrime(number);

            if (isPrime)
            {
                Debug.Log(number);
                count++;
            }
            number++;
        }
    }
    bool IsPrime(float number)                      
    {
        bool isPrime = true;
        if (number < 2)
            isPrime = false;
        else
        {
            for (int i = 2; i < number; i++)
            {
                bool d = number % i == 0;
                if (d)
                    isPrime = false;
            }
        }
        return isPrime;
    }

}
