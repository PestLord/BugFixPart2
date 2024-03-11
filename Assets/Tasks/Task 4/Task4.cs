using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private Transform _shelfPrefab;
    
    private void Start()
    {
        var wall = Instantiate(_shelfPrefab).gameObject; // Эту строку кода удалять нельзя
        
        Destroy(wall);
    }
}
