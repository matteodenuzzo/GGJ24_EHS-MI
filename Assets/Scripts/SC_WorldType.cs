using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WorldType", menuName = "ScriptableObjects/WorldType", order = 1)]
public class SC_WorldType : ScriptableObject
{
   [SerializeField] public List<SC_WorldType> superEffectiveTypes;
   [SerializeField] public List<SC_WorldType> notVeryEffectiveTypes;
   [SerializeField] public List<SC_WorldType> normalEffectiveTypes;
   [SerializeField] public Sprite sprite;
}
