using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float move = Input.GetAxis("Vertical");
        transform.position += transform.forward * moveSpeed * move * Time.deltaTime;
    }
}
