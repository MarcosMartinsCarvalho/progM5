using UnityEngine;

public class PickupCycling : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            // Cycle through available pickups
            Debug.Log("Pickup changed!");
        }
    }
}
