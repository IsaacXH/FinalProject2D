using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 3.0f;
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    public int MaxAmmo = 5;
    public int CurrentAmmo;
    public int MaxHealth = 3;
    public int CurrentHealth;
    public bool isdead = false;
    public static PlayerController instance;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        CurrentAmmo = MaxAmmo;
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 move = new Vector2(horizontal, vertical);
        
        if (Input.GetKeyDown(KeyCode.C) && CurrentAmmo > 0)
        {
            Launch();
            PlayerController controller = GetComponent<PlayerController>();

            if (controller != null)
            {
                controller.ChangeAmmo(-1);
            }
        }
        if(CurrentHealth == 0)
        {
            isdead = true;
        }
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        
        rigidbody2d.MovePosition(position);
    }
   
    void Launch()
    {
        
        
            GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

            Projectile projectile = projectileObject.GetComponent<Projectile>();
            

            
        
    }
    public void ChangeAmmo(int amount)
    {
        CurrentAmmo = Mathf.Clamp(CurrentAmmo + amount, 0, MaxAmmo);
        Debug.Log(CurrentAmmo + "/" + MaxAmmo);
    }
    public void ChangeHealth(int amount)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + amount, 0, MaxHealth);
        HealthBar.instance.SetValue(CurrentHealth / (float)MaxHealth);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}

