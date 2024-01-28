using System.Collections;
using System.Collections.Generic;
using UGTK.Base.DamageSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mn_GameManager : MonoBehaviour
{
    [SerializeField] private Mn_HealthComponent healthComponent;
    
    public void LoseGame()
    {
        SceneManager.LoadScene("LoseScene");
    }
}
