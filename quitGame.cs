using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour{
    private bool showFinish = false;

    //Use this for initialization
    void OnTriggerStay (Collider other){
        showFinish = true;
        Time.timeScale = 0;
        if(Input.GetKeyDown("q")){
            Application.Quit();
        }
    }
    void OnGUI(){
        if(showFinish==true){
            GUI.Label(new Rect(600,120,200,100),"Congrats!!, You've made it!!");
            GUI.Label(new Rect(600,140,200,100),"Press Q to Quit the Game");
        }
    }
}
