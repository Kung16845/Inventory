using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryStructure
{
    public class InventoryStructure : MonoBehaviour
    {
        public InventoryItemdata[] Itemdatas => itemList.ToArray(); // แปลงให้กลายเป็น Array
        [SerializeField] List<InventoryItemdata> itemList = new List<InventoryItemdata>(); //เก็บข้อมูลไอเท็มโดยมีข้อมูลตาม InventoryItemList
        public InventoryItemdata[] GetItemBytype(itemType itemType) //ใช้ในการแยกประเภทของ item
        {
            var dataListType = new List<InventoryItemdata>(); // สร้าง List ใหม่ จาก class InventoryItemdata 
            foreach (var item in itemList) // ลูป item ทั้งหมด จาก itemList 
            {
                if (item.itemType == itemType) // เช็ค item จาก itemList ว่ามี Item ไหนบ้างที่ ต้องตรงกับพารามิเตอร์ item Type ที่เรียกใช้  
                {
                    dataListType.Add(item); // เพิ่ม item muj type เหมือนกัน เข้า dataListType
                }
            }
            return dataListType.ToArray(); //ให้ return ค่ากลับเป็น Array 
        }
    }
    
    [Serializable]
    public class InventoryItemdata 
    {
        public string itemname;
        public string itemdescription;
        public Sprite iconitem;
        public int countitem;
        public itemType itemType;
    }
    public enum itemType
    {
        potionhp = 1,
        potionmp = 2,
        potionstamina = 3,
        potionsanity = 4

    }
}
