//Nombre:Diego Manuel Salas-GDGS2101
//Feha:30/09/22
//Descripcion:Sirve para poner un limite que solo 1 perro se pueda estar activo y no se pueda crear otro hasta que este se destruya
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 1;
        }
        if (cooldown >=0){
            cooldown-= Time.deltaTime;
        }
    }
}
