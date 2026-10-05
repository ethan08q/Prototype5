using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnPoints;
    [SerializeField]
    private GameObject[] enemies;

    [SerializeField]
    private float spawnRate = 5f;

    void Start()
    {
         StartCoroutine(spawnEnemy(spawnRate, enemies[Random.Range(0, enemies.Length)]));
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            GameObject newEnemy = Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
            StartCoroutine(spawnEnemy(spawnRate, enemies[Random.Range(0, enemies.Length)]));
        }
    }
}
