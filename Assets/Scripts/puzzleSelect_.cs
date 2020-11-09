using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzleSelect_ : MonoBehaviour
{
    public GameObject StartPanel;
    public void SetPuzzlesPhoto(Image Photo)
    {
        for (int i = 0; i < 36;i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
        StartPanel.SetActive(false);
    }
}
