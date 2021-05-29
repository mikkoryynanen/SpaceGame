using UnityEngine;

public class Shooter : MonoBehaviour 
{
    public float firerate = 1f;
    public GameObject projectilePrefab;
    
    float _shootTimer;

    void Update() 
    {
        _shootTimer += Time.deltaTime;
        if (_shootTimer > firerate)
        {
            _shootTimer = 0;

            GameObject go = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }    
}