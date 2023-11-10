using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
        Animator anim;

        [SerializeField] private GameObject logPrefab;
        [SerializeField] private Transform spawnLocation;

        private int timesTillFall;
        private bool hitTriggered;

        private void Awake()
        {
                anim = GetComponent<Animator>();
        }

        public void OnHit()
        {
                if (!hitTriggered)
                {
                        timesTillFall++;
                        if (timesTillFall < 5)
                        {
                                hitTriggered = true;
                                anim.SetTrigger("hit");
                                StartCoroutine(TreeHitDelay());
                        }
                        else if (timesTillFall >= 5)
                        {
                                anim.SetBool("isAlive" , false);
                                SpawnLog();
                        }
                }
        }

        public void SpawnLog()
        {
                GameObject logsToPickUp = Instantiate(logPrefab , spawnLocation.position , Quaternion.identity);
                logsToPickUp.name = "(Resource) ChoppedLogs";
        }

        IEnumerator TreeHitDelay()
        {
                yield return new WaitForSeconds(0.5f);
                hitTriggered = false;
        }
}
