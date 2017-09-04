using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {
    const int heroTotalHealth = 100;
    private int heroCurrentHealth;

    private void Start()
    {
        heroCurrentHealth = heroTotalHealth;
        //print(string.Format("Hero Health:{0}", heroCurrentHealth));
    }

    private void ShowDamage(int damage)
    {
        heroCurrentHealth -= damage;
        //print(string.Format("Hero Health:{0}", heroCurrentHealth));
        transform.localScale = new Vector3(((float)heroCurrentHealth / (float)heroTotalHealth), 1, 1);
    }
}
