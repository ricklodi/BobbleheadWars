using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Alien : MonoBehaviour
{
    public Transform target;
    public float navigationUpdate;
    private float navigationTime = 0;
    private NavMeshAgent agent;
    public UnityEvent OnDestroy;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void OnTriggerEnter(Collider other)
    {
        Die();
        SoundManager.Instance.PlayOneShot(SoundManager.Instance.alienDeath);
    }
    void Update()
    {
        if (target != null)
        {
            navigationTime += Time.deltaTime;
            if (navigationTime > navigationUpdate)
            {
                agent.destination = target.position;
                navigationTime = 0;
            }
        }
    }
    public void Die()
    {
        OnDestroy.Invoke();
        OnDestroy.RemoveAllListeners(); //Removing listener to prevent memory leark
        Destroy(gameObject);
    }
}
