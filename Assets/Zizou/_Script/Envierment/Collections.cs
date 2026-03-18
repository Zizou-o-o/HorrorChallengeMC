using UnityEngine;
public class Collections : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CounterCollection counterCollection = other.GetComponent<CounterCollection>();
        if (counterCollection != null)
        {
            counterCollection.Collected(); 
            gameObject.SetActive(false);
        }
    }
}
