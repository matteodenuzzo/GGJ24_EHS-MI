using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mn_PlayerUi : MonoBehaviour
{
   [SerializeField] private List<GameObject> tomatoesLife;
   
   public void DeactivateFirstActiveGameObject()
   {
      foreach (var gameObject in tomatoesLife)
      {
         if (gameObject.activeSelf)
         {
            gameObject.SetActive(false);
            break;
         }
      }
   }
}
