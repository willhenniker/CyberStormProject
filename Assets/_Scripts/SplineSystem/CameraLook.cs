/* Will Henniker
 * Tutorial followed: http://catlikecoding.com/unity/tutorials/curves-and-splines/
 * 
 * last change: 14/3/2016
 */
using UnityEngine;
using System.Collections;

public class CameraLook : MonoBehaviour {

	public Transform target;
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
	}
}
