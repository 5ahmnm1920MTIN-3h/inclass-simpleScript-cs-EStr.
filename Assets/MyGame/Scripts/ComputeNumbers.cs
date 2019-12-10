using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public InputField ipMinuend;
    public InputField ipSubtrahend;
    public Text result;

    float a;
    float b;

    // Start is called before the first frame update
    void Start()
    {
        SetResult();
    }

    public void SetResult()
    {
        float a = float.Parse(ipMinuend.text);
        float b = float.Parse(ipSubtrahend.text);
        Debug.Log("in Result" + (a - b));
    }

    public float SubtractNumbers(float minuend, float subtrahend)
    {
        float result = minuend - subtrahend;
        return result;
    }
}
