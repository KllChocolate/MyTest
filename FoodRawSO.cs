using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Name", menuName = "Raw Material", order = 1)]
public class FoodRawSO : ScriptableObject
{
    public GameObject prefab;
    public Sprite sprite;
    public string objectName;
    public FoodRawType type;
    public int price;
    public int count = 1;
}

/*public class CreateFoodRawSO : MonoBehaviour
{
    [MenuItem("Assets/Create/FoodRawSOs From Folder")]
    public static void CreateFoodRawSOsFromFolder()
    {
        string sourceFolderPath = "Assets/Cooking Ingredients Prepared Dishes Food/Cooking Ingredients";
        string targetFolderPath = "Assets/RawMaterials";

        if (!AssetDatabase.IsValidFolder(targetFolderPath))
        {
            AssetDatabase.CreateFolder("Assets", "RawMaterials");
        }

        string[] imagePaths = Directory.GetFiles(sourceFolderPath, "*.png");

        foreach (string imagePath in imagePaths)
        {
            Texture2D texture = AssetDatabase.LoadAssetAtPath<Texture2D>(imagePath);

            if (texture != null)
            {
                FoodRawSO foodRawSO = ScriptableObject.CreateInstance<FoodRawSO>();
                foodRawSO.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
                foodRawSO.objectName = Path.GetFileNameWithoutExtension(imagePath);

                string assetPath = targetFolderPath + "/" + Path.GetFileNameWithoutExtension(imagePath) + ".asset";
                AssetDatabase.CreateAsset(foodRawSO, assetPath);
            }
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}*/
