using UnityEngine;

public class LinearMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode rightKey;
  
    void Update()                            // Update is called once per frame
    {
        bool up = Input.GetKey(upKey);
        bool down = Input.GetKey(downKey);
        bool right = Input.GetKey(rightKey);
        bool left = Input.GetKey(leftKey);

        // float y = ToAxis(up, down);
        float x = ToAxis(right, left);
        float z = ToAxis(up, down); 

        Vector3 velocity = new Vector3(x, 0, z);

        transform.position += velocity.normalized * speed * Time.deltaTime;       
        // Time.deltatime megadja, hogy mennyi id� telt el az utols� k�pfriss�t�s �ta
        // Normalized seg�t abban, hogy �tl�s mozg�sn�l ne v�ltozzon a sebess�g
        // += azt jelenti, hogy �nmag�hoz is hozz�adja
        // speed a bevitt sebess�g �rt�k

    }

    float ToAxis(bool positive, bool negative)                  // Elmozdul�s f�ggv�ny�nk
    {
        float value;
        if (positive)
            value = 1;
        else if (negative)
            value = -1;
        else
            value = 0;
        return value;

    }
}
