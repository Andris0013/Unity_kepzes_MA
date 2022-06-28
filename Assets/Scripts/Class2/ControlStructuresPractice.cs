using UnityEngine;

public class ControlStructuresPractice : MonoBehaviour
{
    [SerializeField] int a = 3;
    [SerializeField] int b = 5;

    void Start()
    {
        // Ha csak sim�n el�gaz�s n�lk�l v�gigfut a program akkor Sequence!

        if (a > b)                                          // El�gaz�s/Selection, ha csak egy sor hosasz�, akkor kihagyhat� a kapcsos z�r�jel
        {
            Debug.Log("A is greater than B");
        }

        // else if (a >= b) T�bb ir�ny� el�gaz�s, ha t�bb lehet�s�get akarunk.

        else                                               // K�tir�ny� el�gaz�s (nem mindig van, ha nincs csak �tugorja a program az if-et)
        {
            Debug.Log("A is NOT greater than B");
        }

        int i = 1;
        while (i <= 10)                                   //Loop, ha van benne egy ism�tl�d� programsor, ami addig fut, ami hamisba nem �tk�zik.
        {
            Debug.Log(i);
            i++;
        }



    }
}
