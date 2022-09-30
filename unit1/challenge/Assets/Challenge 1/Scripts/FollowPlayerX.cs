//Autor:Diego Manuel Salas Rayas Grupo:GDGS2101
//Fecha:28/09/22
//Descripcion:Este es el de la camara sirve para que la camara siga al jugador
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30,0,10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //pone a una distancia la camara par que siga al avion
        transform.position = plane.transform.position + offset;
    }
}
