using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    public GameObject shieldcontroller;
    public float speed;
    public GameObject Boss;
    public float health = GameObject.Find("Boss Healthbar").GetComponent<EnemyHealthManager>().health;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.3f;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (health <= 0.9f)
        {

            speed = 0.5f;
            shieldcontroller.transform.Rotate(Vector3.up, 45 * speed * Time.deltaTime);

        }
        else if (health <= 0.8f)
        {
            speed = 0.7f;
            shieldcontroller.transform.Rotate(Vector3.up, 45 * speed * Time.deltaTime);
            
        }
        else if (health <= 0.7f)
        {
            speed = 0.9f;
            shieldcontroller.transform.Rotate(Vector3.up, 45 * speed * Time.deltaTime);
            
        }
        


    }
}
