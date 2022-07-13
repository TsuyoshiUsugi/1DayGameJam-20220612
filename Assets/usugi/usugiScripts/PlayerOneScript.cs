using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOneScript : MonoBehaviour
{
    public GameObject ballPrefab;
    public float moveSpeed;
    private float playerPosXClamp = 5f;
    private float playerPosYClamp = 3.5f;
    AudioSource audioSource;
    public AudioClip throwBall;
    public AudioClip die;

    float interval;
    private Vector2 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        MovingRestrictions();

        Shoot();

        interval -= Time.deltaTime;
        if (interval < 0)
        {
            interval = 0;
        }
    }

    private void Move()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("left"))
        {
            position.x -= moveSpeed;
            
        }
        else if (Input.GetKey("right"))
        {
            position.x += moveSpeed;
        }
        else if (Input.GetKey("up"))
        {
            position.y += moveSpeed;
        }
        else if (Input.GetKey("down"))
        {
            position.y -= moveSpeed;
        }

        transform.position = position;

    }

    void MovingRestrictions()
    {
        //•Ï”‚ÉŽ©•ª‚Ì¡‚ÌˆÊ’u‚ð“ü‚ê‚é
        this.playerPos = transform.position;

        //playerPos•Ï”‚Ìx‚Æy‚É§ŒÀ‚µ‚½’l‚ð“ü‚ê‚é
        //playerPos.x‚Æ‚¢‚¤’l‚ð-playerPosXClamp`playerPosXClamp‚ÌŠÔ‚ÉŽû‚ß‚é
        this.playerPos.x = Mathf.Clamp(this.playerPos.x, 0, 8.15f);
        this.playerPos.y = Mathf.Clamp(this.playerPos.y, -this.playerPosYClamp, this.playerPosYClamp);

        transform.position = new Vector2(this.playerPos.x, this.playerPos.y);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball2")
        {
            audioSource.PlayOneShot(die);
            FadeManager.Instance.LoadScene("ResultScene", 1.0f);
            ResultText.win = 2;
        }
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.RightShift) && interval == 0)
        {
            audioSource.PlayOneShot(throwBall);
            Instantiate(ballPrefab, new Vector3(transform.position.x -1, transform.position.y, 0) , ballPrefab.transform.rotation);
            interval = 1;
        }
    }
}
