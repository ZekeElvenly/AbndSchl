using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class doorTrigger : MonoBehaviour {
    public GameObject target;
    public string eventName1;
    public string eventName2;
    private bool showPress = false;
    private bool dontTrigger = true;

    void OnTriggerStay(Collider other){
        showPress=true;
        if(Input.GetKeyDown("e")){
            iTweenEvent.GetEvent(target,eventName1).Play();
            dontTrigger=false;
        }
    }
    void OnTriggerExit(Collider other){
        showPress=false;
        if(dontTrigger==false){
            iTweenEvent.GetEvent(target,eventName2).Play();
            dontTrigger=true;
        }
    }
    void OnGUI(){
        if(showPress=true){
            GUI.Label(new Rect(400,500,200,50),"Press E to Open the Door");
        }
    }
}