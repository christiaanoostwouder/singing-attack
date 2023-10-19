using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Tower : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private float shootinterval = 1;
    [SerializeField]private GameObject projectilePrefab;


    

    void Start()
    {
        StartCoroutine(Shoot());
    }

    
    void Update()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
        if (targets.Length == 0)
        {
            return;
        }
        target = targets[0].transform;
        LookAtTarget(target);
        
    }

    public void LookAtTarget(Transform target)
    {
        Vector2 direction = target.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
    }

    IEnumerator Shoot()
    {
        
        while (true)
        {
            yield return new WaitForSeconds(shootinterval);
            GameObject projectileGameObject = Instantiate(projectilePrefab);
            Projectile projectile = projectileGameObject.GetComponent<Projectile>();
            projectile.target = target;
        }

    }
}
