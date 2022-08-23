using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;

    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode rightKey;

    [SerializeField] Damageable damageable;

    private void OnValidate()
    {
        if (damageable == null)
            damageable = GetComponent<Damageable>();        
    }



    void Update()                            // Update is called once per frame
    {
        if (damageable != null && damageable.health <= 0)
            return;

        Vector3 velocity = GetInputVector();
        Move(velocity);
    }

    private void Move(Vector3 velocity)
    {
        transform.position += velocity.normalized * speed * Time.deltaTime;

        if (velocity != Vector3.zero)
        {

            Quaternion targetRotation = Quaternion.LookRotation(velocity);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        }
    }

    Vector3 GetInputVector()
    {
        bool up = Input.GetKey(upKey);
        bool down = Input.GetKey(downKey);
        bool right = Input.GetKey(rightKey);
        bool left = Input.GetKey(leftKey);

        // float y = ToAxis(up, down);
        float x = ToAxis(right, left);
        float z = ToAxis(up, down);
        return new Vector3(x, 0, z);
    }

    float ToAxis(bool positive, bool negative)                               // Elmozdulas fuggvenyunk
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
/* 
   Time.deltatime megadja, hogy mennyi id� telt el az utols� k�pfriss�t�s �ta
   Normalized seg�t abban, hogy �tl�s mozg�sn�l ne v�ltozzon a sebess�g
   += azt jelenti, hogy onmagahoz is hozzaadja
   speed a bevitt sebesseg ertek

   Quaternionnal könnyebb számolnia a gépnek és ezzel megadjuk, melyik irányba nézzen a game object, ami a velocity
*/
