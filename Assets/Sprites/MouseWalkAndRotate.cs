using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWalkAndRotate : MonoBehaviour
{
    public float speed = 5f; // ปรับความเร็วตามต้องการ

    void Update()
    {
        // ตรวจสอบว่าปุ่มเมาส์ซ้ายถูกคลิก
        if (Input.GetMouseButtonDown(0))
        {
            WalkAndRotateLeft();
        }

        // ตรวจสอบว่าปุ่มเมาส์ขวาถูกคลิก
        else if (Input.GetMouseButtonDown(1))
        {
            WalkAndRotateRight();
        }
    }

    void WalkAndRotateLeft()
    {
        // ขยับไปทางซ้าย
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // หันไปทางซ้าย
        transform.localScale = new Vector3(-2, 2, 2);
    }

    void WalkAndRotateRight()
    {
        // ขยับไปทางขวา
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // หันไปทางขวา
        transform.localScale = new Vector3(2, 2, 2);
    }
}
