using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightEffect : MonoBehaviour
{

    Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        InvokeRepeating("FlickerLights", 0.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FlickerLights() {
        myLight.intensity = Random.Range(1.48f, 1.53f);
    }
}
