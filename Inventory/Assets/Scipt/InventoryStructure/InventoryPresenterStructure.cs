using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryStructure
{    
    public class InventoryPresenterStructure : MonoBehaviour 
    {
        public int currunttype = 1;
        [SerializeField] InventoryStructure inventoryStructure;
        [SerializeField] UIInventoryStructure uIInventoryStructure;
        private void Start()
        {
            RefreshUI();
        }
        private void Update() 
        {
            if(Input.GetKeyUp(KeyCode.Q))
            {
                currunttype--;
                RefreshUI();
            }
            else if(Input.GetKeyUp(KeyCode.E))
            {
                currunttype++;
                RefreshUI();
            }
            if(currunttype == 0)
            {
                currunttype = 1;
                RefreshUI();
            }
            else if(currunttype == 5)
            {
                currunttype = 4;
                RefreshUI();
            }
        }
        void RefreshUI()
        {
            var itemCurrenttypedisplay = inventoryStructure.GetItemBytype((itemType)currunttype); // สร้างตัวแปรสำหรับแสดง Type ปัจจุบัน

            var uIItemData = new List<UIItemData>(); // สร้าง List ไว้เก็บข้อมูล itemUI ของแต่ละ type ทั้งหมด

            foreach (var item in itemCurrenttypedisplay) // เพิ่มไอเท็มทั้งหมดที่อยู่ใน type เดียวกันลง uIItemData
            {
                uIItemData.Add(new UIItemData(item));
            }

            uIInventoryStructure.SetItemListUI(uIItemData.ToArray()); //ใช้แสดงItem List ทั้งหมด ที่ type เดียวกัน
        }
    }
}