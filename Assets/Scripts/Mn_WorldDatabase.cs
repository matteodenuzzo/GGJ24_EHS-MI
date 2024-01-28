
using System.Collections.Generic;
using UGTK.Data.DatabaseSystem;
using UnityEngine;

[CreateAssetMenu(fileName = "WorldDatabase", menuName = "ScriptableObjects/WorldDatabase", order = 1)]
public class Mn_WorldDatabase : SO_Database<WorldInfo>
{
    public WorldInfo GetRandomWorldInfo()
    {
        int randomIndex = Random.Range(0, elements.Count);
        return elements[randomIndex].GetInfo();
    }

    public List<WorldInfo> GetThreeDifferentsRandomWorlds()
    {
        List<WorldInfo> selectedObjects = new List<WorldInfo>();

        if (elements.Count < 3)
        {
            Debug.LogError("Not enough elements in the list.");
            return selectedObjects;
        }

        List<WorldInfo> tempList = new List<WorldInfo>();
        
        foreach (DatabaseElement<WorldInfo> element in elements)
        {
            tempList.Add(element.GetInfo());
        }

        for (int i = 0; i < 3; i++)
        {
            int randomIndex = Random.Range(0, tempList.Count);
            selectedObjects.Add(tempList[randomIndex]);
            tempList.RemoveAt(randomIndex);
        }

        return selectedObjects;
    }
    
}
