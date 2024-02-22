using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cubo : MonoBehaviour
{
    // Start is called before the first frame update
    public int puntos;
    public Text TextoPuntos;
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c){
        Debug.Log("choque tipo trigger");
        puntos++;
        TextoPuntos.text = puntos.ToString();
    }
}
