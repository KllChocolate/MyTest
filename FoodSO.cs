using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Name", menuName = "Food", order = 1)]
public class FoodSO : ScriptableObject
{
    public GameObject prefab;
    public Sprite sprite;
    public string objectName;
    public int price;
    public int count = 1;

    public IngredientSO ingredientSO;
}

/*public class CreateFoodSO : MonoBehaviour
{
    [MenuItem("Assets/Create/FoodSOs From Folder")]
    public static void CreateFoodSOsFromFolder()
    {
        string sourceFolderPath = "Assets/Cooking Ingredients Prepared Dishes Food/Food or Prepared Dishes";
        string targetFolderPath = "Assets/Food";

        if (!AssetDatabase.IsValidFolder(targetFolderPath))
        {
            AssetDatabase.CreateFolder("Assets", "Food");
        }

        string[] imagePaths = Directory.GetFiles(sourceFolderPath, "*.png");

        foreach (string imagePath in imagePaths)
        {
            Texture2D texture = AssetDatabase.LoadAssetAtPath<Texture2D>(imagePath);

            if (texture != null)
            {
                FoodSO foodSO = ScriptableObject.CreateInstance<FoodSO>();
                foodSO.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
                foodSO.objectName = Path.GetFileNameWithoutExtension(imagePath);

                string assetPath = targetFolderPath + "/" + Path.GetFileNameWithoutExtension(imagePath) + ".asset";
                AssetDatabase.CreateAsset(foodSO, assetPath);
            }
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}*/
