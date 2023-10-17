using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class nomeEta : MonoBehaviour
{
    public string name;
    public string eta;
    public GameObject inputFieldNome;
    public GameObject inputFieldEta;
    //public GameObject textDispay;

    public void inserisciNome(){
        name=inputFieldNome.GetComponent<Text>().text;
        eta=inputFieldEta.GetComponent<Text>().text;

        //textDispay.GetComponent<Text>().text=" Benvenuto/a "+name+" in SAFE NET!";
        
    }

    public void bt_continue(){
        SceneManager.LoadScene("spiegazioneGioco");
    }
    public void bt_back(){
        SceneManager.LoadScene("main menu");
    }


}
