using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public bool GAMESTAND = true;
    public float speed = 10f;
    public GameObject Player;

    private void Start() {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update () {

        if (GAMESTAND)
        {
            Vector3 diff = Player.transform.position - transform.position;
            Vector3 dir = diff.normalized;
            transform.Translate(dir * speed * Time.deltaTime);
        }
       
    }

    private void OnTrigger(Collider other)
    {
        Debug.LogFormat("onTriggerEnter called. other is {0}", other.name);
    }

}
