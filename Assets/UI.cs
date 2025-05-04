using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject[] bullets;
    private int bulletCounter;
    private Shoot bulletcount;

    void Start()
    {
        bulletcount = GetComponent<Shoot>();
    }


    void Update()
    {
        bulletCounter = bulletcount.bulletLimit;
        for (int a = 0; a < bullets.Length; a++)
        {
            if (a < bulletCounter)
            {
                bullets[a].SetActive(true);
            }
            else
            {
                bullets[a].SetActive(false);
            }
        }
        
  
    }
}
