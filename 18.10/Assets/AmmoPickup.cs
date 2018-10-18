using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour, IPickUp
{
    public void Pickup(Character c)
    {
        c.OnPickupEnter(this);
    }

}
