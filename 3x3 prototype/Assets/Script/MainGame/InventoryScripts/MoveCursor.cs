﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCursor : MonoBehaviour
{
    float X_blockSize;
    float Y_blockSize;
    float time;
    float scroll_line_size;
    public float blockLine;
    public float bottom_count = 0;




    int blockX;
    int blockY;
    // Start is called before the first frame update

    public GameObject cursor;

    public GameObject scrollbar;

    public Vector3 cursor_Position;

    public Vector3 scrollbar_Position;



    void Start()
    {

        X_blockSize = 180f;
        Y_blockSize = 150f;
        blockLine = 0;
        scroll_line_size = 155f;
        time = 0f;
        blockX = 0;
        blockY = 0;

    }

    // Update is called once per frame
    void Update()
    {

        scrollbar_Position = scrollbar.transform.position;
        cursor_Position = cursor.transform.position;
        time += Time.deltaTime;
        if (time >= 0.1f)
        {
            move();

            if (blockLine >= 0 && blockLine <= 2)
            {
                moveScrollbar();
            }
            if (blockLine < 0 || blockLine > 2)
            {
                TeleportScrollbar();
            }

            time = 0f;
        }



        if (blockY == 1)
        {
            bottom_count = 1;
        }
        if (blockY == 0)
        {
            bottom_count = 0;
        }





    }

    void move()
    {
        Vector3 movePos = Vector3.zero;
        if (Input.GetAxisRaw("Vertical") > 0 && blockY > 0)
        {   // 화살표위쪽키 입력 
            transform.Translate(new Vector3(0f, 1f * Y_blockSize, 0f));
            blockY--;
        }

        if (Input.GetAxisRaw("Vertical") < 0 && blockY < 1)
        {   // 화살표밑쪽키 입력
            transform.Translate(new Vector3(0f, -1f * Y_blockSize, 0f));
            blockY++;
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {// 화살표오른쪽키 입력
            if (blockX >= 0 && blockX < 8)
            {
                transform.Translate(new Vector3(1f * X_blockSize, 0f, 0f));
                blockX++;
            }
            if (blockX > 7)
            {
                transform.Translate(new Vector3(-8f * X_blockSize, 0f, 0f));
                blockX = 0;
            }
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            // 화살표왼쪽키 입력
            if (blockX >= -1 && blockX < 8)
            {
                transform.Translate(new Vector3(-1f * X_blockSize, 0f, 0f));
                blockX--;
            }

            if (blockX < 0)
            {
                transform.Translate(new Vector3(8f * X_blockSize, 0f, 0f));
                blockX = 7;
            }
        }
    }

    void moveScrollbar()
    {
        if (Input.GetAxisRaw("Vertical") < 0 && bottom_count == 1 && blockLine >= -1)
        {
            scrollbar.transform.Translate(0, scroll_line_size, 0);
            blockLine++;
        }

        if (Input.GetAxisRaw("Vertical") > 0 && bottom_count == 0 && blockLine <= 3)
        {
            scrollbar.transform.Translate(0, -scroll_line_size, 0);
            blockLine--;
        }
    }

    void TeleportScrollbar()
    {
        if (Input.GetAxisRaw("Vertical") < 0 && bottom_count == 1)
        {
            scrollbar.transform.Translate(0, -3f * scroll_line_size, 0);
            cursor.transform.Translate(0, 1f * Y_blockSize, 0);
            blockY = 0;
            blockLine = 0;
        }

        if (Input.GetAxisRaw("Vertical") > 0 && bottom_count == 0)
        {
            scrollbar.transform.Translate(0, 3f * scroll_line_size, 0);
            cursor.transform.Translate(0, -1f * Y_blockSize, 0);
            blockY = 1;
            blockLine = 2;
        }

    }
}