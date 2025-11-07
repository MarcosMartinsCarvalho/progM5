using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<GameObject> enemies = new List<GameObject>();
    private float elapsedTime = 0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                GameObject e = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                enemies.Add(e);
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (GameObject e in enemies)
            {
                Destroy(e);
            }
            enemies.Clear();
        }

        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject e = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                enemies.Add(e);
            }
            elapsedTime = 0f;
        }
    }
}
