using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] public int health;                                                  // serializefield is optional, every public is serializefield
    [SerializeField] int maxHealth;
    [SerializeField] GameObject GameOverObject;
    [SerializeField] TMP_Text uiText;
    [SerializeField] float invincibilityTime = 1;
    [SerializeField] float flickDuration = 0.1f;

    bool isInvincible;

    void OnTriggerEnter(Collider other)
    {
        Damager damager = other.gameObject.GetComponentInChildren<Damager>();

        if (isInvincible)
            return;

        if (damager != null && health > 0)
        {
            health -= Mathf.Min(damager.damage, health);                                                   // health -= Mathf.Min(damager.damage,health);

            StartCoroutine(StartInvisibility());

            health = Mathf.Clamp(health, 0, maxHealth);

            UpdateText();

            if (health == 0)
            {
                GameOver();
            }
        }
    }

    IEnumerator StartInvisibility()
    {
        this.isInvincible = true;

        bool visible = false;
        float startTime = Time.time;
        while (startTime + invincibilityTime > Time.time)
        {
            SetVisibility(visible);
            yield return new WaitForSeconds(flickDuration);
            visible = !visible;
        }
        this.isInvincible = false;
        SetVisibility(true);

    }


    void SetVisibility(bool visible)
    {
        MeshRenderer[] meshrenderers = GetComponentsInChildren<MeshRenderer>();

        foreach (MeshRenderer mr in meshrenderers)
        {
            if (mr != null)
                mr.enabled = visible;
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
