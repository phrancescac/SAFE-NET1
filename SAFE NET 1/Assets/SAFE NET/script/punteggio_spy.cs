using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class punteggio_spy : MonoBehaviour
{
 
    public Text scoreText;
    static private int score=0;
    public Text tentativoText;
    private int tentativi=0;
     public bool cliccato=false;
     public bool cliccato1=false;
     public bool cliccato2=false;

    static public int punteggioTot=0;
    public Text puntTotText; 

   
    public void bt_giusto(){
        
        if(!cliccato){
            score++;
            scoreText.text=score.ToString();
            cliccato=true;
            punteggioTot++;
        }else if(cliccato==false){
            Debug.Log("Hai già scovato l'hacker in questa finestra.");
        }
       
        tentativi++;
        tentativoText.text=tentativi.ToString();
        
        
        /*if(score==3){
            SceneManager.LoadScene("victory_spyware");
        }*/
        score=0;
       
       caricaScena();

        
    }
    public void bt_giusto1(){
        
        if(!cliccato1){
            score++;
            scoreText.text=score.ToString();
            cliccato1=true;
            punteggioTot++;
        }else if(cliccato1==false){
            Debug.Log("Hai già scovato l'hacker in questa finestra.");
        }
        tentativi++;
        tentativoText.text=tentativi.ToString();
        
        /* if(score==3){
            SceneManager.LoadScene("victory_spyware");
        }*/
        score=0;
       caricaScena();
     

        
    }
        public void bt_giusto2(){
        
        if(!cliccato2){
            score++;
            scoreText.text=score.ToString();
            cliccato2=true;
            punteggioTot++;

        }else if(cliccato2==false){
            Debug.Log("Hai già scovato l'hacker in questa finestra.");
        }
        tentativi++;
        tentativoText.text=tentativi.ToString();
        score=0;
        
          
        /* if(score==3){
            SceneManager.LoadScene("victory_spyware");

        }*/   
       caricaScena();
       
    }

    public void caricaScena(){

        
        if (score>=3){
            SceneManager.LoadScene("victory_spyware");
            scoreText.text=score.ToString();
        }
    }


    public void bt_sbagliato(){
        tentativi++;
        tentativoText.text=tentativi.ToString();
        
        if(tentativi>=4){
            SceneManager.LoadScene("gameover_spyware");
        }
        score=0;
    }

}
