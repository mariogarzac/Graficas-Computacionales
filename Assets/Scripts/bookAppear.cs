using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookAppear : MonoBehaviour
{
    private bool isOpen;
    private Vector3 Vec;
    private float speed;
    private Vector3 ogVec;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
        Vec = transform.localPosition;
        speed = 0.75f;
        ogVec = Vec;
    }

    // Update is called once per frame
    void Update()
    {
        // Vec = transform.localPosition;  
        // Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;  
        // Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;  
        // Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;  
        // transform.localPosition = Vec;  
        
        
        Vec = transform.localPosition;

        if (isOpen) {
            if (Vec.y < (ogVec.y + 130)) {
                Vec.y += speed;
            } else {
                Vec.y = ogVec.y + 130;
            }
        } else {
            if (Vec.y > ogVec.y) {
                Vec.y -= speed;
            } else {
                Vec.y = ogVec.y;
            }
        }

        transform.localPosition = Vec;
    }

    public bool open() {
        isOpen = true;
        return isOpen;
    }

    public bool close() {
        isOpen = false;
        return isOpen;
    }
}
