using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {
    //

    public AudioSource audioSoirce;//sound file
    public GameObject Spark;
    PlayerMove playermove;
    //
    public PlayerHP plyerHp;
    public Text hpText;
    //  public int hp;
    private void OnTriggerEnter(Collider other)
    {
        //GameObject 이름으로 구분
        //if (other.gameObject.name=="enemyPrefer") {
        //컨포넌트가 붙어 있는지 여부로 구분
        //if (other.GetComponent<EnemyMove>()) {
        //태그로 구분
      
            if (other.tag == "Enemy")
            {

                var spark = Instantiate(Spark);
                spark.transform.position = other.transform.position;
                audioSoirce.Play();
                plyerHp.DemageHp(1);
                Destroy(other.gameObject);
            }
        
    }

    internal void DisableEffects()
    {
        throw new NotImplementedException();
    }
}
