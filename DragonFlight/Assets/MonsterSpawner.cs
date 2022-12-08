using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject Meteor;
    public GameObject Target;
    public List<GameObject> mob = new List<GameObject>();

    float time = 0f;
    float lasttime = 0f;

    void Start()
    {
        MeteorSpawn();
    }

   void Update()
    {
        time += Time.deltaTime;

        if(time >= lasttime + 3)
        {
            Instantiate(Meteor, Target.transform.position, transform.rotation);
            Monster1Spawn();
            lasttime = time;
        }
    }

    void MeteorSpawn()
    {

    }

    void Monster1Spawn()
    {
        switch(Random.Range(0, 2))
        {
            case 0: Instantiate(mob[Random.Range(0, 4)], new Vector3(-2.0f, 6, 0), transform.rotation); break;
            case 1: break;
        }
        switch (Random.Range(0, 2))
        {
            case 0: Instantiate(mob[Random.Range(0, 4)], new Vector3(-0.7f, 6, 0), transform.rotation); break;
            case 1: break;
        }
        switch (Random.Range(0, 2))
        {
            case 0: Instantiate(mob[Random.Range(0, 4)], new Vector3(0.7f, 6, 0), transform.rotation); break;
            case 1: break;
        }
        switch (Random.Range(0, 2))
        {
            case 0: Instantiate(mob[Random.Range(0, 4)], new Vector3(2.0f, 6, 0), transform.rotation); break;
            case 1: break;
        }
    }
}