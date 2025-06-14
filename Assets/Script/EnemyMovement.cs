using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform pointA;  // Перша точка руху ворога
    public Transform pointB;  // Друга точка руху
    public float speed = 2f;  // Швидкість руху

    private Vector3 target;   // Куди зараз рухається ворог

    void Start()
    {
        target = pointB.position;  // Починаємо рухатися в точку B
    }

    void Update()
    {
        // Рухаємось до точки target
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Якщо дійшли до точки — міняємо напрямок
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            if (target == pointB.position)
                target = pointA.position;
            else
                target = pointB.position;
        }

        // Повертаємо ворога в правильний бік (щоб дивився куди йде)
        if (target == pointB.position)
            transform.localScale = new Vector3(1, 1, 1);
        else
            transform.localScale = new Vector3(-1, 1, 1);
    }
}
