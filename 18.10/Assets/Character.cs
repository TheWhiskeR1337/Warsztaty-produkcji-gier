using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    public int Health, Ammo, Immortality;
    public bool IsInvincible;
	public void OnPickupEnter (AmmoPickup ammo)
    {
        Ammo += 20;
    }
    public void OnPickupEnter(HealthPickup health)
    {
        Health += 20;
    }

    public void OnPickupEnter(PowerPickup immortality)
    {
        IsInvincible = true;
        Immortality = 1;

        Scheduler.instance.Schedule(5, () => IsInvincible = false);
        Scheduler.instance.Schedule(5, () => Immortality = 0);
    }

    void OnTriggerEnter(Collider collider)
    {
        var pickup = collider.GetComponent<IPickUp>();
        if (pickup != null)
        {
            pickup.Pickup(this);
        }
    }
}
