using UnityEngine;
using UnityEngine.Events;

public class CounterCollection : MonoBehaviour
{
    public int NumberOFCollect {  get; private set; }
    public UnityEvent<CounterCollection> OnCollected;
    [SerializeField] GameObject winMessage;
    public void Collected()
    {
        NumberOFCollect++;
        OnCollected.Invoke(this);

        if (NumberOFCollect >= 3)
        {
            winMessage.SetActive(true);
        }
    }
}
