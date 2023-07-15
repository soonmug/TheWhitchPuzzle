using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.Collections.Generic;

public class Save
{

     public static void SaveItem(List<Item> Items, string filePath)
    {
        
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream file = File.Create(filePath);
    
        formatter.Serialize(file, Items);
    
        file.Close();
    }
    
     public static InventoryManager LoadItem(string filePath)
    {
        if (File.Exists(filePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = new FileStream(filePath, FileMode.Open);
    
            InventoryManager inventoryManager = formatter.Deserialize(file) as List<Item>;
    
            file.Close();
     
        inventoryManager = new InventoryManager();

        // itemList를 inventoryManager에 할당하는 로직
       
        return items;
        }

        else
        {
            Debug.LogError("파일이 존재하지 않습니다");
            return null;
        }
    }
}