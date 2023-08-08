using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gravity_Spawner : MonoBehaviour
{
    private float x = 0;
    [SerializeField] private GameObject teros;
    [SerializeField] private GameObject spawner;
    [SerializeField] private Transform spawn;
    [SerializeField] private float wait_Time = 1;
    private void Start()
    {
        
    }
    private void Update()
    {
        x = Random.Range(0, 2);
        if (x >= 1)
        {
            Debug.Log(x);
            Instantiate(teros, spawn.position, Quaternion.identity);

        }
        Debug.Log(x);

    }

    private void Spawner()
    {
     
       
    }

    IEnumerator Spawn_Wait()
    {
        yield return new WaitForSeconds(wait_Time);
    }
}
