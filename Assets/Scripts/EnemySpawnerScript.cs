using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject EnemyPrefab;
    void Start()
    {
        StartCoroutine(SpawnEnemyLoop());
    }

    IEnumerator SpawnEnemyLoop()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(5f);
        }

        void SpawnEnemy()
        {
            Instantiate(EnemyPrefab, transform.position, transform.rotation);
        }
    }
}
