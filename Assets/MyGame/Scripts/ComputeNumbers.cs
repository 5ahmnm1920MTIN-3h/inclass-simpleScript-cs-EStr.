using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public InputField ipMinuend;
    public InputField ipSubtrahend;
    public Text resulT;

    float varMinuend;
    float varSubtrahend;

    // Start is called before the first frame update
    void Start()
    {
        SetResult();
        varMinuend = 0;
        varSubtrahend = 0;
    }

    public void SetResult()
    {
        varMinuend = float.Parse(ipMinuend.text);
        varSubtrahend = float.Parse(ipSubtrahend.text);
        Debug.Log("in Result" + (varMinuend - varSubtrahend));
    }

    public float SubtractNumbers(float minuend, float subtrahend)
    {
        float result = minuend - subtrahend;
        return result;
    }
}
