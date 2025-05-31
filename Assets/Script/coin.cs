using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour

{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Перевіряємо, чи доторкнувся гравець
        if (other.CompareTag("Player"))
        {
            // Тут можна додати лічильник або звук

            Destroy(gameObject); // Знищити монетку
        }
    }
}
