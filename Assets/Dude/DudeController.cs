using UnityEngine;

public class DudeController : MonoBehaviour
{
    public float RunSpeed;
    public float JumpSpeed;
    public Transform BulletPrefab;
    public Transform BulletSpawn;

    private Rigidbody2D _rigidBody;
    private Animator _animator;

    // Use this for initialization
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");

        _rigidBody.AddForce(new Vector2(xMove * RunSpeed, 0));

        if (Input.GetButton("Jump"))
        {
            _rigidBody.AddForce(new Vector2(0, JumpSpeed));
            _animator.SetTrigger("Jump");
        }
    }
}
