using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Status Real-Time (Dompet)")]
    public float health;
    public float hunger;
    public float thirst;

    [Header("Kecepatan Berkurang")]
    public float hungerRate = 0.5f;
    public float thirstRate = 0.8f;

    void Start()
    {
        // 1. MENGAMBIL DATA DARI GAMEMANAGER SAAT MASUK MAP
        if (GameManager.instance != null)
        {
            health = GameManager.instance.savedHealth;
            hunger = GameManager.instance.savedHunger;
            thirst = GameManager.instance.savedThirst;
            Debug.Log("Status Pemain berhasil dimuat!");
        }
    }

    void Update()
    {
        // 2. LOGIKA PENGURANGAN OTOMATIS
        if (hunger > 0) hunger -= hungerRate * Time.deltaTime;
        if (thirst > 0) thirst -= thirstRate * Time.deltaTime;

        // 3. JIKA LAPAR/HAUS HABIS, DARAH BERKURANG
        if (hunger <= 0 || thirst <= 0)
        {
            health -= 1f * Time.deltaTime;
        }

        if (health <= 0) Die();
    }

    // 4. FUNGSI UNTUK MENITIPKAN DATA KEMBALI (SAVE)
    public void SaveStatus()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.savedHealth = health;
            GameManager.instance.savedHunger = hunger;
            GameManager.instance.savedThirst = thirst;
            Debug.Log("Status disimpan ke GameManager.");
        }
    }

    void Die()
    {
        Debug.Log("Karakter mati di Westland!");
    }
}
