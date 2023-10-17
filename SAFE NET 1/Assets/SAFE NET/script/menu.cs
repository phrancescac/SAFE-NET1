using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public void bt_play(){
        SceneManager.LoadScene("iniziogioco");
    }

    public void bt_impostazioni(){
        SceneManager.LoadScene("impostazioni");
    }


    public void bt_guida(){
        SceneManager.LoadScene("guida");

    }

    public void bt_exit(){
        Application.Quit();
        Debug.Log("Chiusura del gioco");
    }

}
