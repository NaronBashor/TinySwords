using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnController : MonoBehaviour
{
        Animator anim;
        Rigidbody2D rb;

        [SerializeField] private float moveSpeed;
        [SerializeField] private float buildSpeed;
        [SerializeField] private float rockSpeed;
        [SerializeField] private float goldSpeed;
        [SerializeField] private float chopSpeed;

        Vector2 mousePos;

        Vector3 pos;
        Vector3 newPos;

        private void Awake()
        {
                anim = GetComponent<Animator>();
                rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
                // TODO - add this movement to UI button instead of here
                if (Input.GetMouseButton(0))
                {
                        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        MoveToAction(mousePos);
                }

                newPos = this.transform.position - pos;
                pos = this.transform.position;

                if (newPos != Vector3.zero)
                {
                        anim.SetBool("isMoving" , true);
                }
                else
                {
                        anim.SetBool("isMoving" , false);
                }
        }

        public void MoveToAction(Vector2 destination)
        {
                this.transform.DOMove(destination , moveSpeed / (destination.magnitude));
                Debug.Log(destination.magnitude);
        }
}
