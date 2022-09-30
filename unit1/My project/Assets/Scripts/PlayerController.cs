//Autor:Diego Manuel Salas Rayas-Grupo:GDGS2101
//Fecha:28/09/2022
//Descripcion:En este archivo se trabajo para que el automovil tenga diferentes funciones como avanzar,frenar y retroceder ademas de poderse mover hacia los lados.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable para la velocidad del auto
    private float speed = 20.0f;
    //variable para mover a los lados
    private float turnSpeed =45.0f;
    private float horizontalInput;
    //variable para frenar y acelerar
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mover auto de rorma horizontal
        horizontalInput=Input.GetAxis("Horizontal");
        //sirve para avanzar y frenar
        forwardInput=Input.GetAxis("Vertical");
       // Mueve el vehiculo para que avance 
       transform. Translate(Vector3.forward*Time.deltaTime*forwardInput*speed);
       //rotar el auto 
       transform.Rotate(Vector3.up, turnSpeed*horizontalInput*Time.deltaTime);
       //transform. Translate(Vector3.right * Time.deltaTime*horizontalInput);
    }
}
