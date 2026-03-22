using UnityEngine;
using UnityEngine.AI;

public class WeepingAngelAi : MonoBehaviour
{
    [SerializeField] Renderer boundingArea;
    [SerializeField] LayerMask ignorOneCheck;
    [SerializeField] Animation anim;

    NavMeshAgent agent;
    Transform player;

    private bool wasMoving = false;
    private AudioSource audioSource;        

    void Start()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        player = GameObject.Find("FirstPersonPlayer").transform;
        audioSource = GetComponent<AudioSource>(); 
    }

    private bool CanMove()
    {
        if (boundingArea.isVisible)
        {
            return false;
        }
        return true;
    }

    void Update()
    {
        
        if (!agent.isOnNavMesh || !agent.isActiveAndEnabled) return;

        if (CanMove())
        {
            agent.destination = player.position;

            if (!wasMoving)
            {
                audioSource.Play();         
                wasMoving = true;
            }
        }
        else
        {
            agent.destination = this.transform.position;

            if (wasMoving)
            {
                audioSource.Stop();         
                wasMoving = false;
            }
        }
    }
}