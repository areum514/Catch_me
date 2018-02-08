
using UnityEngine;

public class EnemyDestory : MonoBehaviour {
    public GameObject enemyPrefab;

    public void Start()
    {       
            Destroy(gameObject,10);    
    }
  
    
}

