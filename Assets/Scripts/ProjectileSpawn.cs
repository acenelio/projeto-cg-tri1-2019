using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    GameObject parent;
    public GameObject prefab;
    public GameObject spawnPoint;
    public float waitTime = 2f;
    public float projectileSpeed = 8f;

    public Vector3[] directions;

    void Start()
    {
        parent = GameObject.Find("Tape");
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() {
		while (true) {
            yield return new WaitForSeconds(waitTime);
            for (int i=0; i<directions.Length; i++) {
                GameObject projectile = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
                projectile.transform.SetParent(parent.transform);
                projectile.GetComponent<Rigidbody2D>().velocity = directions[i] * projectileSpeed;
            }
		}
	}
}
