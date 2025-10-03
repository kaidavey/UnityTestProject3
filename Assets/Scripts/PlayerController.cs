using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    float movementX;
    float movementY;
    float speed = 5.0f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
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
        movementY = v.y;
    }

    void FixedUpdate()
    {
        float XmoveDistance = movementX * speed * Time.fixedDeltaTime;
        float YmoveDistance = movementY * speed * Time.fixedDeltaTime;
        transform.position = new Vector2(transform.position.x + XmoveDistance, transform.position.y + YmoveDistance);
    }

    /*
    private void OnCollisionEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

    }*/

}
