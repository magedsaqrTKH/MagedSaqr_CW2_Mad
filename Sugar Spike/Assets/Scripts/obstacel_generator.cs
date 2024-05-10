using UnityEngine;

public class obstacel_generator : MonoBehaviour
{
    public GameObject obstacles;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBetweenSpawns = 1f;
    private float nextSpawnTime;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnObstacle();
            nextSpawnTime = Time.time + timeBetweenSpawns;
        }
    }

    void SpawnObstacle()
    {
        
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);

        
        Instantiate(obstacles, transform.position + new Vector3(x, y, 0), Quaternion.identity);
    }
}
