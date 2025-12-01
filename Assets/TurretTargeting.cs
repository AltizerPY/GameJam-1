using UnityEngine;

public class TurretTargeting : MonoBehaviour
{
    
    private Transform targetTransform;
    public GameObject EnemyPrefab;

    void Start()
    {
        

        if (EnemyPrefab)
        {
            targetTransform = EnemyPrefab.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (targetTransform)
        {
            transform.LookAt(targetTransform.position);
        }
    }
}
