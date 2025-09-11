using UnityEngine;
public class ControlFlow : MonoBehaviour
{
    public bool flag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (flag == true)
        {
            Debug.Log("Boolean flag is set");
        }
        else
        {
            Debug.Log("Boolean flag isn't set");
        }
        for (int i = 0; i < 10; i++)
        {
            float Result;
            Result = Mathf.Pow(2, i);
            Debug.Log("The " + i + " power of " + 2 + " is " + Result);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
