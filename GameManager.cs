using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public void Save()
    {
        Inventory.Instance.SaveInventory();
    }
    public void Load() 
    {
        Inventory.Instance.LoadInventory();

        foreach (FoodRawSO rawFood in Inventory.Instance.FoodRawSOList)
        {
            Instantiate(rawFood.prefab, Inventory.Instance.inventoryMenu.transform);
        }

        foreach (FoodSO Food in Inventory.Instance.FoodSOList)
        {
            Instantiate(Food.prefab, Inventory.Instance.inventoryMenu.transform);
        }
    }
}