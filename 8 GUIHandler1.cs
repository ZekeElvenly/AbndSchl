using UnityEngine;
using System.Collections;

public class GUIHandler1:MonoBehaviour{
    public float timeLeft;
    private float timeReset;
    private bool showTimeLeft = false;
    private bool showTimeUp = false;
    private bool showFail = false;
    public int life = 4;
    public string objective;
    public string hint;

    void Start(){
        timeReset = timeLeft;
    }

    void Update(){
        timeLeft -= Time.deltaTime;
        if(timeLeft>0){
            showTimeLeft = true;
        }else[
            showTimeLeft = false;
            showTimeUp = false;
            Time.timeScale = 0;
            if(Input.GetKeyDown("e")){
                Time.timeScale = 1;
                showTimeLeft = true;
                showTimeUp = false;
                Reset();
                life-= 1;
            }
        ]
        if(life==0){
            Time.timeScale = 0;
            showTimeLeft = false;
            showFail = true;
            if(Input.GetKeyDown("q")){
                Application.Quit();
            }
        }
    }
    void OnGUI(){
        if(showTimeLeft==true){
            int minutes = Mathf.FloorToInt(timeLeft/60F);
            int seconds = Mathf.FloorToInt(timeLeft-minutes*60);
            string newFormat = string.Format("{0:0}:{1:00}",minutes,seconds);
            GUI.Label(new Rect(600,100,200,100),"Time Left : "+newFormat);           
        }
        if(showTimeUp==true){
            GUI.Label(new Rect(600,100,200,100),"Time's Up");
            GUI.Label(new Rect(600,120,200,100),"Press E to Use the left chance");
        }
        if(showFail==true){
            GUI.Label(new Rect(600,60,200,100),"You have no chance left, Game Over!!");
            GUI.Label(new Rect(600,100,200,100),"Press Q to Quit the Game");
        }
        GUI.Label(new Rect(500,100,200,100),"Chance Left : ");
        for(int i = 0; i < life; i++){
            GUI.Label(new Rect(190+(i*10),500,200,100),"*");
        }
        GUI.Label(new Rect(1000,100,200,100),objective);
        GUI.Label(new Rect(1000,140,200,100),hint);
    }
    void Reset(){
        timeLeft = timeReset;
    }
}
