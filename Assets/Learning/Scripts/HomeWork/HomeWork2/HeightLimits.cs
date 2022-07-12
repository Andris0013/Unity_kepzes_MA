
// Írjatok komponenst, mely nem engedi, hogy a game object 2 határértéken kívülre kerüljön
// Update-ben megnézi, hogy kívül van-e a tartományon, és ha igen, akkor beljebb teszi

using UnityEngine;

public class HeightLimits : MonoBehaviour
{

    [SerializeField] float minimum;
    [SerializeField] float maximum;

    void Update()
    {
        Vector3 position = transform.position;

       /*
        if (position.y < minimum)
            position.y = minimum;
        else if (position.y > maximum)
            position.y = maximum;

        transform.position = position;
       */

        position.y = Mathf.Clamp(position.y, minimum, maximum);
        transform.position = position;

    }
}
