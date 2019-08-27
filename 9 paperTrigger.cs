using UnityEngine;
using System.Collections;

public class PaperTrigger : MonoBehaviour {
    private bool showPress = false;
    private bool showClue = false;
    public string clue;

    void OnTriggerStay (Collider other){
        showPress = true;
        if(Input.GetKeyDown("e")){
            showClue = true;
        }
    }
    void OnTriggerExit(Collider other){
        showPress = false;
        showClue = false;
    }
    void OnGUI(){
        if(showPress==true){
            GUI.Label(new Rect(400,500,200,50),"Press E to Examine");
        }
        if(showClue==true){
            GUI.Label(new Rect(600,120,300,100),clue);
        }
    }
}
