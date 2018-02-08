
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_Controller  : MonoBehaviour {
    public AudioSource audioSoirce;//sound file
    public GameObject hpPanel;
    public GameObject gotoMain;
    public Text addNumberButtionText;//누르면 증가하는 버튼의 text
    
    public void Start() {
        
      //  addNumberButtionText.text = PlayerPrefs.GetInt("ADD_NUMBER").ToString();
    }

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
        hpPanel.SetActive(!hpPanel.activeSelf);
    }
    
    public void AddNumber() {
     var addNumber= PlayerPrefs.GetInt("ADD_NUMBER", 1);
        addNumberButtionText.text = (addNumber + 1).ToString();
        PlayerPrefs.SetInt("ADD_NUMBER", addNumber + 1);
        PlayerPrefs.Save();
    }
  
    public void gotoMainpage() {
       
        SceneManager.LoadScene("Splash");
    }

}
