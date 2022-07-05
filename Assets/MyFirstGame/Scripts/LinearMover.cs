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
        // Time.deltatime megadja, hogy mennyi idõ telt el az utolsó képfrissítés óta
        // Normalized segít abban, hogy átlós mozgásnál ne változzon a sebesség
        // += azt jelenti, hogy önmagához is hozzáadja
        // speed a bevitt sebesség érték

    }

    float ToAxis(bool positive, bool negative)                  // Elmozdulás függvényünk
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
