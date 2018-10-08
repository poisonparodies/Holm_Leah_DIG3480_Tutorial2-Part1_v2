using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //update is just after frame, fixedupdate is right beofore, for physics
    private Rigidbody2D rb2d;
    public float speed;
    private int count;
    public Text CountText;
    public Text WinText;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
        WinText.text = "";
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //Input.GetAxis
        //float record the results from getaxis (input from keyboard)
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce (movement*speed);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }

    void SetCountText(){
        CountText.text = "Count: " + count.ToString();
        if (count >= 12)
            WinText.text = "You Win!!";
    }

    private void Update()
    {
        if(Input.GetKeyDown("escape")) {
            Application.Quit();
        }
    }

}
