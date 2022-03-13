using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public int Stage;
    public float BaseDamage = 0.05f;
    public int DamageModifier;
    public float Damage;

    // Start is called before the first frame update
    void Start()
    {
        Stage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Stage == 1)
        {
            DamageModifier = 1;
            Damage = BaseDamage * DamageModifier;
        }
        else if (Stage == 2)
        {
            DamageModifier = 10;
            Damage = BaseDamage * DamageModifier;
        }
        else if (Stage == 3)
        {
            DamageModifier = 25;
            Damage = BaseDamage * DamageModifier;
        }       
    }
}
