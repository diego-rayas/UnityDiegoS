//Nombre:Diego Manuel Salas Rayas-GDGS2101
//Fecha:29/09/22
//Descripcion:Este documento sirve para darle movimiento y jugabilidad al player
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable para poder mover el player Horizontalmente
    public float horizontalInput;
    //variable para rangos donde se puede mover el player a los lados 
    public float xRange = 20;
    //variable mover a los lados 
    public float speed = 10.0f;
    //variable para los prefab del alimento 
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //el if servira para poner un rango donde el layer se puedamover a los lados 
        if (transform.position.x < -xRange) {
             transform.position= new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) {
             transform.position= new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontalInput * Time.deltaTime*speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Lanzar un proyectil desde el reproductor
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
