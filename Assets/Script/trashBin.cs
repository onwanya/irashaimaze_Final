using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour
{
    // กำหนดตำแหน่ง X และ Y ของถังขยะ
    public float trashBinX = 18f;
    public float trashBinY = -5f;

    // กำหนดระยะที่อนุญาตให้วัตถุถูกทำลาย (Tolerance)
    public float tolerance = 0.5f;

    private void Update()
    {
        // ค้นหา GameObjects ทั้งหมดใน Scene
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        foreach (var obj in allObjects)
        {
            // ตรวจสอบว่าตำแหน่งของวัตถุอยู่ในช่วงที่กำหนด
            if (Mathf.Abs(obj.transform.position.x - trashBinX) <= tolerance &&
                Mathf.Abs(obj.transform.position.y - trashBinY) <= tolerance)
            {
                // ทำลายวัตถุ
                Destroy(obj);
                Debug.Log($"Destroyed {obj.name} at position {obj.transform.position}");
            }
        }
    }

}
