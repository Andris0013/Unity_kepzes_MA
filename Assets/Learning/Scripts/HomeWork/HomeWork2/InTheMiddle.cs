
// Írjatok komponenst, ami a game objectet két beállítható pozíció középpontjába teszi

using UnityEngine;

public class InTheMiddle : MonoBehaviour
{

    [SerializeField] Vector3 FixPoint1;
    [SerializeField] Vector3 FixPoint2;

    void Update()
    {
        Vector3 position = transform.position;

        transform.position = (FixPoint1 + FixPoint2) * 0.5F;
    }
}
