using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject cam;
    public float speed;
    public float clamp;

    private Rigidbody rb;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float playerX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float playerY = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        movement = new Vector3(playerX, 0, playerY);

        Vector2 mousePos = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        transform.Rotate(0, mousePos.x, 0);
    }


    private void FixedUpdate()
    {

        rb.MovePosition(rb.transform.position + movement * speed * Time.deltaTime);
        
    }
}
