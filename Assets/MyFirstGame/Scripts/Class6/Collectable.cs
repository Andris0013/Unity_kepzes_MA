using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int value;
    [SerializeField] Bounds bounds;

    public void Collect()
    {
        //  gameObject.SetActive(false);            // kikapcsol�s
        //  Destroy(gameObject);                    // t�rl�s

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        float z = Random.Range(bounds.min.z, bounds.max.z);

        transform.position = new Vector3(x, y, z);

    }

    public void OnDrawGizmosSelected()              // ne legyen t�l sok gizmo kirajzolva
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}
