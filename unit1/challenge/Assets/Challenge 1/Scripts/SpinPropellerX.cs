//Autor:Diego Manuel Salas Rayas Grupo:GDGS2101
//Fecha:28/09/22
//Descripcion:Sirve para que lo de adelante del avion de vueltas como un avion real
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float propellorSpeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);        
    }
}
