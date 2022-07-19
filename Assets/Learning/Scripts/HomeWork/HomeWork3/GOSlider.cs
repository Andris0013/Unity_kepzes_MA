
// �rj programot, mely egy game objektet k�t pontot �sszek�t� vonalon tart, melyen mi adjuk meg a poz�ci�j�t.

using UnityEngine;

public class GOSlider : MonoBehaviour
{
    [SerializeField] float position;
    [SerializeField] Transform t1;
    [SerializeField] Transform t2;

    void Update()
    {
        transform.position = (t2.position - t1.position) / position;
    }
}
