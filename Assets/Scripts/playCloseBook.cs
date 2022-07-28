using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playCloseBook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playClose() {
        this.GetComponent<AudioSource>().Play();
    }
}
