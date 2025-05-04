using System;
using UnityEditorInternal;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public GameObject countEn;
    private SpawnE scripte;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        countEn = GameObject.Find("FoorSpawn");
        scripte = countEn.GetComponent<SpawnE>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            scripte.EnemyCount();
        }
    }
}
