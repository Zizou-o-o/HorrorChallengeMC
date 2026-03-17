using UnityEngine;
using UnityEngine.AI;

public class WeepingAngelAi : MonoBehaviour
{
    [SerializeField] Renderer boundingArea;
    [SerializeField] LayerMask ignorOneCheck;
    [SerializeField] Animation anim;

    NavMeshAgent agent;
    Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        player = GameObject.Find("FirstPersonPlayer").transform;
    }
    private bool CanMove()
    {
        if (boundingArea.isVisible)
        {
            return false;
        }
        return true;
    }
    // Update is called once per frame
    void Update()
    {
            if (CanMove())
            {
                agent.destination = player.position;
            }
            else
            {
                agent.destination = this.transform.position;
            }
    }
}