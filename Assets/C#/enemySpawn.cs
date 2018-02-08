using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public bool GAMESTAND = true;
    public GameObject enemyPrefab;
    private float lastSpawnTime;
    public float spawnInterval = 1.5f;
    public float spawnRadius = 10.0f;
    public GameObject player;
 
    void Update(){
        if (GAMESTAND)
        {
            if (Time.time - lastSpawnTime > spawnInterval)
            {
                Spawn();
                lastSpawnTime = Time.time;
            }
        }
    }

    private void Spawn() {
        var theta = Random.Range(0, 2 * Mathf.PI);
        var enemy= Instantiate(enemyPrefab, transform);
        var spawnPos = spawnRadius * new Vector3(Mathf.Sin(theta), 0, Mathf.Cos(theta));
        enemy.transform.position = player.transform.position+spawnPos;   
    }
}

