using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet_prefab;
    public float spawn_rate_min = 0.5f;
    public float spawn_rate_max = 3f;

    Transform target;
    float spawn_rate;
    float time_after_spawn;
    // Start is called before the first frame update
    void Start()
    {
        time_after_spawn = 0;
        spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max); 
        target = FindObjectOfType<PlayerController>().transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        time_after_spawn += Time.deltaTime;

        if (time_after_spawn >= spawn_rate)
        {
            time_after_spawn = 0;

            GameObject bullet
                = Instantiate(bullet_prefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        }
        
    }
}
