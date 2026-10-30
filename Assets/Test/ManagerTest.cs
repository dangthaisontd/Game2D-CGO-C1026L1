
using UnityEngine;
public class ManagerTest : MonoBehaviour
{
    
    private void Start()
    {
        string[] player = { "Binh", "An", "May", "Man" };
        foreach (var item in player)
        {
            Debug.Log(item);
        }
    }
}
