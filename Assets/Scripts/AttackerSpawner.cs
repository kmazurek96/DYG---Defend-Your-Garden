using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] Attacker[] attackerPrefab;
    [SerializeField] float minTimeBetweenSpawn = 1f;
    [SerializeField] float maxTimeBetweenSpawn = 5f;

    private IEnumerator Start()
    {
            while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minTimeBetweenSpawn, maxTimeBetweenSpawn));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        var attackerIndexToSpawn = Random.Range(0, attackerPrefab.Length);
        Attacker newAttacker = Instantiate(attackerPrefab[attackerIndexToSpawn], transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
