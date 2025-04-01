using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CookingManager : MonoBehaviour
{
    public static CookingManager Instance;
    private List<GameObject> ingredients = new List<GameObject>();

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void AddIngredient(GameObject ingredient)
    {
        if (!ingredients.Contains(ingredient))
        {
            ingredients.Add(ingredient);
            Debug.Log("Added: " + ingredient.name);

            if (ingredients.Count == 3)
            {
                StartCoroutine(CookFood());
            }
        }
    }

    private IEnumerator CookFood()
    {
        Debug.Log("กำลังทำอาหาร...");
        yield return new WaitForSeconds(3);
        Debug.Log("อาหารเสร็จแล้ว!");
        ingredients.Clear();
    }
}

