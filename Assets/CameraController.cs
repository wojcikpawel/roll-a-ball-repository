using UnityEngine;
using System.Collections;

//obsługa kamery
public class CameraController : MonoBehaviour {

	public GameObject player;//typ obiekt w Hierarchy
	private Vector3 offset;//typ wektor jest prywatny bo ustawiam jego wartość w skrypcie

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
