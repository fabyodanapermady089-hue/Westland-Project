using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Status Pemain")]
    public float health = 100f;
    public float hunger = 100f;
    public float thirst = 100f;

    [Header("Pengaturan Pengurangan")]
    public float hungerDropRate = 0.5f;
    public float thirstDropRate = 0.8f;

    void Update()
    {
        // Mengurangi lapar dan haus seiring berjalannya waktu
        if (hunger > 0) hunger -= hungerDropRate * Time.deltaTime;
        if (thirst > 0) thirst -= thirstDropRate * Time.deltaTime;

        // Jika sangat lapar/haus, nyawa mulai berkurang
        if (hunger <= 0 || thirst <= 0)
        {
            health -= 1f * Time.deltaTime;
        }

        // Cek jika mati
        if (health <= 0)
        {
            Debug.Log("Pemain Mati!");
        }
    }
    // TARUH DI SINI (Baris baru)
    public void Makan(float nutrisi)
    {
        hunger += nutrisi;
        if (hunger > 100f) hunger = 100f;
    }
    }
    // Tambahkan ini besok di bawah fungsi Update
    public void Makan(float nutrisi)
    {
        hunger += nutrisi;
        if (hunger > 100f) hunger = 100f;
    }

    public void Minum(float air)
    {
        thirst += air;
        if (thirst > 100f) thirst = 100f;
    }
}
