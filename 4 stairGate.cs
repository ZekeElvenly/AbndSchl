using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class stairGate : MonoBehaviour {
    public InventoryArray itemNeed;
    public GameObject target;
    public GUIHandler1 life;
    public string eventName1;
    private bool showPress = false;
    private bool keyTrue = true;
    private bool item1 = false;
    public GameObject trigger1;

    void Start(){
        itemNeed = GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventoryArray>();
        life = GameObject.FindGameObjectWithTag("TimeLeft").GetComponent<GUIHandler1>();
    }
    void OnTriggerStay(Collider other){
        showPress = true;
        if(input.GetKeyDown("e")){
            for(int i=0;i<itemNeed.arrayInvent.Lenght;i++){
                if(itemNeed.arrayInvent[i]=="Unknown Key 3"){
                    item1=true;
                }
            }
            if(item1==true){
                iTweenEvent.GetEvent(target,eventName1).Play();
                DestroyObject(trigger1);
            }
            else{
                life.life-=1;
                keyTrue=false;
            }

        }
    }
    void OnTriggerExit(Collider other){
        showPress=false;
        keyTrue=true;
    }
    void OnGUI(){
        if(showPress=true){
            GUI.Label(new Rect(400,500,200,50),"You dont have any right key to open this gate");
        }
    }
}
