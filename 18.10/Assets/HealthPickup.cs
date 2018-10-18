using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour , IPickUp
{
    public void Pickup(Character c)
    {
        c.OnPickupEnter(this);
    }
}
