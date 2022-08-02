using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fly_once : MonoBehaviour
{
    Rigidbody2D rg;
    bool alive = true;
    public Text countText;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        print(alive);
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive == true)
        {
            rg.velocity = new Vector2(0, 5f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Rigidbody2D>().freezeRotation = true; 
        if (collision.gameObject.CompareTag("coin"))
        {
            collision.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        } else if (collision.gameObject.CompareTag("pip"))
        {
            alive = false;
            print(alive);
        }
    }



    void SetCountText()
    {
        countText.text = " " + count.ToString();
    }
}
