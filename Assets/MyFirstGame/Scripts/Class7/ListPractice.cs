using System.Collections;
using System.Collections.Generic;       // This one contains the List 
using UnityEngine;

public class ListPractice : MonoBehaviour
{
    [SerializeField] List<string> list;
    [SerializeField] bool hasAlma;
    [SerializeField] int strawberrycount;

    private void OnValidate()
    {
        // list.Add(2); works with int list
        // list.RemoveAt(0); works with int list
        // list.Clear();
        list.Remove("del");
        hasAlma = list.Contains("Alma");

        strawberrycount = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == "Eper")
                strawberrycount++;
        }
    }
}
