using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class IngredientSO : ScriptableObject
{
    public List<FoodRawSO> ingredients;
}

/*public class CreateFoodSO : MonoBehaviour
{
    [MenuItem("Assets/Create/IngredientSOs From Folder")]
    public static void CreateIngredientSOsFromFolder()
    {
        string sourceFolderPath = "Assets/Cooking Ingredients Prepared Dishes Food/Food or Prepared Dishes";
        string targetFolderPath = "Assets/MixIngredient";

        if (!AssetDatabase.IsValidFolder(targetFolderPath))
        {
            AssetDatabase.CreateFolder("Assets", "MixIngredient");
        }

        string[] imagePaths = Directory.GetFiles(sourceFolderPath, "*.png");

        foreach (string imagePath in imagePaths)
        {
            Texture2D texture = AssetDatabase.LoadAssetAtPath<Texture2D>(imagePath);

            if (texture != null)
            {
                IngredientSO ingredientSO = ScriptableObject.CreateInstance<IngredientSO>();
               

                string assetPath = targetFolderPath + "/" + Path.GetFileNameWithoutExtension(imagePath) + ".asset";
                AssetDatabase.CreateAsset(ingredientSO, assetPath);
            }
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}*/
