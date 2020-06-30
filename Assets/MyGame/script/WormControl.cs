﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormControl : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode downKey;
    public KeyCode fowardKey;
    public KeyCode backKey;
    public KeyCode shootKey;
    public UnityEngine.Rigidbody rb;
    public Vector3 vecJump;
    public Vector3 vecForward;
    public Vector3 af;

    public GameObject gun;
  



    // Update is called once per frame
    public GameObject projectile;
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Debug.Log("Jump taste wurde gedrückt");
            rb.AddForce(vecJump);
        }

        if (Input.GetKeyDown(downKey))
        {
            Debug.Log("Jump taste wurde gedrückt");
            rb.AddForce(-vecJump);
        }
        if (Input.GetKeyDown(fowardKey))
        {
            Debug.Log("Forwärts taste wurde gedrückt");
            rb.AddForce(vecForward);
        }

        if (Input.GetKeyDown(backKey))
        {
            Debug.Log("Zurück taste wurde gedrückt");
            rb.AddForce(-vecForward);
        }


        if (Input.GetKeyDown(shootKey))s
        {
            // Vector3 gunpos = gun.transform.position;

              GameObject forcegun = Instantiate(projectile, gun.transform.position, gun.transform.rotation);
              Rigidbody rb = forcegun.GetComponent<Rigidbody>();
              rb.AddForce(af);

            //Instantiate(projectile, gun.transform.position, gun.transform.rotation);
        }

    }
}