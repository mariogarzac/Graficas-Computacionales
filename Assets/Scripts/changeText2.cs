using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class changeText2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change(string str) {
        TextMeshProUGUI TextMeshProLable = this.GetComponent<TextMeshProUGUI>();
        TextMeshProLable.text = str;
    }
}
