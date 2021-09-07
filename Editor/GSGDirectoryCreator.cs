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
            //CreateDirectories("_GameName","Art","Prefabs","Scripts");
            const string root = "_GameName";
            CreateSubFolders(root + "/Art","Animation","Materials","Model","Sprite","Textures");
            CreateSubFolders(root + "/Scripts", "");
            CreateSubFolders(root+"/Prefabs","Enemy", "Player","Props", "UI");
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

        private static void CreateSubFolders(string root, params string[] dir)
        {
            var fullpath = Path.Combine(dataPath,root);                             
            foreach (var newDirectory in dir)                                            
            {                                                                            
                CreateDirectory(Path.Combine(fullpath, newDirectory));                   
            }                                                                            
        }                                                                                
        
    }
}
