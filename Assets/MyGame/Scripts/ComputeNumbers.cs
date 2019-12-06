using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;

    float varA;
    float varB;

    // Start is called before the first frame update
    void Start()
    {
        SetResult();
    }

    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        Debug.Log("in Result" + (a + b));

        //result.text = SubtractNumbers(float.Parse(ipVarA.text), float.Parse(ipVarB.text));
    }

    public float SubtractNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
     // Debug.Log("Test" + result.ToString());
        return result;
    }
}
