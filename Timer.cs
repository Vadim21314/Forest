using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer_text;
    public TextMeshProUGUI task_text;

    int time = 120; 

    public GameObject Wolf1; 

    public GameObject Wolf2;

    public GameObject Wolf3;
    public GameObject SOS;
    public WoodController wood_script;
    public GameObject house;
    void Start()
    {
     InvokeRepeating("TimerFunction", 1f,1f);
    }

    void Update()
    {
        
        if(wood_script.isHouse == true) {
            if(Input.GetKeyDown (KeyCode.Tab)){
                wood_script.isHouse = false;
                house.SetActive(true);
                task_text.text = "You got house where you can hide from wolves. Wolves can't reach you in the house";
            }
        }
           
    
    }
    void TimerFunction(){
        time--;
        timer_text.text = time.ToString();
        if (wood_script.k >= 5 ){
            task_text.text = "Press Tаb to build the house";
            wood_script.isHouse = true;
        }
        if(time <= 90){
            Wolf1.SetActive(true);
            Wolf2.SetActive(true);
            Wolf3.SetActive(true);
            task_text.text = "Attention! The wolves have noticed you! Hide in a built house";
        }
        if(time <= 80) {
            task_text.text = "Don't worry! They'll be going home soon! ";
        }
        if(time <= 60) {
            Wolf1.SetActive(false);
            Wolf2.SetActive(false);
            Wolf3.SetActive(false);
            task_text.text = "The wolves have escaped ";
        }
        if( time <= 50) {
            SOS.SetActive(true);
            task_text.text = "You need to find the SOS title in the forest or you will lose when time is over";
        }
        if(time <= 0){
            CancelInvoke();
             SceneManager.LoadScene("youlose");
        }

        
    }
    
}

