using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject cubePrefab;
    private int timer = 10;
    Touch touch;
    Vector2 originalPosition;
    Vector2 finalPosition;
    float angle;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                Vector2 direction = Input.touches[0].deltaPosition.normalized;
                //originalPosition = touch.position;
                cubePrefab.GetComponent<Movement>().ChangeDir(direction);
            }
           // if(touch.phase == TouchPhase.Ended)
           // {
            //    finalPosition = touch.position;
            //    GetDirection(originalPosition, finalPosition);
           // }
        }
    }

    //void GetDirection(Vector2 start, Vector2 end)
    //{
    //    angle = Vector2.Angle(start, end);
    //    cubePrefab.GetComponent<Movement>().ChangeDir(angle);
    //}
}
