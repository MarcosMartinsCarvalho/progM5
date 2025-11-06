using UnityEngine;

public class LaserBehaviour : MonoBehaviour
{
    public Movement movement;

    void Start()
    {
        movement.useInput = false;
    }
}
