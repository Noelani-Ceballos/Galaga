using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
   
   public float speed = 2.0f;   

    Rigidbody2D rigidbody2d;

    float horizontal;

     Vector2 lookDirection = new Vector2(1,0);

     public GameObject projectilePrefab; 

    // Start is called before the first frame update
    void Start()
    {
         rigidbody2d = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        
        Vector2 position = transform.position;
       
         position.x = position.x + speed * horizontal * Time.deltaTime;

         transform.position = position;

         if (Input.GetKeyDown(KeyCode.C))
         {
            Launch();
         }

         void Launch()
        {
           GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 1.3f, Quaternion.identity);

           Projectile projectile = projectileObject.GetComponent<Projectile>();

            projectile.Launch( Vector2.up, 300);

        }
       
    
    }
}
