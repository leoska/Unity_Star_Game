using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    [Header("Limits")]
    public float min_Y;
    public float max_Y;

    [Header("Enemy prefabs")]
    public GameObject[] enemyPrefabs;

    public float timer = 2f;

    private Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        Invoke("SpawnEnemies", timer);
    }

    void SpawnEnemies()
    {
        float pos_Y = Random.Range(min_Y, max_Y);
        Vector3 temp = _transform.position;

        temp.y = pos_Y;

        Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length - 1)], temp, Quaternion.Euler(0f, 0f, 0f));

        Invoke("SpawnEnemies", timer);
    }

}
