
// Írj programot, mely a game objektet egész koordinátákon tartja

using UnityEngine;

public class IntegerPositionKeeper : MonoBehaviour
{
    
    
    void Update()     // Update is called once per frame
    {
        Vector3 position = transform.position;
        position.y = Mathf.Round(position.y);
        transform.position = position;
    }
}
