using UnityEngine;

public class Player : MonoBehaviour
{
    #region Váriaveis privadas
    Rigidbody2D rig;
    bool isJumping = false;
    bool isRunning = false;
    int jumpNumbers = 0;
    #endregion
    #region Váriaveis publicas
    public float Speed;
    public int MaxJumps;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isJumping)
            Move();
        Jump();
    }

    void Move(float vertical = 0f)
    {
        var horizontal = Input.GetAxis("Horizontal");
        isRunning = horizontal != 0;
        var movement = new Vector3(horizontal, vertical, 0);
        transform.position += movement * Time.deltaTime * Speed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && (!isJumping && jumpNumbers <= MaxJumps))
        {
            rig.AddForce(new Vector2(0, 155));
            jumpNumbers++;
        }
        else
            jumpNumbers = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = !collision.gameObject.CompareTag("Ground");        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isJumping = collision.gameObject.CompareTag("Ground");
    }
}
