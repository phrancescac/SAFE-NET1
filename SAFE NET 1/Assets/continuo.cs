using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuo : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity= Vector3.zero;

    // Update is called once per frame
    public void Update()
    {
        transform.position=Vector3.SmoothDamp(transform.position, new Vector3(currentPosX,transform.position.y,transform.position.z),ref velocity,speed*Time.deltaTime);
    }

    public void Move(Transform continuo){
        currentPosX=continuo.position.x;
    }
}
