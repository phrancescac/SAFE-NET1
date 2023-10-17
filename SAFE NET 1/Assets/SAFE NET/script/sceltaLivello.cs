using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceltaLivello : MonoBehaviour
{
    public bool cliccato_spyware=false;
  
    public void bt_sniffing(){
        SceneManager.LoadScene("sniffing");
    }
     public void bt_virus(){
        SceneManager.LoadScene("virus");
    }
     public void bt_spyware(){
              
        if(!cliccato_spyware ){
            SceneManager.LoadScene("spyware");
            cliccato_spyware=true;
        }else {
            SceneManager.LoadScene("Popup");
          
        }
           
    }
     public void bt_fishing(){
        SceneManager.LoadScene("fishing");
    }
     public void bt_troyan(){
        SceneManager.LoadScene("troyan");
    }
}
