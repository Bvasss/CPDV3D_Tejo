using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool onGround;
    public float fuerza_X;
    public float fuerza_z;
    void Start()
    {
        onGround = false;
        fuerza_X = 0;
        fuerza_z = -600;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Space key was released");
            GetComponent<Rigidbody>().useGravity = true;
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(onGround){
           Vector3 fuerza = new Vector3(fuerza_X,500,fuerza_z);
           GetComponent<Rigidbody>().AddForce(fuerza);
            }
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            fuerza_X = fuerza_X -50;
        }

         if(Input.GetKeyDown(KeyCode.X))
        {
            fuerza_X = fuerza_X +50;
        }

         if(Input.GetKeyDown(KeyCode.A))
        {
            fuerza_z = fuerza_z -0;
        }
    }

private void OnCollisionEnter(Collision c){
    Debug.Log("colision");
    onGround =true;
}

private void OnCollisionStay(Collision c){

    onGround =true;
}

private void OnCollisionExit(Collision c){
    Debug.Log("Libre");
    onGround =false;
}

}