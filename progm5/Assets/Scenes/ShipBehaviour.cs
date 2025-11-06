using UnityEngine;

public class ShipBehaviour : MonoBehaviour
{
    public Movement movement;

    void Update()
    {
        movement.useInput = true;
    }
}
