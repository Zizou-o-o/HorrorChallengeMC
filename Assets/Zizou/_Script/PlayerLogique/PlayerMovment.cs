using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController controlle;
    public float speed = 12f;
    private float verticalVelocity = 0f;
    private float gravity = -9.81f;
    private AudioSource audioSource;
    public Transform angelTransform;
    public float dangerDistance = 10f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        // Gravity
        if (controlle.isGrounded)
        {
            verticalVelocity = -1f;
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;
        }

        move.y = verticalVelocity;
        controlle.Move(move * speed * Time.deltaTime);

        // Footstep sound
        bool isMoving = (x != 0 || z != 0) && controlle.isGrounded;
        if (isMoving)
        {
            SoundManager.Instance.PlayFootstep(audioSource);
        }
        else
        {
            // stops sound when player stops
            audioSource.Stop();             
        }

        // Heartbeat sound plays when angel is close
        if (angelTransform != null)
        {
            float dist = Vector3.Distance(transform.position, angelTransform.position);
            if (dist < dangerDistance)
                SoundManager.Instance.PlayHeartbeat();
            else
                SoundManager.Instance.StopHeartbeat();
        }
    }
}