using UnityEngine;

public class LockToEnemy : MonoBehaviour
{
    
    public Transform targetPrefabInstance;

    void Start()
    {
        
    }

    void Update()
    {
        if (targetPrefabInstance != null)
        {
            transform.LookAt(targetPrefabInstance);
        }
    }
}
