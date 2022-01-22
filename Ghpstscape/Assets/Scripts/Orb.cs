using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    private float speed = 5f;
    private Animator animator;
    private GameObject enemy;

    // Start is called before the first frame update
    private void Start()
    {
        
        this.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        animator = enemy.GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D onHitEnemy)
    {
        AnimatorUpdateMode();

        if (onHitEnemy.gameObject.tag == "Enemy")
        {
            Destroy(onHitEnemy.gameObject);
            Destroy(gameObject);
            GameManager.ManagerInstance.AddPoints();
        } 
    }

    public void AnimatorUpdateMode()
    {
        animator.SetBool("isDead", true);
    }
}