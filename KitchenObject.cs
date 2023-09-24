using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenObject : MonoBehaviour
{
    public FoodRawSO foodRawSO;
    public static KitchenObject Instance { get; private set; }
    public void Awake()
    {
        Instance = this;
    }
    public void Start()
    {
        Image image = GetComponent<Image>();
        Text text = GetComponentInChildren<Text>();

        image.sprite = foodRawSO.sprite;
        text.text = foodRawSO.price.ToString();
    }

    public void AddItem()
    {
        if (foodRawSO != null)
        {
            if (Inventory.Instance.FoodRawSOList.Contains(foodRawSO))
            {
                foodRawSO.count += 1;
            }
            else
            {
                Inventory.Instance.FoodRawSOList.Add(foodRawSO);
            }
        }
    }
}
