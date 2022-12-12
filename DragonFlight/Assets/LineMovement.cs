using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMovement : MonoBehaviour
{
	public GameObject target;
	public GameObject meteor;

	public float speed = 0f;
	private float timer = 0f;

    void Start()
    {
    }

    void Update()
	{
		// 타겟을 향해서 이동

		timer += Time.deltaTime;
		if(timer >= 3f)
        {
			Instantiate(meteor, new Vector3(transform.position.x, 6, 0), transform.rotation);
			timer = 0f;
			Destroy(gameObject);
        }
	}
}