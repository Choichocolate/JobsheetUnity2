using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    private InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
    }

    public void PrintNewValue()
    {
        string msg = "New Content = '" + inputField.text + "'";
        print(msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
