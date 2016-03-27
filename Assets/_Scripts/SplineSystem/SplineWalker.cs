/* Will Henniker
 * Tutorial followed: http://catlikecoding.com/unity/tutorials/curves-and-splines/
 * 
 * last change: 14/3/2016
 */
using UnityEngine;

public class SplineWalker : MonoBehaviour {

	public BezierSpline spline;

	public Transform[] targetArray;

	public Transform target;

	public float Speed;

	private float progress;

	public bool lookForward;

	public SplineWalkerMode mode;

	private bool goingForward = true;
	
	//bool triggered false

	/*private methord , track enemy  
	 * if triggered
	 * add all enimies to an array
	 * find cloest enemy to the player
	 * camera track camera closets 
	 * if no enimie is close 
	 * triggered is false do nothing
	*/

	private void Update() {
			if (goingForward) {
			progress += Time.deltaTime * Speed;
			if (progress > 1f) {
				if (mode == SplineWalkerMode.Once) {
					progress = 1f;
				} else if (mode == SplineWalkerMode.Loop) {
					progress -= 1f;
				} else {
					progress = 2f - progress;
					goingForward = false;
				}
			}
		} else { 
			progress -= Time.deltaTime / Speed;
			if (progress < 0f) {
				progress = -progress;
				goingForward = true;
			}

		}

		Vector3 position = spline.GetPoint (progress);
		//makes sure the player is facing the next part in the spline
		transform.localPosition = position;
		if (lookForward) {
			transform.LookAt(target);
		
		}
	
	}

}