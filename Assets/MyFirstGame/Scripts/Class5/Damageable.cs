using TMPro;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] public int health;                                                  // serializefield is optional, every public is serializefield
    [SerializeField] int maxHealth;
    [SerializeField] GameObject GameOverObject;
    [SerializeField] TMP_Text uiText;

    void OnTriggerEnter(Collider other)
    {
        Damager damager = other.gameObject.GetComponent<Damager>();


        if (damager != null && health > 0)
        {
            health -= damager.damage;                                                   // health -= Mathf.Min(damager.damage,health);
            health = Mathf.Clamp(health, 0, maxHealth);

            UpdateText();

            if (health == 0)
                GameOver();
        }
    }

    private void Start()
    {
        UpdateText();
    }

    private void UpdateText()
    {
        if (uiText != null)
        {
            uiText.text = $"HP:{ health}";
        }
    }

    void GameOver()
    {
        if (GameOverObject != null)
            GameOverObject.SetActive(true);
    }
}
