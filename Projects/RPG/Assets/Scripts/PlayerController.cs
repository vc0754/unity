using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;

    public float timeInvincible = 2.0f;
    float invincibleTimer;
    bool isInvincible;

    public int maxHP = 5;
    public int HP { get { return currentHP; }}
    int currentHP;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    Animator animator;
    Vector2 direction = new Vector2(1, 0);

    // Start is called before the first frame update
    void Start()
    {
        // 更改每秒渲染帧数
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 36;
        
        rigidbody2d = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();

        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // Vector2 position = transform.position;
        // position.x = position.x + speed * horizontal * Time.deltaTime;
        // position.y = position.y + speed * vertical * Time.deltaTime;
        // transform.position = position;

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0) isInvincible = false;
        }

        Vector2 move = new Vector2(horizontal, vertical);
        if(!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            direction.Set(move.x, move.y);
            direction.Normalize();
        }
        
        animator.SetFloat("Move X", direction.x);
        animator.SetFloat("Move Y", direction.y);
        animator.SetFloat("Speed", move.magnitude);

        // animator.SetFloat("Move X", horizontal);
        // animator.SetFloat("Move Y", vertical);
    }

    // Unity 还有另一个名为 FixedUpdate 的函数，只要你想直接影响物理组件或对象（例如刚体），就需要使用该函数。
    // FixedUpdate 不会持续运行
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }

    public void ChangeHP(int amount)
    {
        if (amount < 0) {
            if (isInvincible) return;
            isInvincible = true;
            invincibleTimer = timeInvincible;
        }
        currentHP = Mathf.Clamp(currentHP + amount, 0, maxHP);
        Debug.Log(currentHP);
    }
}
