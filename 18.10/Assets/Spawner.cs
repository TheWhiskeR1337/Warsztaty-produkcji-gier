using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Spawn = 2;
        void Start()
    {
        Scheduler.instance.Schedule(3, ()=>
        {
            Spawn();
        }
        );
    }
    void Spawn()
    {
        var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
