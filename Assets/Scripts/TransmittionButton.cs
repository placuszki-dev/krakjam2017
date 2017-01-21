﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmittionButton : MonoBehaviour {
    [SerializeField]
    Sprite onSprite;

    [SerializeField]
    Sprite offSprite;

    bool transmitting;

    void Start()
    {
        transmitting = false;
        ChangeToOFF();
    }

    void OnMouseDown()
    {
        Sprite currentSprite = GetComponent<SpriteRenderer>().sprite;

        if (currentSprite.Equals(onSprite))
        {
            GetComponent<SpriteRenderer>().sprite = offSprite;
            ChangeToON();
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = onSprite;
            ChangeToON();
        }
    }

    public bool isTransmitting()
    {
        return transmitting;
    }

    public void ChangeToON()
    {
        GetComponent<SpriteRenderer>().sprite = onSprite;
        transmitting = true;
    }

    public void ChangeToOFF()
    {
        GetComponent<SpriteRenderer>().sprite = offSprite;
        transmitting = false;
    }

}
