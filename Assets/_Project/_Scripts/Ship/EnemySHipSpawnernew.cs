using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;

public class EnemySHipSpawnernew : EnemyShipSpawner
{
    [SerializeField] Transform[] _waypoints;
  
    
    public override void SpawnShips(Transform planetTransform)
    {
        base.SpawnShips(planetTransform);
        var ship = Instantiate(SpawnObjectPrefab, (Vector2)_waypoints[Random.Range(0, SpawnPoints.Length)].position + Random.insideUnitCircle * _spawnRadius, Quaternion.identity).GetComponent<EnemynewShip>();
        ship.Init(planetTransform,_waypoints);

      
    }

}
