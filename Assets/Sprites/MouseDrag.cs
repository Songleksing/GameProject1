using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void Update()
    {
        // ตรวจสอบว่าปุ่มเมาส์ซ้ายถูกคลิก
        if (Input.GetMouseButtonDown(0))
        {
            StartDragging();
        }

        // ตรวจสอบว่าปุ่มเมาส์ซ้ายถูกปล่อย
        if (Input.GetMouseButtonUp(0))
        {
            StopDragging();
        }

        // ถ้ากำลังลาก
        if (isDragging)
        {
            DragCharacter();
        }
    }

    void StartDragging()
    {
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void StopDragging()
    {
        isDragging = false;
    }

    void DragCharacter()
    {
        // ดึงตำแหน่งเมาส์
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // ทำให้ Z เป็น 0 เพื่อให้ตำแหน่งที่ถูกลากอยู่บนระนาบ

        // ตำแหน่งใหม่ของตัวละคร
        transform.position = mousePosition + offset;
    }
}
