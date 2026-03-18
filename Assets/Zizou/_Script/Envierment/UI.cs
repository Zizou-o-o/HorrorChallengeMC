using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    private TextMeshProUGUI CollectText;

    void Start()
    {
        CollectText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(CounterCollection counterCollection)
    {
        CollectText.text = counterCollection.NumberOFCollect.ToString();
    }
}
