using UnityEngine;
public class DestroySpawnerIfDead : MonoBehaviour
{
    public GameObject spawner;
    // Start is called before the first frame update
    public void stopSpawn()
    {
        spawner.SetActive(false);
    }
}