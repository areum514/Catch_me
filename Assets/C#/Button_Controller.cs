
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_Controller  : MonoBehaviour {
    public AudioSource audioSoirce;//sound file
    public AudioSource buttonSound;
    public GameObject hpPanel;
    public GameObject gotoMain;

    public Text addNumberButtionText;//누르면 증가하는 버튼의 text
 // public Text higestScoreText;
    public Text timetext;


    public void OpenMainScene() {
        
        SceneManager.LoadScene("Main");
    }

    public void OpenSplashScene(){
       
        SceneManager.LoadScene("Splash");
    }

    public void playSound() {
        
        audioSoirce.Play();
    }

  

    public void ToggleHpPanel() {
        buttonSound.Play();
        hpPanel.SetActive(!hpPanel.activeSelf);
    }
    
    public void AddNumber() {
     var addNumber= PlayerPrefs.GetInt("ADD_NUMBER", 1);
        addNumberButtionText.text = (addNumber + 1).ToString();
        PlayerPrefs.SetInt("ADD_NUMBER", addNumber + 1);
        PlayerPrefs.Save();
        
    }


    void update()
    {
            var t = TimeSpan.FromSeconds(Time.time);
            timetext.text = string.Format("{0}:{1} ", t.Seconds, (t.Milliseconds) / 10);
 
    }



}
