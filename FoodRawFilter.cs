using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class FoodRawFilter : MonoBehaviour
{
    [SerializeField] private List<FoodRawSO> allFoodRawSOs;
    [SerializeField] private FoodRawType filterType;
    public GameObject menu;

    public static List<FoodRawSO> FilterByType(List<FoodRawSO> raws, FoodRawType type)
    {
        List<FoodRawSO> foodRawSO = new List<FoodRawSO>();
        foreach (FoodRawSO raw in raws)
        {
            if (raw.type == type)
            {
                foodRawSO.Add(raw);
            }
        }
        return foodRawSO;
    }

    public void Vegetables()
    {
        filterType = FoodRawType.Vegetable;
        foreach (Transform child in menu.transform)
        {
            Destroy(child.gameObject);
        }

        List<FoodRawSO> foodRawSO = FilterByType(allFoodRawSOs, filterType);
        foreach (FoodRawSO vegetable in foodRawSO)
        {
            Instantiate(vegetable.prefab, menu.transform);
            Debug.Log(vegetable.name.ToString());
        }
    }

    public void Meats()
    {
        filterType = FoodRawType.Meat;
        foreach (Transform child in menu.transform)
        {
            Destroy(child.gameObject);
        }

        List<FoodRawSO> foodRawSO = FilterByType(allFoodRawSOs, filterType);
        foreach (FoodRawSO meat in foodRawSO)
        {
            Instantiate(meat.prefab, menu.transform);
            Debug.Log(meat.name.ToString());
        }
    }
    public void Spices()
    {
        filterType = FoodRawType.Spices;
        foreach (Transform child in menu.transform)
        {
            Destroy(child.gameObject);
        }

        List<FoodRawSO> foodRawSO = FilterByType(allFoodRawSOs, filterType);
        foreach (FoodRawSO spices in foodRawSO)
        {
            Instantiate(spices.prefab, menu.transform);
            Debug.Log(spices.name.ToString());
        }
    }

    //Filter price
    public List<FoodRawSO> SortFoodRawByPriceDescending()
    {
        allFoodRawSOs.Sort(CompareFoodByPriceDescending);
        return allFoodRawSOs;
    }

    private int CompareFoodByPriceDescending(FoodRawSO a, FoodRawSO b)
    {
        return b.price.CompareTo(a.price);
    }

    public void priceDescending()
    {
        foreach (Transform child in menu.transform)
        {
            Destroy(child.gameObject);
        }

        List<FoodRawSO> foodRawSO = SortFoodRawByPriceDescending();
        foreach (FoodRawSO allfoods in foodRawSO)
        {
            Instantiate(allfoods.prefab, menu.transform);
        }
    }
        
}
