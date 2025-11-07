using UnityEngine;

public class ShipBehaviour : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform firePoint;
    public MessageHandler messageHandler;

    void Start()
    {
        // Laat introductiebericht zien
        StartCoroutine(messageHandler.ShowMessage(
            "Welcome to Space 4 8.\nMove your ship with the arrows or WASD.\nShoot with SPACE.", 5f));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
    }
}
