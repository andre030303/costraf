using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocet : MonoBehaviour
{
    [SerializeField] private float speed = 3f;//скорость ракеты
	[SerializeField] private int lives = 3;//жизни ракеты
	
	private SpriteRenderer sprite;
	
	private void Awake()
	{
		sprite=GetComponentInChildren<SpriteRenderer>();
	}

	private void Update()
	{
		if (Input.GetButton("Horizontal"))
			Run();
	}

	private void Run()
	{
		Vector3 dir=transform.right*Input.GetAxis("Horizontal");

		transform.position=Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
	}
}