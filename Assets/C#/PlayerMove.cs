using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

    public float speed =6;
    public DirPad dirPad;
    public GameObject hpPanel;

    //게임 시작후 10초마다 플레이어 점수 1점 추가 
    private float lastSpawnTime;
    public float spawnInterval =10.0f;
    public PlayerHP plyerHp;
    public Text hpText;
    public int hp=50;
    public string Gameover = "9";
    public float playSize = 50.0f;


    public bool GAMESTAND = true;
    internal object playerShooting;

    void Start()
    {
        Debug.Log("Start() called.");
    }
    
    // Use this for initialization
    void FixedUpdate()
    {
        if (GAMESTAND)
        {
            //게임 시작후 10초마다 플레이어 점수 1점 추가 
            if (Time.time - lastSpawnTime > spawnInterval)
            {
                plyerHp.HealHp(1);
                lastSpawnTime = Time.time;
            }


            if (dirPad.dragging)
            {
                var dn = dirPad.dir.normalized * Time.deltaTime * speed;
                transform.Translate(new Vector3(dn.x, 0, dn.y));
            }
            else
            {
                var dx = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
                var dz = Input.GetAxis("Vertical") * Time.deltaTime * speed;
                transform.Translate(new Vector3(dx, 0, dz));
            }

            //playground 한정하기 
            Vector3 movedPosition = transform.position;
            movedPosition.x = Mathf.Clamp(movedPosition.x, -playSize, playSize);
            movedPosition.y = Mathf.Clamp(movedPosition.y, -playSize, playSize);
            transform.position = movedPosition;
        }
    }
    
}
