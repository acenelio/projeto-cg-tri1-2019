using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTouch : MonoBehaviour
{
    public float lerpRate = 4f;
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Vector3 aux = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 initialPosition = transform.position;
            Vector3 finalPosition = new Vector3(aux.x, transform.position.y, transform.position.z);

            transform.position = Vector3.Lerp(initialPosition, finalPosition, lerpRate * Time.deltaTime);
        }
    }
}
