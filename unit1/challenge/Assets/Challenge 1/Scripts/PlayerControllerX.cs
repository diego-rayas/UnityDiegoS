//Autor:Diego Manuel Salas Rayas Grupo:GDGS2101
//Fecha:28/09/22
//Descripcion:Este archivo sirve para dar el funcionamiento al avion y como se debe de mover
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    //variable para que el avion rote
    public float rotationSpeed;
    //variable para avanzar
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // mover verticalmente
        verticalInput = Input.GetAxis("Vertical");

        // velocidad para moverse
        transform.Translate(Vector3.forward * speed*Time.deltaTime);

        // darle movimiento de arriba y abajo al avion
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput* Time.deltaTime);
    }
}
