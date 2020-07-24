using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//obsługa gracza
public class PlayerController : MonoBehaviour 
{

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;//typ komponent
	private int count;


	void Start()
	{
		//na rzecz obiektu rb pobieram komponent ciało_fizyczne
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate()
	{

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		//definicja nowego wektora
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		//przypisuje obiektowi rb siłę
		rb.AddForce (movement*speed);
	}

	//zbieranie sześcianów
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("gracz")) 
		{
			other.gameObject.SetActive(false);
			count=count+1;
			SetCountText();

		}
	}

	//wyświetlanie zliczonych sześcianów
	//wyświetlenie Win!
	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 8) 
		{
			winText.text="YOU WIN!";
		}
	}

}
