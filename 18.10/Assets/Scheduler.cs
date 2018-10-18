using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Scheduler : MonoBehaviour {

	public static Scheduler instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }
    public void Schedule (float delay, Action action)
    {
        var cor = RunDelay(delay, action);
        StartCoroutine(cor);
    }

    IEnumerator RunDelay (float delay, Action action)
    {
        yield return new WaitForSeconds(delay);
        action();
    }


}


