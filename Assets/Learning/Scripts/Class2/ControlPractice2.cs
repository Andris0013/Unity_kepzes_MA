using UnityEngine;

public class ControlPractice2 : MonoBehaviour
{
    void Start()
    {
        int i = 1;
        int count = 0;

        while (count <= 5)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
                count++;
            }
            i = i + 1;
        }

        for (int a = 0; a < 5; a++)         // For pont a fenti feladatra alkalmas
        {
            Debug.Log(a);
        }
    }
}
