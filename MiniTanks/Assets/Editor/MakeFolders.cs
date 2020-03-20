using UnityEngine;
using UnityEditor;
using System.IO;

public class MakeFolders : ScriptableObject
{
    [MenuItem("Ouroboros Games/ Make Project Folders ")]
    static void CreateFolders()
    {
        string path = Application.dataPath + "/";

        CreateAssetsFolders(path);

        // Add Product name folder
        path = Application.dataPath + "/" + Application.productName + "/";

        Directory.CreateDirectory(path);

        // Main folders
        CreateMainFolders(path);

        //  Scripts folders
        CreateScriptsFolders();

        //  Sounds folders
        CreateSoundsFolders();

        //  Graph folders
        CreateGraphFolders();


        AssetDatabase.Refresh();
        Debug.Log("Folders created");
    }

    /// <summary>
    /// Create Assets folders
    /// </summary>
    /// <param name="_path">path where create folders</param>
    private static void CreateAssetsFolders(string _path)
    {
        Directory.CreateDirectory(_path + "Editor");
        Directory.CreateDirectory(_path + "Editor/Ouroboros Games/Tools");
        Directory.CreateDirectory(_path + "Editor/Ouroboros Games/Resources");

        //File.Move(_path + "Editor/Template/MakeFolders.cs", _path + "Editor/Lucine/Tools/MakeFolders.cs");
        //File.Move(_path + "Editor/Template/ScriptTemplateCreator.cs", _path + "Editor/Lucine/Tools/Templates/ScriptTemplateCreator.cs");
        //File.Move(_path + "Editor/Template/KeywordProcessor.cs", _path + "Editor/Lucine/Tools/Templates/KeywordProcessor.cs");

        Directory.CreateDirectory(_path + "Resources");
        Directory.CreateDirectory(_path + "Plugins");

        CreateResourcesFolders(_path + "Resources/");
        CreatePlaceHolderFile(_path + "Editor/");
        CreatePlaceHolderFile(_path + "Resources/");
        CreatePlaceHolderFile(_path + "Plugins/");
    }

    /// <summary>
    /// Create folders in Resources
    /// </summary>
    /// <param name="_path"></param>
    private static void CreateResourcesFolders(string _path)
    {
        Directory.CreateDirectory(_path + "Prefabs");
        Directory.CreateDirectory(_path + "Materials");
        Directory.CreateDirectory(_path + "Shaders");

        CreatePlaceHolderFile(_path + "Prefabs/");
        CreatePlaceHolderFile(_path + "Materials/");
        CreatePlaceHolderFile(_path + "Shaders/");
    }

    /// <summary>
    /// Create Main folders 
    /// </summary>
    /// <param name="_path"></param>
    private static void CreateMainFolders(string _path)
    {
        Directory.CreateDirectory(_path + "Prefabs");
        Directory.CreateDirectory(_path + "Scripts");
        Directory.Move(Application.dataPath + "/Scenes", Application.dataPath + "/" + Application.productName + "/Scenes");
        Directory.CreateDirectory(_path + "Sounds");
        Directory.CreateDirectory(_path + "Graph");

        CreatePlaceHolderFile(_path + "Prefabs/");
        CreatePlaceHolderFile(_path + "Scripts/");
        CreatePlaceHolderFile(_path + "Scenes/");
        CreatePlaceHolderFile(_path + "Sounds/");
        CreatePlaceHolderFile(_path + "Graph/");
    }

    /// <summary>
    /// Create Script folders
    /// </summary>
    private static void CreateScriptsFolders()
    {
        string path = Application.dataPath + "/" + Application.productName + "/" + "Scripts/";
        Directory.CreateDirectory(path + "3C");
        Directory.CreateDirectory(path + "Managers");
        Directory.CreateDirectory(path + "Tools");
        Directory.CreateDirectory(path + "UI");

        CreatePlaceHolderFile(path + "3C/");
        CreatePlaceHolderFile(path + "Managers/");
        CreatePlaceHolderFile(path + "Tools/");
        CreatePlaceHolderFile(path + "UI/");
    }

    /// <summary>
    /// Create Sounds Folders
    /// </summary>
    private static void CreateSoundsFolders()
    {
        string path = Application.dataPath + "/" + Application.productName + "/" + "Sounds/";
        Directory.CreateDirectory(path + "Musics");
        Directory.CreateDirectory(path + "Ambient");
        Directory.CreateDirectory(path + "SFX");

        CreatePlaceHolderFile(path + "Musics/");
        CreatePlaceHolderFile(path + "Ambient/");
        CreatePlaceHolderFile(path + "SFX/");
    }

    /// <summary>
    /// Create Graph folders
    /// </summary>
    private static void CreateGraphFolders()
    {
        string path = Application.dataPath + "/" + Application.productName + "/" + "Graph/";
        Directory.CreateDirectory(path + "Textures");
        Directory.CreateDirectory(path + "Textures/LOD");
        Directory.CreateDirectory(path + "Materials");
        Directory.CreateDirectory(path + "Shaders");
        Directory.CreateDirectory(path + "Models");
        Directory.CreateDirectory(path + "Models/LOD");
        Directory.CreateDirectory(path + "Fonts");
        Directory.CreateDirectory(path + "Fonts");
        Directory.CreateDirectory(path + "Animations");
        Directory.CreateDirectory(path + "VFX");
        Directory.CreateDirectory(path + "Skyboxs");
        Directory.CreateDirectory(path + "Terrains");
        Directory.CreateDirectory(path + "UI");
        Directory.CreateDirectory(path + "UI/Sprites");
        Directory.CreateDirectory(path + "UI/Animations");

        CreatePlaceHolderFile(path + "Textures/");
        CreatePlaceHolderFile(path + "Textures/LOD/");
        CreatePlaceHolderFile(path + "Materials/");
        CreatePlaceHolderFile(path + "Shaders/");
        CreatePlaceHolderFile(path + "Models/");
        CreatePlaceHolderFile(path + "Models/LOD/");
        CreatePlaceHolderFile(path + "Fonts/");
        CreatePlaceHolderFile(path + "Animations/");
        CreatePlaceHolderFile(path + "VFX/");
        CreatePlaceHolderFile(path + "Skyboxs/");
        CreatePlaceHolderFile(path + "Terrains/");
        CreatePlaceHolderFile(path + "UI/");
        CreatePlaceHolderFile(path + "UI/Sprites");
        CreatePlaceHolderFile(path + "UI/Animations");
    }

    /// <summary>
    /// Create Empty txt file
    /// </summary>
    /// <param name="_path"></param>
    private static void CreatePlaceHolderFile(string _path, string _name = "PlaceHolders.txt")
    {
        File.CreateText(_path + _name);
        Debug.Log("File: " + _path + _name + " has created at " + File.GetLastWriteTime(_path + _name));
    }
}