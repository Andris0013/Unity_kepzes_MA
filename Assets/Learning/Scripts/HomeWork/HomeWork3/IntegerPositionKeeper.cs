
// Írj programot, mely a game objektet egész koordinátákon tartja

using UnityEngine;

public class IntegerPositionKeeper : MonoBehaviour
{
    [ExecuteInEditMode]
    
    void Update()     // Update is called once per frame
    {
        Vector3 position = transform.position;

        position.y = Mathf.Round(position.y);
        position.x = Mathf.Round(position.x);
        position.z = Mathf.Round(position.z);

        transform.position = position;
    }
}
