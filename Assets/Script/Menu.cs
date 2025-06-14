using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    

    // Цей метод викликається при натисканні кнопки
    public void LoadScene()
    {
        SceneManager.LoadScene("Level_1");
    }
}
