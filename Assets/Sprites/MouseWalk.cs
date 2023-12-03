using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWalk : MonoBehaviour
{
    public float speed = 5f; // ปรับความเร็วตามต้องการ

    void Update()
    {
        // ตรวจสอบว่าปุ่มเมาส์ซ้ายถูกคลิก
        if (Input.GetMouseButton(0))
        {
            WalkLeft();
        }

        // ตรวจสอบว่าปุ่มเมาส์ขวาถูกคลิก
        else if (Input.GetMouseButton(1))
        {
            WalkRight();
        }
    }

    void WalkLeft()
    {
        // ขยับไปทางซ้าย
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void WalkRight()
    {
        // ขยับไปทางขวา
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
