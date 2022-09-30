//Nombre:Diego Manuel Salas Rayas-GDGS2101
//Fecha:29/09/22
//Descripcion:Sirve para que se colisonen los objetos
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider othrt)
    {
        Destroy(gameObject);
        Destroy(othrt.gameObject);
    }
}
