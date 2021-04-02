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
    public GameObject mainMenuButtons;
    public GameObject settingMenuButtons;
    public GameObject helpPlayMenuButtons;
  
    public void StartGame()
    {
       SceneManager.LoadScene(1);
    }

    //Виклик меню налаштування
    public void CallingSettingMenu() 
    {
        mainMenuButtons.SetActive(false);
        settingMenuButtons.SetActive(true);
    }

    //Виклик основного меню 
    public void CallinBackMainMenu()
    {
        mainMenuButtons.SetActive(true);
        settingMenuButtons.SetActive(false);
        helpPlayMenuButtons.SetActive(false);
    }

    //Виклик допомоги в управлінні 
    public void CallingHelpGuideMenu()
    {
        settingMenuButtons.SetActive(false);
        helpPlayMenuButtons.SetActive(true);
    }

    //Вихід з гри
    public void Exit() 
    {
        Application.Quit(); // Завершення виконання програми
    }


}
