
// Írj programot, mely egy game objektet két pontot összekötõ vonalon tart, melyen mi adjuk meg a pozícióját.

using UnityEngine;

[ExecuteInEditMode]


public class GOSlider : MonoBehaviour
{
    [SerializeField] Color a;
    [SerializeField] Color b;
    [SerializeField] float targetPosition;
    [SerializeField] float changeSpeed;
    [SerializeField] Transform t1;
    [SerializeField] Transform t2;

    float pos;

    void Start()
    {
        pos = targetPosition;
    }


    void Update()
    {
        pos = Mathf.MoveTowards(pos, Mathf.Clamp01(targetPosition), changeSpeed*Time.deltaTime);


        if (t1 == null || t2 == null)
            return;

        transform.position = Vector3.Lerp(t1.position, t2.position, pos);          // Lineáris interpretáció, lehet LerpUnClamped is, hogy ne vágja le a két végpontnál
    }

    void OnDrawGizmos()
    {
        float r = 0.25f;

        Gizmos.color = a;
        Gizmos.DrawWireSphere(t1.position, r);
        
        Gizmos.color = b;
        Gizmos.DrawWireSphere(t2.position, r);

        Gizmos.color = Color.Lerp(a, b, pos);
        Gizmos.DrawLine(t1.position, t2.position);
    }
}
