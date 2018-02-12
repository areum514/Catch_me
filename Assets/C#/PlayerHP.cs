using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {
   
    [SerializeField]// private 인데도 insfector 에서 볼수있게해주는 선언 
    private int hp=10;
    public Text hpText;
    public float lastAutoHealTime;
    public float autoHealInterval = 10;
    public Button_Controller gotoMainpage;
    public enemySpawn a;
    public PlayerMove b;
    //public Text higestScoreText;
    //public PlayerMove c;

    public Text higestScoreText;
    public GameObject gotobutton;

    public void HealHp(int amount) {
        hp += amount;
        UpdateHp();
    }
    public void DemageHp(int amount) {
        hp -= amount;
        UpdateHp();
        if (hp <= 9) {
            Death();
        }
        else UpdateHp();
    }

    public void Death() {
        a.GAMESTAND = false;
        b.GAMESTAND = false;
        //c.GAMESTAND = false;
        
      if (hp == 9)
        gotobutton.SetActive(!gotobutton.activeSelf);
    }

    public void UpdateHp(){
        hpText.text = hp.ToString();
        higestScoreText.text = hpText.text;


    }
   
    void Update(){
            hpText.text = hp.ToString();
           lastAutoHealTime = Time.time;
    }




}
