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
    public GameObject HelpPlayMenuButtons;
  
    public void StartGame()
    {
      SceneManager.LoadScene(1);
      
    }

    //Виклик меню налаштування
    public void CallingSettingMenu() 
    {
        MainMenuButtons.SetActive(false);
        SettingMenuButtons.SetActive(true);
    }

    //Виклик основного меню 
    public void CallinBackMainMenu()
    {
        MainMenuButtons.SetActive(true);
        SettingMenuButtons.SetActive(false);
        HelpPlayMenuButtons.SetActive(false);
    }

    //Виклик допомоги в управлінні 
    public void CallingHelpGuideMenu()
    {
       SettingMenuButtons.SetActive(false);
       HelpPlayMenuButtons.SetActive(true);
       
       
    }

    //Вихід з гри
    public void Exit() 
    {
        Application.Quit(); // Завершення виконання програми
    }


}
