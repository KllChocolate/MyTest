using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Name", menuName = "IngredientList", order = 1)]
public class IngredientListSO : ScriptableObject
{
    public List<IngredientSO> ingredientSO;
}
