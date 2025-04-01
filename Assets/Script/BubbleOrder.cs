using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleOrder : MonoBehaviour
{
    public Sprite nabeSprite; // Sprite ของนาเบะ (ลากใส่ใน Inspector)
    private GameObject bubble; // ตัวแปรสำหรับเก็บ Bubble
    private SpriteRenderer bubbleRenderer; // ตัวแปรสำหรับแสดงภาพใน Bubble
    
    
    void Start()
    {
        CreateBubbleWithFood();
    }

      void CreateBubbleWithFood()
    {
        // สร้าง Bubble
        bubble = new GameObject("Bubble");
        bubble.tag = "Bubble"; // กำหนด Tag ให้กับ Bubble
        bubbleRenderer = bubble.AddComponent<SpriteRenderer>();

        // กำหนด Sprite ของ Bubble เป็นนาเบะ
        bubbleRenderer.sprite = nabeSprite;

        // ตั้งตำแหน่ง Bubble (ปรับตำแหน่งตามที่ต้องการ)
        bubble.transform.position = transform.position + new Vector3(0, 2, 0); // Bubble อยู่เหนือหัวลูกค้า

        // ปรับขนาด Bubble (ถ้าจำเป็น)
        bubble.transform.localScale = new Vector3(0.5f, 0.5f, 1f); // ลดขนาด Bubble
    }

     public void ServeFood()
    {
        // เมื่อเสิร์ฟอาหารสำเร็จ ให้ลบภาพใน Bubble
        if (bubbleRenderer != null)
        {
            bubbleRenderer.sprite = null; // ลบภาพใน Bubble
            Debug.Log("เสิร์ฟอาหารสำเร็จ! Bubble ถูกลบแล้ว");
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        // ตรวจสอบการชนกับ Bubble
        if (other.CompareTag("Bubble"))
        {
            Debug.Log("ชนกับ Bubble!");
        }
    }
}
