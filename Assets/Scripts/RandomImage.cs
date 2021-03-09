using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomImage : MonoBehaviour
{
    public Sprite[] images;
    public Image imageContainer;

    void Start()
    {
        int num = Random.Range(0, images.Length);

        imageContainer.sprite = images[num];
    }
}
