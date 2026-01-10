using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    public float speed = 2f;
    public float patrolDistance = 5f;
    private Vector3 startPosition;
    private bool movingRight = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Logika patroli bolak-balik sederhana
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= startPosition.x + patrolDistance) movingRight = false;
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= startPosition.x - patrolDistance) movingRight = true;
        }
    }
}
