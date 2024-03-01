using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    public bool isRoom = true;
    public GameObject[] rooms = { };
    public int index;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i].activeInHierarchy)
            {
                index = i;
            }
        }
    }

    public void RightBackgroundChanger()
    {
        if (index < rooms.Length - 1)
        {
            index++;
            rooms[index - 1].SetActive(false);
            rooms[index].SetActive(true);
        }
    }

    public void LeftBackgroundChanger()
    {
        if (index > 0)
        {
            index--;
            rooms[index + 1].SetActive(false);
            rooms[index].SetActive(true);
        }
    }
}