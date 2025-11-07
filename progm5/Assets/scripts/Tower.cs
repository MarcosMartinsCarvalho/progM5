using UnityEngine;

public class Tower : MonoBehaviour
{
    private void Start()
    {
        float scale = Random.Range(0.5f, 3f);
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
