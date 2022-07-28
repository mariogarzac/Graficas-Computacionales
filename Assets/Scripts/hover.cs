using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour
{
    private Renderer renderer;
    private Color oldColor = Color.white;
    private Color highliter;
    private float r;
    private float g;
    private float b;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        float r = Random.Range(0.3f, 0.9f);
        float g = Random.Range(0.3f, 0.9f);
        float b = Random.Range(0.3f, 0.9f);
        renderer.material.color = new Color(r, g, b);
        highliter = new Color(0.2f, 0.1f, 0.1f);
        oldColor = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter() {
        renderer.material.color = oldColor + highliter;
        print(renderer.material.color);
        print(oldColor);
    }

    private void OnMouseExit() {
        renderer.material.color = oldColor;
    }
}
