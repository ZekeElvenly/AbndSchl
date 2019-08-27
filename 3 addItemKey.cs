using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class addItemKey : MonoBehaviour {
    public InventoryArray invent;
    public GameObject target;
    public GameObject target2;
    private int i=0;
    private bool showPress = false;

    void Start(){
        invent = GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventoryArray>();
    }

    void OnTriggerStay(Collider other){
        showPress = true;
        if(Input.GetKeyDown("e")){
            if(invent.arrayInvent[i]!=null){
                i++;
            }
            if(invent.arrayInvent[i]==null){
                invent.arrayInvent[i]=target.tag;
                DestroyObject(target);
                DestroyObject(target2);
            }
        }
    }
    void OnTriggerExit(Collider other){
        showPress = false;
    }
    void OnGUI(){
        if(showPress==true){
            GUI.Label(new Rect(400,500,200,50),"Press E to Take the Item");
        }
    }
}
