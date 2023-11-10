using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depth : MonoBehaviour
{
        SpriteRenderer sprite;

        private void Awake()
        {
                sprite = GetComponent<SpriteRenderer>();
                sprite.sortingOrder = (int)Camera.main.WorldToScreenPoint(this.transform.position).y * -1;
        }
}
