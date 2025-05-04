using UnityEngine;
using UnityEditor;
public class SpawnE : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public  GameObject Enemy;
    public Transform SpawnEn;
    public int enemyCount;
    void Start()
    {
        Invoke("SpawnEnemy",1f);
        Invoke("SpawnEnemy",3f);
        Invoke("SpawnEnemy",5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount == 0)
        {
            EditorApplication.isPlaying = false;
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(Enemy, SpawnEn.position,Quaternion.identity);
    }

    public void EnemyCount()
    {
        enemyCount--;
    }
}
