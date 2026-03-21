using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController controlle;
    public float speed = 12f;
    private float verticalVelocity = 0f;
    private float gravity = -9.81f;
    public Vector3 move;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        move = transform.right * x + transform.forward * z;

        // Gravity
        if (controlle.isGrounded)
        {
            verticalVelocity = -1f; // keeps grounded
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime; // falls down
        }

        move.y = verticalVelocity;
        controlle.Move(move * speed * Time.deltaTime);
    }
}
