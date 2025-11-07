using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool useInput = false;

    void Update()
    {
        float input = useInput ? Input.GetAxis("Vertical") : 1f;
        transform.position += transform.forward * moveSpeed * input * Time.deltaTime;
    }
}
