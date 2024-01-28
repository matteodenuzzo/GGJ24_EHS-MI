using System.Collections;
using System.Collections.Generic;
using UGTK.Base.AudioSystem;
using UnityEngine;

public class MnMy_Audio : MonoBehaviour
{
    [SerializeField] private string Audio;
    [SerializeField] private bool PlayOnStart;
    [SerializeField] private bool pauseAfterStart;
    
    private void Start()
    {
        if (PlayOnStart)
        {
            AudioEvents.AudioPlay.Invoke(Audio);
            if (pauseAfterStart)
            {
                AudioEvents.AudioPause.Invoke(Audio);
            }
        }
    }
    
    public void OnResume()
    {
        AudioEvents.AudioResume.Invoke(Audio);
    }
    
    public void OnPlay()
    {
        AudioEvents.AudioPlay.Invoke(Audio);
    }
    
    public void OnPause()
    {
        AudioEvents.AudioPause.Invoke(Audio);
    }
    
    public void OnStop()
    {
        AudioEvents.AudioStop.Invoke(Audio);
    }
}
