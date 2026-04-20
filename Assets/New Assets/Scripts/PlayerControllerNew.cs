using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerNew : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private Vector2 movementInput;
    public GameObject camera;
    public GameObject battleScene;
    public BattleSystem battleScript;
    public GameObject worldMusic;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInput.x = Input.GetAxisRaw("Horizontal");
        // Either the inputs A/D or the horizontal arrow keys can work.
        movementInput.y = Input.GetAxisRaw("Vertical");
        // Either the inputs W/S or the vertical arrow keys can work.
        //camera.transform.position = new Vector3(transform.position.x, transform.position.y, -15.39f);
    }

    void FixedUpdate()
    {
        rb.velocity = movementInput * moveSpeed;
    }

    void OnTriggerEnter(Collider other)
    {
        battleScene.SetActive(true);
        worldMusic.SetActive(false);
    }

    public void Attack()
    {
        battleScript.damageAmount = Random.Range(1,5);
        battleScript.enemyHealth -= battleScript.damageAmount;
        battleScript.inBattleText.text = "Player slashes enemy! " + battleScript.damageAmount + " damage dealt!";

    }
}
