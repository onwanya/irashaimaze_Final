using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // สำหรับการเปลี่ยนซีน

public class Timeliner : MonoBehaviour
{
    private Slider slider; // ตัวแปรสำหรับเก็บ Slider

    public float fillSpeed = 0.01f; // ความเร็วในการเติม Slider
    private float targetProgress = 0;

    private int servedMenus = 0; // จำนวนเมนูที่เสิร์ฟ
    public int requiredMenus = 4; // จำนวนเมนูที่ต้องเสิร์ฟเพื่อชนะ

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>(); // รับ Slider ที่อยู่ใน GameObject นี้
    }

    // Start is called before the first frame update
    void Start()
    {
        IncrementProgress(0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value > 0)
        {
            slider.value -= fillSpeed * Time.deltaTime; // ลด Slider ตามความเร็วที่กำหนด
        }
        else
        {
            // เมื่อหมดเวลา ตรวจสอบจำนวนเมนูที่เสิร์ฟ
            if (servedMenus >= requiredMenus)
            {
                SceneManager.LoadScene("yousafe"); // เปลี่ยนไปยังซีน YouSave
            }
            else
            {
                SceneManager.LoadScene("gameover"); // เปลี่ยนไปยังซีน GameOver
            }
        }
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value += newProgress; // เพิ่มค่า Progress ของ Slider
    }

    // ฟังก์ชันที่เรียกเมื่อเสิร์ฟเมนูสำเร็จ
    public void ServeMenu()
    {
        servedMenus++;
    }
}
