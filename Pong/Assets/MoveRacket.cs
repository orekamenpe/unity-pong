using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    public float speed = 30;
    public string axis = "Vertical";

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

	void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);
        rigidBody.velocity = new Vector2(0, v) * speed;
    }
}
