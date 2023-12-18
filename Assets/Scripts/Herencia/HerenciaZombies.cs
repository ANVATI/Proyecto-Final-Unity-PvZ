using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HerenciaZombies : MonoBehaviour
{
    protected int life;
    protected int damage;
    protected float speedX;
    public float directionX;
    private Rigidbody2D _compRigidbody;
    public GameManagerControl gameManager;
    private Animator _compAnimator;
    private bool isAttacking = false;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        _compAnimator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speedX * directionX, 0);

    }

    public void ReduceLife(int amount)
    {
        life = life - amount;
        if (life <= 0)
        {
            gameManager.UpdatePoints(1);
            _compAnimator.SetTrigger("Die");
            Destroy(this.gameObject, 2);
            GetComponent<BoxCollider2D>().enabled = false;
            directionX = 0;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Plantas") && !isAttacking)
        {
            directionX = 0;
            PlantasHerencia planta = collision.gameObject.GetComponent<PlantasHerencia>();
            planta.RecibirDaño(100);
            isAttacking = true;
            _compAnimator.SetBool("IsAttacking", true);

        }
        if (collision.CompareTag("Nuez") && !isAttacking)
        {
            directionX = 0;
            isAttacking = true;
            _compAnimator.SetBool("IsAttacking", true);
        }

        if (collision.CompareTag("Lose"))
        {
            SceneManager.LoadScene("Lose");
        }
        if (collision.CompareTag("Destructor"))
        {
            Destroy(this.gameObject);
        }
        else
        {

        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Plantas"))
        {
            isAttacking = false;
            _compAnimator.SetBool("IsAttacking", false);
            directionX = -1;
        }
        if (collision.CompareTag("Nuez"))
        {
            isAttacking = false;
            _compAnimator.SetBool("IsAttacking", false);
            directionX = -1;
        }
    }
}

