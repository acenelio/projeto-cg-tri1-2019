using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTwoPositions : MonoBehaviour
{
	public Transform obj = null, pos1 = null, pos2 = null;
	public float speed = 2f;
	public float waitTime = 0.5f;
	Vector3 nextPos;

	void Start () {
		nextPos = pos1.localPosition;
		StartCoroutine(Move());
	}
	
	IEnumerator Move() {
		while (true) {
			if (obj.transform.localPosition == pos1.localPosition) {
				nextPos = pos2.localPosition;
				yield return new WaitForSeconds(waitTime);
			}
			if (obj.transform.localPosition == pos2.localPosition) {
				nextPos = pos1.localPosition;
				yield return new WaitForSeconds(waitTime);
			}
			obj.transform.localPosition = Vector3.MoveTowards(obj.transform.localPosition, nextPos, speed * Time.deltaTime);
			yield return null;
		}
	}

	void OnDrawGizmos() {
		Gizmos.DrawLine(pos1.position, pos2.position);
	}
}
