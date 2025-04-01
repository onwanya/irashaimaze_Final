using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Animator animator;
    public GameObject[] Boxopen;

    // Prefab ของวัตถุดิบ (Array สำหรับวัตถุดิบหลายชนิด)
    public GameObject[] ingredientPrefabs;

    void Start()
    {
        
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical);

        AnimateMovement(direction);

        transform.position += direction * speed * Time.deltaTime;
    }

    void AnimateMovement(Vector3 direction)
    {
        if (animator != null)
        {
            if (direction.magnitude > 0)
            {
                animator.SetBool("isMoving", true);

                animator.SetFloat("horizontal", direction.x);
                animator.SetFloat("vertical", direction.y);
            }
            else
            {
                animator.SetBool("isMoving", false);
            }
        }
    }


    public void Button_menu_bt()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("aaaaaaaaaaaaaaaaaaaaaa");
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("CheckHead"))
    //    {
    //        cooking_BT.SetActive(true);
    //    }
    //}

    void OnCollisionEnter2D(Collision2D col)
    {
        // ตรวจสอบว่า Box ใดถูกชน
        for (int i = 0; i < Boxopen.Length; i++)
        {
            if (col.gameObject.CompareTag($"Box_{i + 1:D2}"))
            {
                // ทำให้ Box ที่ชนกันหายไป
                Boxopen[i].SetActive(false);
    //            SpawnIngredient(col.transform.position, i); // สร้างวัตถุดิบที่ตำแหน่งของ Box
                Debug.Log("Position" + col.transform.position);
            }
        }
    }

    //void SpawnIngredient(Vector3 position, int boxIndex)
    //{
    //    if (ingredientPrefabs.Length > 0)
    //    {
          

            // สร้างวัตถุดิบที่ตำแหน่งของ Box
    //        Instantiate(ingredientPrefabs[boxIndex % ingredientPrefabs.Length], position, Quaternion.identity);
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Ingredient Prefabs array is empty!");
    //    }
    //}

    private void OnCollisionExit2D(Collision2D col)
    {
        // ตรวจสอบว่า Box ใดถูกชน
        for (int i = 0; i < Boxopen.Length; i++)
        {
            if (col.gameObject.CompareTag($"Box_{i + 1:D2}"))
            {
                Boxopen[i].SetActive(true);
            }
        }
    }

    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.CompareTag("CheckHead"))
    //    {
    //        cooking_BT.SetActive(false);
    //    }
    //}
}
