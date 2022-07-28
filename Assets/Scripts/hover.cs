using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour
{
    private Renderer renderer;
    private Color oldColor = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        oldColor = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter() {
        renderer.material.color = Color.white;
    }

    private void OnMouseExit() {
        renderer.material.color = oldColor;
    }
}
