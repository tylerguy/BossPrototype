using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject projectile;

    public float speed = 20;
    public static float distFromCam = 2.0f;

    public Vector3 firePosition = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, distFromCam + 3.0f)); // 3D point at screen center, 3 units ahead hand
    public Vector3 handPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distFromCam));

    public int shootForce = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Debug.DrawLine(handPosition, firePosition, Color.green);
        }
        if (Input.GetMouseButtonUp(0)) // shoot in last aimed direction when button released
        {
            Vector3 projDir = firePosition - handPosition; // calculate the projectile direction
                                                           // calculate rotation to turn projectile's forward direction to the shooting direction
            Quaternion rot = Quaternion.FromToRotation(Vector3.forward, projDir);
            // create the projectile in a variable to access its rigidbody...
            GameObject newprojectile = Instantiate(projectile, handPosition, rot);
            // then add force in the projectile's forward direction
            newprojectile.AddComponent<Rigidbody>().AddForce(projectile.transform.forward * shootForce);

            Destroy(newprojectile, 10); // destroy projectile after 10 seconds
        }
    }
}
