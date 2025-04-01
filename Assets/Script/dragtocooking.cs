using System.Collections.Generic;
using UnityEngine;

public class dragtocooking : MonoBehaviour
{
    public List<GameObject> ingredients; // รายการวัตถุดิบทั้งหมด
    public List<GameObject> potIngredients; // วัตถุดิบที่อยู่ในหม้อ
    public GameObject finishedDish; // Sprite อาหารที่เสร็จแล้ว
    public List<string> correctIngredients; // รายการชื่อวัตถุดิบที่ถูกต้อง

    private void Start()
    {
        potIngredients = new List<GameObject>();
        finishedDish.SetActive(false); // ซ่อนอาหารที่เสร็จแล้วในตอนเริ่มต้น
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("aaaaaaaaaaCollision with: " + collision.gameObject.name); // แสดงชื่อวัตถุดิบที่ชน
        // ตรวจสอบว่าชนกับวัตถุดิบที่สามารถใส่ในหม้อได้หรือไม่
        // เมื่อวัตถุดิบถูกลากเข้าไปในหม้อ
        if (ingredients.Contains(collision.gameObject))
        {
            potIngredients.Add(collision.gameObject);
            collision.gameObject.SetActive(false); // ซ่อนวัตถุดิบที่ใส่ในหม้อ
            CheckIngredients();
        }
    }

    private void CheckIngredients()
    {
        // ตรวจสอบว่ามีวัตถุดิบตรงกับเงื่อนไขหรือไม่
        int matchCount = 0;
        foreach (GameObject ingredient in potIngredients)
        {
            if (correctIngredients.Contains(ingredient.name))
            {
                matchCount++;
            }
        }

        if (matchCount == 3) // ถ้าตรงเงื่อนไข 3 อย่าง
        {
            finishedDish.SetActive(true); // แสดงอาหารที่เสร็จแล้ว
            ClearPot();
        }
    }

    private void ClearPot()
    {
        // ลบวัตถุดิบทั้งหมดในหม้อ
        foreach (GameObject ingredient in potIngredients)
        {
            Destroy(ingredient);
        }
        potIngredients.Clear();
    }
}
