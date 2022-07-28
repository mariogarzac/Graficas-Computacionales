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
    private bool isSelected;
    private Vector3 rot;
    private Vector3 rotOg;
    private float speedR;
    private Vector3 Vec;
    private float speedV;
    private Vector3 ogVec;
    private float rotCounter;

    // Start is called before the first frame update
    void Start()
    {
        isSelected = false;
        renderer = GetComponent<Renderer>();
        float r = Random.Range(0.3f, 0.9f);
        float g = Random.Range(0.3f, 0.9f);
        float b = Random.Range(0.3f, 0.9f);
        renderer.material.color = new Color(r, g, b);
        highliter = new Color(0.2f, 0.1f, 0.1f);
        oldColor = renderer.material.color;

        rotOg = transform.eulerAngles;
        rot = rotOg;
        ogVec = transform.position;
        Vec = ogVec;

        speedR = 1f;
        speedV = 0.225f;
        rotCounter = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected) {
            if (Vec.z > (ogVec.z - 8)) {
                Vec.z -= 2*speedV;
            } else {
                Vec.z = ogVec.z - 8;
            }

            if (Vec.y < (ogVec.y + 4)) {
                Vec.y += speedV;
            } else {
                Vec.y = ogVec.y + 4;
            }

            if (rotCounter < 10) {
                transform.eulerAngles = new Vector3(-90 + rotCounter, 180, 0);
                rotCounter += speedR;
            } else {
                transform.eulerAngles = new Vector3(-80, 180, 0);
                rotCounter = 10;
            }

        } else if (!isSelected) {
            if (Vec.z < ogVec.z) {
                Vec.z += 2*speedV;
            } else {
                Vec.z = ogVec.z;
            }

            if (Vec.y > ogVec.y) {
                Vec.y -= speedV;
            } else {
                Vec.y = ogVec.y;
            }
            

            if (rotCounter > 0) {
                transform.eulerAngles = new Vector3(-80 - rotCounter, 180, 0);
                rotCounter -= speedR;
            } else {
                transform.eulerAngles = new Vector3(-90, 180, 0);
                rotCounter = 0;
            }
        }
        transform.position = Vec;
    }

    private void OnMouseEnter() {
        renderer.material.color = oldColor + highliter;
        print(renderer.material.color);
        print(oldColor);
    }

    private void OnMouseExit() {
        renderer.material.color = oldColor;
    }

    public void select() {
        isSelected = true;
    }

    public void deSelect() {
        isSelected = false;
    }
}
