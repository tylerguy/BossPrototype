using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public int Stage;
    public float BaseDamage = 0.05f;
    public int DamageModifier;
    public float Damage;
    public float speed;
    public float period = 0.0f;
    public bool Stage1Start;
    public bool Stage2Start;
    public bool Stage3Start;
    public Transform target;
    public Transform origintarget;
    public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
        Stage = 1;
        speed = 1;
        Stage1Start = false;


    }

    // Update is called once per frame
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Stage = 1;
            GameObject.Find("Boss Healthbar").GetComponent<EnemyHealthManager>().health = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Stage = 2;
            GameObject.Find("Boss Healthbar").GetComponent<EnemyHealthManager>().health = 0.7f;

        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Stage = 3;
            GameObject.Find("Boss Healthbar").GetComponent<EnemyHealthManager>().health = 0.3f;
        }
        
        if (Stage == 1 || Stage1Start == false)
        {
            DamageModifier = 1;
            Damage = BaseDamage * DamageModifier;
            StartCoroutine(Attack1());
            Stage1Start = true;
        }
        else if (Stage == 2)
        {
            DamageModifier = 10;
            Damage = BaseDamage * DamageModifier;
            StartCoroutine(Attack2());
        }
        else if (Stage == 3)
        {
            DamageModifier = 25;
            Damage = BaseDamage * DamageModifier;
        }       
    }

    IEnumerator Attack1()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        yield return new WaitForSeconds(5);
        
        //yield return new WaitForSeconds(10);
        //StopCoroutine(Attack1());
    }
    IEnumerator Attack2()
    {
        float step = speed * Time.deltaTime;
        float bossspeed = 3f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Player.position, bossspeed);
        transform.LookAt(Player, Vector3.up );
        yield return new WaitForSeconds(5);
    }



}
