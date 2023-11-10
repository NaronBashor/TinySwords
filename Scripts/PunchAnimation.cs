using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class PunchAnimation : MonoBehaviour
{
        public void BuildingHit()
        {
                transform.DOPunchPosition(new Vector3(0f , .125f , 0f) , .125f).Play();
        }
}
