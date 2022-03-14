using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    public GameObject shieldcontroller;
    public float speed;
    public float shieldspeed;
    public GameObject Boss;
    public Transform player;

    public GameObject shield1 = GameObject.Find("shield");
    public GameObject shield2 = GameObject.Find("shield1");    
    public GameObject shield3 = GameObject.Find("shield2");
    public GameObject shield4 = GameObject.Find("shield3");
    public GameObject shield5 = GameObject.Find("shield4");
    public GameObject shield6 = GameObject.Find("shield5");
    public GameObject shield7 = GameObject.Find("shield6");
    public GameObject shield8 = GameObject.Find("shield7");
    

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.3f;
        shieldspeed = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {

        

        if (GameObject.Find("Boss").GetComponent<BossBehaviour>().Stage == 1)
        {
            
            speed = 0.5f;
            shieldcontroller.transform.Rotate(Vector3.up, 45 * speed * Time.deltaTime);
            StartCoroutine(Attack1());


        }
        if (GameObject.Find("Boss").GetComponent<BossBehaviour>().Stage == 2)
        {

            speed = 1f;
            shieldcontroller.transform.Rotate(Vector3.up, 45 * speed * Time.deltaTime);
        }
        else if (GameObject.Find("Boss").GetComponent<BossBehaviour>().Stage == 3)
        {
            speed = 2f;
            shieldcontroller.transform.Rotate(Vector3.up, 45 * speed * Time.deltaTime);
            
        }
        


    }
    IEnumerator Attack1()
    {
        float step = shieldspeed * Time.deltaTime;
        shield1.transform.position = Vector3.MoveTowards(shield1.transform.position, player.position, step);
        
        shield2.transform.position = Vector3.MoveTowards(shield2.transform.position, player.position, step);
        
        shield3.transform.position = Vector3.MoveTowards(shield3.transform.position, player.position, step);
        
        shield4.transform.position = Vector3.MoveTowards(shield4.transform.position, player.position, step);
        
        shield5.transform.position = Vector3.MoveTowards(shield5.transform.position, player.position, step);
        
        shield6.transform.position = Vector3.MoveTowards(shield6.transform.position, player.position, step);
        
        shield7.transform.position = Vector3.MoveTowards(shield7.transform.position, player.position, step);
        
        shield8.transform.position = Vector3.MoveTowards(shield8.transform.position, player.position, step);
        yield return new WaitForSeconds(5);

    }
}
