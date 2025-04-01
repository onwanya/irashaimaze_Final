using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    public GameObject customerPrefab; // ตัวละครลูกค้า
    public Transform spawnPoint; // จุดเกิดลูกค้า
    public Image orderImage; // ภาพออเดอร์
    public Sprite[] menuSprites; // รูปภาพเมนูอาหาร

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCustomer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCustomer()
    {
        yield return new WaitForSeconds(3f); // รอ 3 วินาที
        
        GameObject customer = Instantiate(customerPrefab, spawnPoint.position, Quaternion.identity);
        customer.SetActive(true);
        
        int randomIndex = Random.Range(0, menuSprites.Length);
        orderImage.sprite = menuSprites[randomIndex]; // แสดงภาพอาหารที่สุ่มได้
        orderImage.gameObject.SetActive(true);
    }
}
