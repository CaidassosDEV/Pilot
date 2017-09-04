using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHero : MonoBehaviour {

    private int damage = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        var healthBar = GameObject.Find("HealthBar").GetComponentsInChildren(typeof(HealthBar));
        healthBar[0].GetComponent(typeof(HealthBar)).SendMessage("ShowDamage", damage);
    }
}
