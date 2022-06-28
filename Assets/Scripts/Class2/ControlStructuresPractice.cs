using UnityEngine;

public class ControlStructuresPractice : MonoBehaviour
{
    [SerializeField] int a = 3;
    [SerializeField] int b = 5;

    void Start()
    {
        // Ha csak simán elágazás nélkül végigfut a program akkor Sequence!

        if (a > b)                                          // Elágazás/Selection, ha csak egy sor hosaszú, akkor kihagyható a kapcsos zárójel
        {
            Debug.Log("A is greater than B");
        }

        // else if (a >= b) Több irányú elágazás, ha több lehetõséget akarunk.

        else                                               // Kétirányú elágazás (nem mindig van, ha nincs csak átugorja a program az if-et)
        {
            Debug.Log("A is NOT greater than B");
        }

        int i = 1;
        while (i <= 10)                                   //Loop, ha van benne egy ismétlõdõ programsor, ami addig fut, ami hamisba nem ütközik.
        {
            Debug.Log(i);
            i++;
        }



    }
}
