//Nombre:Diego Manuel Salas-GDGS2101
//Feha:30/09/22
//Descripcion:Este archivo sirve para crear una variable y un if para que se puedan crear 
//pelotas de todos los tipos y tambien poner un intervalo de tiempo para que se creen
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
    //esto servira para que lagan las pelotas diferenetes y no solo de un tipo 
        // instantiate ball at random spawn location
        int ballNumber = Random.Range(0,ballPrefabs.Length);
        Instantiate(ballPrefabs[ballNumber], spawnPos, ballPrefabs[ballNumber].transform.rotation);
        Invoke("SpawnRandomBall", Random.Range(2f, 4f));
    }

}
