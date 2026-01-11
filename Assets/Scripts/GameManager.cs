using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton: Supaya skrip lain bisa memanggil data dengan "GameManager.instance"
    public static GameManager instance;

    [Header("Pusat Data Permanen (Simpanan)")]
    public float savedHealth = 100f;
    public float savedHunger = 100f;
    public float savedThirst = 100f;

    private void Awake()
    {
        // Logika agar GameManager tidak hancur saat pindah map/scene
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Fungsi untuk meriset status jika pemain mati total atau mulai baru
    public void ResetAllStats()
    {
        savedHealth = 100f;
        savedHunger = 100f;
        savedThirst = 100f;
    }
}
