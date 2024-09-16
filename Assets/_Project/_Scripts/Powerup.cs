using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : Projectile
{
    protected override void OnCollisionEnter2D(Collision2D other)
    {
        base.OnCollisionEnter2D(other);
        var ship = other.collider.GetComponent<PlayerShip>();

        if (ship == null )
        {
            return;
        }
        ship.activatepowerup();
    }

}
