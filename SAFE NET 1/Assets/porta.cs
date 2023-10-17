using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta : MonoBehaviour
{
    [SerializeField] public Transform ground;
    [SerializeField] public Transform ground1;
    [SerializeField] private continuo cam;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag=="player"){
            if(collision.transform.position.x<transform.position.x){
                cam.Move(ground1);
            }else{
                cam.Move(ground);
            }
        }
    }

}
