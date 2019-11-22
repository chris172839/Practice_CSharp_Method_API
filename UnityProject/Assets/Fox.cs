using UnityEngine;

public class Fox : MonoBehaviour
{
	[Header("移動速度"), Range(1, 50)]
	public int Speed = 20;

	void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Rotate(0, speed, 0);
    }

	private Rigidbody2D rb2D;
	private float thrust = 10.0f;

	void Start()
	{
		rb2D = gameObject.AddComponent<Rigidbody2D>();
		transform.position = new Vector2(0.0f, -2.0f);
	}

	void FixedUpdate()
	{
		rb2D.AddForce(transform.up * thrust);
	}

	public SpriteRenderer flipX();
}
