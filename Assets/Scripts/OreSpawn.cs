using UnityEngine;

public class OreSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnPrefab;

    [SerializeField]
    private float areaSize;

    [SerializeField]
    private float spawnTime;

    private int spawnCount;

    [SerializeField]
    private int maxSpawnCount;

    private float spawnTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckSpawnTimer())
        {
            SpawnOre();

        }
    }

    public void DecreaseSpawnCount()
    {
        spawnCount--;
    }

    public void setSpawnTime(float pSpawnTime)
    {
        spawnTime = pSpawnTime;
    }

    public void setMaxCount(int maxCount)
    {
        maxSpawnCount = maxCount;
    }

    private void SpawnOre()
    {
        if (spawnCount < maxSpawnCount)
        {
            Instantiate(spawnPrefab, new Vector3(transform.position.x + Random.Range(-areaSize, areaSize), transform.position.y + 0.5f, transform.position.z + Random.Range(-areaSize, areaSize)), Quaternion.identity);
            spawnCount++;
        }
    }

    private bool CheckSpawnTimer()
    {
        if (Time.time - spawnTimer > spawnTime)
        {
            spawnTimer = Time.time;
            return true;
        }
        else return false;
    }
}
