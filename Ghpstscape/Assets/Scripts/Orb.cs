using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    private float speed = 5f;
    public AnimationClip dead;

    // Start is called before the first frame update
    private void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
    }


    public void OnTriggerEnter2D(Collider2D onHitEnemy)
    {

        //Instantiate(dead, transform.position, transform.rotation);
        if (onHitEnemy.gameObject.tag == "Enemy")
        {
            Destroy(onHitEnemy.gameObject);
            Destroy(gameObject);
            GameManager.ManagerInstance.AddPoints();
        } 
    }
}
