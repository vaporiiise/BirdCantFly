using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerTest2 : MonoBehaviour
{
    public GameObject[] Obstacles;
    public float SpawnInterval = 1f;
    private float _timer = 0f;
    public float minY = 1f;
    public float maxY = 10f;

    // Start is called before the first frame update
    void Start()
    {
        _timer = SpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > 0f)
        {
            _timer -= Time.deltaTime;
            return;
        }
        _timer = SpawnInterval;
        int random = Random.Range(0, Obstacles.Length);
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);
        GameObject.Instantiate(Obstacles[random], spawnPosition, transform.rotation);
    }
}
