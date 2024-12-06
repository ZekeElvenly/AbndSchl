using UnityEngine;
using System.Collections;

public class LevelFinish : MonoBehaviour {
    private bool showFinish=false;
    public byte level;

    void OnTriggerStay(Collider other){
        showFinish=true;
        Time.timeScale=0;
        if(Input.GetKeyDown("e")){
            Time.timeScale=1;
            Appication.Loadlevel(Level);
        }
    }
    void OnGUI(){
        if(showFinish==true){
            GUI.Label(new Rect(600,120,200,100),"Congrats!!, You finish the level");
            GUI.Label(new Rect(600,120,200,100),"Press E to continue to next level");
        }
    }
}

