using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bt_continua_back : MonoBehaviour
{
     public void bt_continue(){
        SceneManager.LoadScene("livelli");
    }
    public void bt_back(){
        SceneManager.LoadScene("iniziogioco");
    }

}
