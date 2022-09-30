//Nombre:Diego Manuel Salas Rayas-GDGS2101
//Fecha:29/09/22
//Descripcion:Sirve para enviar la comida
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //variable para moverse la comida(ir adelante)
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
