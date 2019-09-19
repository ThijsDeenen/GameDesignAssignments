using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 direction;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * 5);
    }

    public void ChangeDir(Vector2 angle)
    {
        //float radian = angle * Mathf.Rad2Deg;
        direction = angle;
    }
}
