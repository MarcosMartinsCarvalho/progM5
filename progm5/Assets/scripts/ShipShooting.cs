using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform firePoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
