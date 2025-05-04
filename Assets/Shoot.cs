using System;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootPoint;
    public  GameObject target;
    public  Rigidbody2D bulletPrefab;
    public int bulletLimit;
    
    private GameObject targetSpawn;
    private void Start()
    {
        targetSpawn = Instantiate(target,shootPoint.position,Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && bulletLimit > 0)
        {
            // แปลงตำแหน่งเมาส์ในจอ เป็นตำแหน่งในโลก 2D
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 5f, Color.magenta, 5f);
            //ย้ายเป้า
            Vector2 click = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetSpawn.transform.position = click; 
            // คำนวณความเร็วสำหรับการยิง
            Vector2 projectileVelocity = CalculateProjectileVelocity(shootPoint.position, targetSpawn.transform.position, 1f);
            
            // สร้างกระสุนใหม่
            Rigidbody2D firedBullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
            // ใส่ความเร็วให้กระสุน
            firedBullet.linearVelocity = projectileVelocity;
            // ลดกระสุน 
            bulletLimit--;
            
                
        }//GetMouseButtonDown


    }// Update


    // คำนวณความเร็วที่ต้องใช้เพื่อให้ projectile ไปถึงเป้าในเวลาที่กำหนด
    Vector2 CalculateProjectileVelocity(Vector2 origin, Vector2 target, float time)
    {
        Vector2 distance = target - origin;

        float velocityX = distance.x / time;
        float velocityY = distance.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y) * time;

        return new Vector2(velocityX, velocityY);

    }///CalculateProjectileVelocity



}//Projectile2D
