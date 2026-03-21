using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public AudioClip footStepSFX;
    private PlayerMovment Movment;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Movment = GetComponent<PlayerMovment>();
        StartCoroutine(PlayFootStep());
        
    }

    IEnumerator PlayFootStep()
    {
        while (true) 
        {
            if (Movment.move.magnitude > 0.1f)
            {
                AudioManager.instance.PlaySFX(footStepSFX);
            }
        }

        yield return new WaitForSeconds(0.35f);
    }

}
