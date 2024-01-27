using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class Mn_TomatoSpawner : MonoBehaviour
{
    [FormerlySerializedAs("EachTimeTomatoSpawn")] [SerializeField] private float TomatoSpawnDelay = 2;
    [SerializeField] private Mn_ShooterComponent ShooterComponent;

    [SerializeField] private GameObject TargetToShot;
    
    private void Start()
    {
        StartCoroutine(SpawnTomato());
    }
    
    private IEnumerator SpawnTomato()
    {
        while (true)
        {
            yield return new WaitForSeconds(TomatoSpawnDelay);
            Vector3 directionVectorNormalized = (TargetToShot.transform.position - transform.position).normalized;

            ShooterComponent.ShootSingleProjectile(directionVectorNormalized);
        }
    }
}
