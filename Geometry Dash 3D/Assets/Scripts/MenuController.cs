using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Основний скрипт для меню гри
///     Має функції запуску системи вибору рівнів
///     +Функції виклику меню налаштування 
///     +Функція виходу з гри 
///     Функція перегляду статистики за ігровий період
/// </summary>

public class MenuController : MonoBehaviour
{
    public GameObject MainMenuButtons;
    public GameObject SettingMenuButtons;

    public void StartGame()
    {
      SceneManager.LoadScene("SimpleScene");
    }

    //Виклик меню налаштування
    public void CallingSettingMenu() 
    {
        MainMenuButtons.SetActive(false);
        SettingMenuButtons.SetActive(true);
    }

    //Виклик основного меню 
    public void CallingMainMenu()
    {
        MainMenuButtons.SetActive(true);
        SettingMenuButtons.SetActive(false);
    }

    //Вихід з гри
    public void Exit() 
    {
        Application.Quit(); // Завершення виконання програми
    }


}
