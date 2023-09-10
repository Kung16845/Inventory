using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryStructure
{

    public class UIInventoryStructure : MonoBehaviour
    {
        [Header("Item List")]

        [SerializeField] UIItemStructure uIItemStructurePrefeb; // เอาไว้เก็บ PrefebUIItem 
        [SerializeField] List<UIItemStructure> uIItemList = new List<UIItemStructure>(); // สร้าง List ไว้เก็บข้อมูล List UI
        
        private void Start()
        {
            uIItemStructurePrefeb.gameObject.SetActive(false);
        }
        public void SetItemListUI(UIItemData[] uIItemDatas)
        {
            ClearAllItemUI();
            foreach (var uiitem in uIItemDatas)
            {
                var newitemUI = Instantiate(uIItemStructurePrefeb,uIItemStructurePrefeb.transform.parent,false); //เป็นคำสั่งไว้สร้าง UIItem

                newitemUI.gameObject.SetActive(true); //ให้ newitemUI ที่สร้างขึ้นแสดงในหน้่า Game
                uIItemList.Add(newitemUI); // เพิ่่ม newitemUI เข้า List uIItemList สำหรับการเก็บข้อมูล
                newitemUI.Setdata(uiitem); // เรียกใช้ method Setdata ไว้เซตข้อมูลลง newitemUI
            }
        }
        public void ClearAllItemUI() //ใช้เคลีย UIItemList ทั้งหมด
        {
            foreach(var uiitem in uIItemList) 
                 Destroy(uiitem.gameObject);   
            uIItemList.Clear();
        }
    }
    
}
