using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //clase
    //tipo de dato, nombre <-- variable

    //objeto a spawnear
     public GameObject objectToSpawn;

    //coordenadas, variable para guardar 3 numeros <-- vector
     Vector3 spawnPoint = new Vector3(0, 0 , 0);

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, spawnPoint, Quaternion.Euler(5, 7, 8));
        }
    }
}
