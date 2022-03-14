using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    private Rigidbody _rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Fire(float speed, Vector3 direction)
    {
        _rb.velocity = direction * speed;
    }   
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
}
