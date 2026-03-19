using System.Collections;
using UnityEngine;

public class JumpTriger : MonoBehaviour
{
    //public AudioSource scream;
    public GameObject player;
    public GameObject jumpCamera;
    public GameObject flashImg;

    void OnTriggerEnter()
    {
        //scream.Play();
        jumpCamera.SetActive(true);
        player.SetActive(true);
        flashImg.SetActive(true);
        StartCoroutine(EndJump());
    
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(2.3f);
        player.SetActive(true);
        jumpCamera.SetActive(false);
        flashImg.SetActive(false);

    }



}
