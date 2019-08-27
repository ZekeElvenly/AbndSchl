using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gateTrigger : MonoBehaviour (
    public InventoryArray itemNeed;
    public GameObject target;
    public string eventName1;
    private bool showPress = false;
    private bool itemTrue = true;
    private bool item1 = false;
    private bool item2 = false;
    private bool item3 = false;

    void Start (){
        itemNeed = GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventoryArray>();
    }
    void OnTriggerStay(Collider other){
        showPress = true;
        if(Input.GetKeyDown("e")){
            for(int i=0; i<itemNeed.arrayInvent.Lenght;i++){
                if(itemNeed.arrayInvent[i]=="Gate Key"){
                    item1 = true;
                }
                if(itemNeed.arrayInvent[i]=="Crowbar"){
                    item2 = true;
                }
                if(itemNeed.arrayInvent[i]=="Hydrochloric Acid"){
                    item3 = true;
                }
            }
        }
        if(item1==true&&item2==true&&item3==true){
            iTweenEvent.GetEvent(target.eventName1).play();
        }else itemTrue = false;
    }
    void OnTriggerExit(Collider other){
        showPress = false;
        itemTrue = true;
    }
    void OnGUI(){
        if(showPress == true){
            GUI.Label(new Rect(400, 520, 200, 50),"You dont have items that needed to open the gate")
        }
    }
)
