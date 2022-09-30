//Nombre:Diego Manuel Salas-GDGS2101
//Feha:30/09/22
//Descripcion:Este archivo sirve para poner rango para que las bolas y los perros se eliminen despues de pasar el rango
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
   //variables para os rngos
    private float leftLimit = -30;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        //Destruir los perros si pasan este rango
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
