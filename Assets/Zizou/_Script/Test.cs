using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject Enemy
        ;
    private void OnTriggerEnter(Collider other)
    {
        Enemy.SetActive(true);
    }
}
