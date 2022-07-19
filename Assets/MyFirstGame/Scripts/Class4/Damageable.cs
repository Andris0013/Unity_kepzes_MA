using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] public int health;         // serializefield is optional, every public is serializefield
    [SerializeField] int maxHealth;

    void OnTriggerEnter(Collider other)
    {
        Damager damager = other.gameObject.GetComponent<Damager>();


        if (damager != null && health > 0)
        {
            Debug.Log(other.name);

            // health -= Mathf.Min(damager.damage,health);
            health -= damager.damage;
            health = Mathf.Clamp(health, 0, maxHealth);
        }
    }
}
