using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mn_GameManager : MonoBehaviour
{
    public void LoseGame()
    {
        SceneManager.LoadScene("LoseScene");
    }
}
