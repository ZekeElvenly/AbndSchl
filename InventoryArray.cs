using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryArray : MonoBehaviour {
    public string[] arrayInvent;
    private bool showInvent;

    void Start (){
        arrayInvent = new string[5];
        arrayInvent[0] = "===Inventory===";
    }
    void Update () {
        if(input.GetKeyDown("i")) {
            showInvent = !showInvent;
        }
    }
    void OnGUI(){
        if(showInvent){
            for(int i = 0; i < arrayInvent.Length; i++){
                GUI.Box(new Rect (10, i*25, 120, 30),arrayInvent[i]);
            }
        }
    }
}
