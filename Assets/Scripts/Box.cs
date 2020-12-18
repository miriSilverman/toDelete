using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{

    private Vector3 _offset;

    [SerializeField] private GameObject player;
    
    [SerializeField] private GameObject center;
    [SerializeField] private GameObject up;
    [SerializeField] private GameObject down;
    [SerializeField] private GameObject left;
    [SerializeField] private GameObject right;
    [SerializeField] private float step = 9f;
    [SerializeField] private float speed = 0.01f;
    private bool _input = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_input)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _input = false;
                // for (int i = 0; i < 90/step; i++)
                // {
                    // player.transform.RotateAround(up.transform.position, Vector3.right, step*Time.deltaTime);
                // }

                // center.transform.position = player.transform.position;
                // _input = true;
                StartCoroutine(MoveUp());
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                _input = false;
                StartCoroutine(MoveDown());
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                _input = false;
                StartCoroutine(MoveLeft());
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                _input = false;
                StartCoroutine(MoveRight());
            }
        }
    }


    IEnumerator MoveUp()
    {
        for (int i = 0; i < 90/step; i++)
        {
            player.transform.RotateAround(up.transform.position, Vector3.right, step);
            yield return new WaitForSeconds(speed);
        }

        center.transform.position = player.transform.position;
        _input = true;

    }
    
    IEnumerator MoveDown()
    {
        for (int i = 0; i < 90/step; i++)
        {
            player.transform.RotateAround(down.transform.position, Vector3.left, step);
            yield return new WaitForSeconds(speed);
        }

        center.transform.position = player.transform.position;
        _input = true;

    }
    
    
    IEnumerator MoveLeft()
    {
        for (int i = 0; i < 90/step; i++)
        {
            player.transform.RotateAround(left.transform.position, Vector3.forward, step);
            yield return new WaitForSeconds(speed);
        }

        center.transform.position = player.transform.position;
        _input = true;

    }
    
    
    IEnumerator MoveRight()
    {
        for (int i = 0; i < 90/step; i++)
        {
            player.transform.RotateAround(right.transform.position, Vector3.back, step);
            yield return new WaitForSeconds(speed);
        }

        center.transform.position = player.transform.position;
        _input = true;
    }
    
}
