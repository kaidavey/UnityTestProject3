using UnityEngine;
using UnityEngine.InputSystem;

public class Hexagon : MonoBehaviour
{
    float movementX;
    float movementY;
    [SerializeField] float speed = 5.0f;

    [SerializeField] Rigidbody2D rb;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();
        Debug.Log(v);

        movementX = v.x;
        //movementY = v.y;
    }

    void FixedUpdate()
    {
        float XmoveDistance = movementX * speed * Time.fixedDeltaTime;
        //float YmoveDistance = movementY * speed * Time.fixedDeltaTime;
        //transform.position = new Vector2(transform.position.x + XmoveDistance, transform.position.y + YmoveDistance);

        rb.linearVelocityX = XmoveDistance;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

}
