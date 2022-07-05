using UnityEngine;

public class Serializables : MonoBehaviour
{
    [SerializeField] int iVar;      //Fields doesn't have to be defined not like local variables inside void start
    [SerializeField] float fVar;
    [SerializeField] string sVar;
    [SerializeField] bool bVar;

    // Void start starts when it's assigned to a game object
    // MonoBehaviour are classes that can be added as components to game object

    void Start()
    {
  

    }

    private void OnValidate()
    {
        var summa = iVar + fVar;
    }
}
