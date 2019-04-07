using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public GameObject parent;
    public GameObject prefab;
    public float waitTime = 2f;
    public float projectileSpeed = 8f;

    public Vector3[] directions;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() {
		while (true) {
            yield return new WaitForSeconds(waitTime);
            for (int i=0; i<directions.Length; i++) {
                GameObject projectile = Instantiate(prefab, parent.transform.position, Quaternion.identity);
                projectile.transform.SetParent(parent.transform);
                projectile.GetComponent<Rigidbody2D>().velocity = directions[i] * projectileSpeed;
            }
		}
	}
}
