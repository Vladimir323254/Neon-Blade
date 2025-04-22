
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sp;
    private PlayerMovement playerMovement;
    private Shooter shooter;
    private bool facingRight = true;
    [SerializeField] private Animator anim;
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        shooter = GetComponent<Shooter>();
    }
    private void Update()
    {
        float horizontalDirection = Input.GetAxisRaw(GlobalStringVars.HORIZONTAL_AXIS);
        bool isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars.JUMP);

        if(Input.GetButtonDown(GlobalStringVars.FIRE_1))
        {
            anim.SetBool("isAttack", true);
            Invoke("Shoot", 1.0f);
        }
            

        playerMovement.Move(horizontalDirection, isJumpButtonPressed);
        float moveInput = Input.GetAxis("Horizontal");
        if (moveInput > 0 && !facingRight)
        {
            Flip();
        }
        else if (moveInput < 0 && facingRight)
        {
            Flip();
        }

    }
    public void Shoot()
    {
        float horizontalDirection = Input.GetAxisRaw(GlobalStringVars.HORIZONTAL_AXIS);
        shooter.Shoot(horizontalDirection);
        anim.SetBool("isAttack", false);
    }
    void Flip()
    {
        facingRight = !facingRight;
        sp.flipX = !sp.flipX;
    }
}
