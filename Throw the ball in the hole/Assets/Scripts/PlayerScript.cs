using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject ballPrefab;
    public Camera cam;
    public float power;
    public float maxCooldown;
    private float currentCooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentCooldown <= 0){
            currentCooldown = maxCooldown;
            ThrowBall();
        }

        if (currentCooldown > 0)
        {
            currentCooldown -= Time.deltaTime;
        }
    }

    void ThrowBall()
    {
        GameObject newBall = Instantiate(ballPrefab, gameObject.transform);
        Rigidbody2D rigidBody = newBall.GetComponent<Rigidbody2D>();
        Vector2 playerPosition = gameObject.transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - playerPosition).normalized;

        rigidBody.velocity = direction * power;
    }

}
