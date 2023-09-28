using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons_Level1 : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("Level_Menu");
    }
}
