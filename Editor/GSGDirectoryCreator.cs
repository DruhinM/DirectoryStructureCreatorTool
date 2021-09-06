using System.Collections;
using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;
using static System.IO.Directory;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;
using UnityEditor;
using UnityEngine;


namespace druhinmukherjee
{
    
    public static class GsgDirectoryCreator 
    {
        [MenuItem("Tools/Folders")]
        public static void Create()
        {
            CreateDirectories("_Project","Scripts","Art","Prefabs");
            Refresh();
        }

        public static void CreateDirectories(string root, params string[] dir)
        {
            var fullpath = Path.Combine(dataPath, root);
            foreach (var newDirectory in dir)
            {
                CreateDirectory(Path.Combine(fullpath, newDirectory));
            }
        }
    }
}
