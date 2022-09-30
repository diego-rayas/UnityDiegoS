//Nombre:Diego Manuel Salas Rayas-GDGS2101
//Fecha:29/09/22
//Descripcion:Este archivo sirve para que se eliminen las cosas que se salen del rango que se delimitara
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    //variiables para los rangos y despues eliminar si salen de estos
 private float topBound = 30;
 private float lowerBound = -12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //servira para eliminar el alimento
        if (transform.position.z > topBound){
            Destroy(gameObject);
        }else if (transform.position.z < lowerBound){
            Debug.Log("Game Over! Pérdiste =(");
            Destroy(gameObject);
        }
    }
}
