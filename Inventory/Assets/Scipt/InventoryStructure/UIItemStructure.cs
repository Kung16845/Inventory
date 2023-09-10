using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace InventoryStructure
{
    public class UIItemStructure : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI itemnameText; //ชื่อไอเท็มที่ต้องการแสดงหน้า UI
        [SerializeField] TextMeshProUGUI countitemText; // จำนวน Item ที่ต้องการแสดงในหน้า UI

        public void Setdata(UIItemData uIItemData)
        {
            itemnameText.text = uIItemData.inventoryItemdata.itemname; // แสดงชื่อ item ตามข้อมูลจากพารามิเตอร์ uIItemdta ในหน้า UI
            countitemText.text = " " + uIItemData.inventoryItemdata.countitem; // แสดงจำนวน item ตามข้อมูลจากพารามิเตอร์ uIItemdta ในหน้า UI
        }
    }
    public class UIItemData
    {
        public InventoryItemdata inventoryItemdata;
        public UIItemData(InventoryItemdata inventoryItemdata) 
        {
            this.inventoryItemdata = inventoryItemdata;
        } 
    }

}
