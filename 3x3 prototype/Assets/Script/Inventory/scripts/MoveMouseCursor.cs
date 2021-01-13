using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMouseCursor : MonoBehaviour
{
    public GameObject[] slots;

    public GameObject[] wareHouseSlots;
 
    public Vector2 MousePosition;

    public GameObject cursor;

    public MoveCursor moveCursor;

   

    void Start()
    {
        slots = GameObject.FindGameObjectsWithTag("Slot");

        wareHouseSlots= GameObject.FindGameObjectsWithTag("WareHouseSlot");

    }


    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))    // 마우스 누르기시작할때
        {
            

            for (int i = 0; i < slots.Length; i++)
            {
                if (Input.mousePosition.x >= slots[i].transform.position.x - moveCursor.X_blockSize/2 && Input.mousePosition.x <= slots[i].transform.position.x + moveCursor.X_blockSize/2 && Input.mousePosition.y >= slots[i].transform.position.y - moveCursor.Y_blockSize/2 && Input.mousePosition.y <= slots[i].transform.position.y + moveCursor.Y_blockSize/2)
                {

                    MousePosition.x = slots[i].transform.position.x;
                    MousePosition.y = slots[i].transform.position.y;
                }
            }

            for (int i = 0; i < wareHouseSlots.Length; i++)
            {
                if (Input.mousePosition.x >= wareHouseSlots[i].transform.position.x - moveCursor.X_blockSize / 2 && Input.mousePosition.x <= wareHouseSlots[i].transform.position.x + moveCursor.X_blockSize / 2 && Input.mousePosition.y >= wareHouseSlots[i].transform.position.y - moveCursor.Y_blockSize / 2 && Input.mousePosition.y <= wareHouseSlots[i].transform.position.y + moveCursor.Y_blockSize / 2)
                {

                    MousePosition.x = wareHouseSlots[i].transform.position.x;
                    MousePosition.y = wareHouseSlots[i].transform.position.y;
                }
            }


            transform.Translate(MousePosition.x - transform.position.x,MousePosition.y-transform.position.y,0);
            
            
           

            for (int i = 0; i <= 7; i++)
            {
                Debug.Log(wareHouseSlots[0].transform.position.x + moveCursor.X_blockSize * i);

                if (MousePosition.x == wareHouseSlots[0].transform.position.x + moveCursor.X_blockSize * i)
                {
                    moveCursor.blockX = i;
                }
            }

            



        }
        if (Input.GetMouseButtonUp(0))
        {
            if (moveCursor.blockY == 0)
            {
                if (moveCursor.cursor_Position.y <= wareHouseSlots[8].transform.position.y-moveCursor.Y_blockSize*moveCursor.blockLine)
                {
                    moveCursor.blockY++;
                }
            }

            if (moveCursor.blockY == 1)
            {
                if (moveCursor.blockLine == 1 && moveCursor.cursor_Position.y >= wareHouseSlots[0].transform.position.y - moveCursor.Y_blockSize * moveCursor.blockLine)
                {
                    moveCursor.blockY--;
                }

                if (moveCursor.blockLine == 2 && moveCursor.cursor_Position.y >= wareHouseSlots[0].transform.position.y - moveCursor.Y_blockSize * moveCursor.blockLine)
                {
                    moveCursor.blockY--;
                }
            }
        }

        

    }
}
