using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public FoodSO foodSO;
    public Image image;
    public GameObject menuIngredient;

    
    
    public void Start()
    {
        Image image = GetComponent<Image>();
        Text text = GetComponentInChildren<Text>();

        image.sprite = foodSO.sprite;
        text.text = foodSO.name.ToString();
    }

    public void clickItem()
    {
        image.sprite = foodSO.sprite;
        Cooking.Instance.foodSO = foodSO;
        if (foodSO.ingredientSO != null)
        {
            foreach (FoodRawSO foodRawSO in foodSO.ingredientSO.ingredients)
            {
                Instantiate(foodRawSO.prefab, menuIngredient.transform);
            }
        }
    }
}
