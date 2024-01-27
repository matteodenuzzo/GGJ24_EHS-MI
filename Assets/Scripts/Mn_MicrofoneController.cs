using System.Collections;
using System.Collections.Generic;
using UGTK.Base.AudioSystem;
using UGTK.Base.DamageSystem;
using UnityEngine;

public class Mn_MicrofoneController : MonoBehaviour
{
    private bool hasMicrofone = true;
    private bool check = true;
    [SerializeField] private float invicibilityTime = 1.0f;
    [SerializeField] private Mn_HealthComponent healthComponent;
    [SerializeField] private GameObject microfone;
    [SerializeField] private List<GameObject> possibileSpawnPoints;
    [SerializeField] private Mn_PlayerUi playerUi;
    
    [SerializeField] private List<int> lifePoints;
    [SerializeField] private List<string> correspondingAudio;
    
    public void OnDamaged(float damage, float max)
    {
        if (!check)
        {   
            check = true;
            playerUi.DeactivateFirstActiveGameObject();
            return;
        }
        
        if (!healthComponent.vulnerable)
        {
            return;
        }
        
        if (hasMicrofone)
        {
            hasMicrofone = false;
            SpawnMicrofoneInANewPosition();
            healthComponent.vulnerable = true;
            StartCoroutine(InvincibilityTimer());
        }
        else
        {
            healthComponent.TakeDamage(1);
            float currentLife = healthComponent.GetLife();
            int index = lifePoints.IndexOf((int)currentLife);
            AudioEvents.AudioPlay.Invoke(correspondingAudio[index]);
            check = false;
        }    
    }
    
    public IEnumerator InvincibilityTimer()
    {
        yield return new WaitForSeconds(invicibilityTime);
        healthComponent.vulnerable = false;
    }

    public void SpawnMicrofoneInANewPosition()
    {
        int randomIndex = Random.Range(0, possibileSpawnPoints.Count);
        microfone.SetActive(true);
        microfone.transform.position = possibileSpawnPoints[randomIndex].transform.position;
    }
    
    public void GainMicrofone()
    {
        hasMicrofone = true;
        microfone.SetActive(false);
    }
    
}
