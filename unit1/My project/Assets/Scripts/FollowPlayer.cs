//Autor:Diego Manuel Salas Rayas-Grupo:GDGS2101
//Fecha:28/09/2022
//Descripcion:En este archivo se trabajo para que la camara siga al automovil durante el juego
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //gameOcject es el jugador
    public GameObject player;
    private Vector3 offset = new Vector3(0,9,-10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //sirve para que a camare siga al jugador(automovil)
  transform.position = player.transform.position + offset;
    }
}
