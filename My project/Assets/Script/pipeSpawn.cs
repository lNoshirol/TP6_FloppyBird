using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class pipeSpawn : MonoBehaviour
{
    public GameObject pipePrefab;
    [SerializeField] int spawnX;
    private AudioSource tonkFire;
    [SerializeField] AudioClip _tonkFire;
    private bool AlreadyStartOnce = false;
    public List<GameObject> spawnList = new List<GameObject>();
    void Start()
    {
        tonkFire = GetComponent<AudioSource>();
        tonkFire.clip = _tonkFire;
        StartCoroutine(Spawn());
    }
    private void OnEnable()
    {
        if (AlreadyStartOnce)
        {
            StartCoroutine(Spawn());
        }
    }
    IEnumerator Spawn()
    {
        GameObject pipe = Instantiate(pipePrefab);
        pipe.transform.position = new Vector2(spawnX, Random.Range(0f, 5f));
        pipe.AddComponent<pipeMove>();
        spawnList.Add(pipe);
        tonkFire.Play();
        AlreadyStartOnce = true;
        yield return new WaitForSeconds(3.5f); StartCoroutine(Spawn());
    }
}