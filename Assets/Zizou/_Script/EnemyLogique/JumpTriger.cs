using UnityEngine;
using System.Collections;

public class JumpTriger : MonoBehaviour
{
    public GameObject player;
    public GameObject jumpCamera;
    public GameObject flashImg;

    void OnTriggerEnter()
    {
        SoundManager.Instance.PlayJumpscare();      
        SoundManager.Instance.StopHeartbeat();     

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
