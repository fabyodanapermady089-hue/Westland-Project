using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Daftar barang yang ada di dalam tas
    public List<string> inventoryList = new List<string>();

    // Fungsi untuk menambah barang (Misal: Kayu, Pistol, Air)
    public void AddItem(string itemName)
    {
        inventoryList.Add(itemName);
        Debug.Log("Berhasil mengambil: " + itemName);
    }

    // Fungsi untuk membuang barang
    public void RemoveItem(string itemName)
    {
        if (inventoryList.Contains(itemName))
        {
            inventoryList.Remove(itemName);
            Debug.Log("Membuang: " + itemName);
        }
    }

    // Cek jumlah barang di tas
    public void ShowInventoryCount()
    {
        Debug.Log("Jumlah barang di tas: " + inventoryList.Count);
    }
}
