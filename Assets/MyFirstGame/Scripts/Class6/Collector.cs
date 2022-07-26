using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{

    int collectedValue;
    [SerializeField] TMP_Text uiText;
    
    private void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.GetComponent<Collectable>();

        if (collectable != null)
        {
            collectedValue += collectable.value;
            Debug.Log($"Collected: {collectable.value}, {collectedValue}");

            collectable.Collect();

            UpdateText();


        }
    }
    void Start()
    {
        UpdateText();
    }
    
    private void UpdateText()
    {
        if (uiText != null)
        {
            uiText.text = $"Coins:{ collectedValue}";
        }
    }

}
