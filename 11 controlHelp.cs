using UnityEngine;
using System.Collections;

public class controlHelp : MonoBehaviour{
    private bool showHelp;

    //Use this for initialization
    void Update(){
        if(Input.GetKeyDown("h")){
            showHelp=!showHelp
        }
    }

    void OnGUI(){
        if(showHelp){
            GUI.Label(new Rect(600,140,200,20),"Use Mouse to Look Around");
            GUI.Label(new Rect(600,160,200,20),"Use W,A,S and D to Move");
            GUI.Label(new Rect(600,180,200,20),"Press 'i' to Open the Inventory");
        }
    }
}
