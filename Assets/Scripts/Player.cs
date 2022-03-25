using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        gameObject.transform.position = new Vector2(transform.position.x + (h * speed *Time.deltaTime), transform.position.y);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Colliding with Coin");
        }

        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Colling with Enemy");
        }
    }
}
 