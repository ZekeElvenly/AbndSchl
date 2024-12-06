using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PasswordEnterHandler:MonoBehaviour {
    public Gameobject target;
    public string eventName1;
    public string passcode;
    public GUIHandler1 life;
    private bool showcode = false;
    private bool correctcode = false;
    private bool dontanim = false;
    private bool wrongcode = false;

    void Start(){
        life=Gameobject.FindGameObjectWithTag("TimeLeft").GetComponent<GUIHandler1>();
    }

    void OnTriggerStay(Collider other){
        showcode = true;
        if(Input.GetKeyDown("e")){
            if(passcode==true&&dontanim==false){
                iTweenEvent.GetEvent(target,eventName1).Play();
                correctcode = true;
                dontanim = true;
            }
            else{
                wrongcode = true;
                life.life-= 1;
            }
        }
    }
    void OnTriggerExit(Collider other){
        showcode = false;
        wrongcode = false;
    }
    void OnGUI(){
        if(showcode==true&&correctcode==false){
            GUI.Label(new Rect(600,120,300,100),"Please Enter the Correct Code Below to open the door (Use tab or mouse click to switch between column) and Press 'E' to Confirm");
            code1=GUI.TextField(new Rect(600,170,30,20),code1,1);
            code2=GUI.TextField(new Rect(600,190,30,20),code2,1);
            code3=GUI.TextField(new Rect(600,210,30,20),code3,1);
            code4=GUI.TextField(new Rect(600,230,30,20),code4,1);
        }
        if(wrongcode==true){
            GUI.Label(new Rect(400,520,200,50),"You have entered wrong code, try to find other clue to get the code")
        }
    }
}
