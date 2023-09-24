using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    public GameObject inventoryMenu;
    public GameObject shop;
    public GameObject crafting;
    public GameObject craftingMenu;
    public List<FoodRawSO> FoodRawSOList;
    public List<FoodSO> FoodSOList;

    public static Inventory Instance { get; private set; }
    public void Awake()
    {
        Instance = this;
    }

    public void Crafting()
    {
        shop.SetActive(false);
        inventory.SetActive(true);
        inventoryMenu.SetActive(true);
        craftingMenu.SetActive(true);
        foreach (FoodRawSO rawFood in FoodRawSOList)
        {
            Instantiate(rawFood.prefab, inventoryMenu.transform);
        }
    }
    public void ShowShop()
    {
        shop.SetActive(true);
        inventory.SetActive(false);
        foreach (Transform child in inventoryMenu.transform)
        {
            Destroy(child.gameObject);
        }
    }
    public void ShowInventory()
    {
        shop.SetActive(false);
        inventory.SetActive(true);
        foreach (FoodRawSO rawFood in FoodRawSOList)
        {
            Instantiate(rawFood.prefab, inventoryMenu.transform);
        }
    }

    public void SaveInventory()
    {
        {
            SaveData data = new SaveData();
            data.FoodRawSOList = FoodRawSOList;
            data.FoodSOList = FoodSOList;

            string jsonData = JsonUtility.ToJson(data);

            System.IO.File.WriteAllText("save.json", jsonData);
        }
    }
    public void LoadInventory()
    {
        if (System.IO.File.Exists("save.json"))
        {
            string jsonData = System.IO.File.ReadAllText("save.json");

            SaveData data = JsonUtility.FromJson<SaveData>(jsonData);

            FoodRawSOList = data.FoodRawSOList;
            FoodSOList = data.FoodSOList;
        }
    }

}
