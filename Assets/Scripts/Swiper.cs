using UnityEngine;
using System.Collections;

public class Swiper : MonoBehaviour
{
    private Touch initTouch = new Touch();
    public Camera kamera;
    private float rotX = 0;
    private float rotY = 0;
    private Vector3 origRot;

    public float rotSpeed = 0.5f;
    public float dir = -1;

    // Use this for initialization
    void Start()
    {
        origRot = kamera.transform.eulerAngles;
        rotX = origRot.x;
        rotY = origRot.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                initTouch = touch;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                float deltaX = initTouch.position.x - touch.position.x;
                float deltaY = initTouch.position.y - touch.position.y;
                rotX -= deltaY * Time.deltaTime * rotSpeed * dir;
                rotY += deltaX * Time.deltaTime * rotSpeed * dir;
                kamera.transform.eulerAngles = new Vector3(rotX, rotY, 0f);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                initTouch = new Touch();
            }
        }

    }
}
