using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Newbullet : Projectile
{
    public Transform Seeyou;
    public Transform Bruh;


    public override void Move(Vector2 upDirection)
    {
        base.Move(upDirection);
        
        upDirection = Seeyou.position - Bruh.position;

        upDirection.Normalize();
    }
   
        


    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if (other.CompareTag ("Player") && other.CompareTag("Bounds"))
        {
            Destroy(gameObject);
        }
    }

}

