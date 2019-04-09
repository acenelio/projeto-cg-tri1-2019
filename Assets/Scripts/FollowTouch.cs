using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTouch : MonoBehaviour
{
    public GameObject particle;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 aux = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 pos = new Vector3(aux.x, aux.y, 0f);
            Instantiate(particle, pos, transform.rotation);
        }
    }
}
