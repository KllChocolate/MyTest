using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Cooking : MonoBehaviour
{
    public GameObject cooking;
    public GameObject cancel;
    public GameObject menuIngredient;
    public GameObject menuInventory;
    public FoodSO foodSO;
    public Image image;
    public bool create = false;

    public static Cooking Instance { get; private set; }
    public void Awake()
    {
        Instance = this;
    }
    public void Cook()
    {
        foreach (Transform inventoryChild in menuInventory.transform)//ค้นคลัง
        {
            KitchenObject kitchenObjectInventory = inventoryChild.GetComponentInChildren<KitchenObject>();

            foreach (Transform ingredientChild in menuIngredient.transform)//ค้นสูตร
            {
                KitchenObject kitchenObjectIngredient = ingredientChild.GetComponentInChildren<KitchenObject>();

                FoodRawSO matchingIngredient = null;

                foreach (FoodRawSO ingredient in Inventory.Instance.FoodRawSOList)
                {
                    if (ingredient == kitchenObjectIngredient.foodRawSO)
                    {
                        matchingIngredient = ingredient;
                        create = true;
                        if (matchingIngredient != null)
                        {
                            kitchenObjectInventory.foodRawSO.count = -1;
                            if (kitchenObjectInventory.foodRawSO.count <= 0)
                            {
                                Inventory.Instance.FoodRawSOList.Remove(kitchenObjectInventory.foodRawSO);
                                foreach (Transform child in menuInventory.transform)
                                {
                                    Destroy(child.gameObject);
                                }
                                foreach (FoodRawSO rawFood in Inventory.Instance.FoodRawSOList)
                                {
                                    Instantiate(rawFood.prefab, menuInventory.transform);
                                }
                            }
                        }
                    } break;
                }
            }
        }
        if (create == true)
        {
            Inventory.Instance.FoodSOList.Add(foodSO);
            Instantiate(foodSO.prefab, menuInventory.transform);
            Debug.Log("ใช้ฟังก์ชั่น");
            if (Inventory.Instance.FoodSOList != null)
            {
                if (Inventory.Instance.FoodSOList.Contains(foodSO))
                {
                    foodSO.count += 1;
                }
                else
                {
                    Inventory.Instance.FoodSOList.Add(foodSO);
                    Instantiate(foodSO.prefab, menuInventory.transform);
                }
                Debug.Log("มีของอยู่แล้ว");
            }
            create = false;
        }
    }

    public void Cancel()
    {
        foreach (Transform child in menuIngredient.transform)
        {
            Destroy(child.gameObject);
        }

        image.sprite = null;
        //cooking.SetActive(false);
        //cancel.SetActive(false);
    }
}
