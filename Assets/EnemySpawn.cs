using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float speed;
    private float xEnemy;
    private float yEnemy;
    private Vector3 randomSpawn;
    public bool canInstantiate;

    void Start()
    {

    }


    void Update()
    {
        xEnemy = randomSpawn.x;
        yEnemy = randomSpawn.y;

        randomSpawn = new Vector3 (xEnemy, yEnemy);
    }

}
