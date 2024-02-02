using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class restart : MonoBehaviour
{
    public GameObject floppy;
    public GameObject floppyKaboum;
    public GameObject Spawner;
    private List<GameObject> _spawnerPipeList;
    public TextMeshProUGUI scoreText;
    private void Start()
    {
        _spawnerPipeList = Spawner.GetComponent<pipeSpawn>().spawnList;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Restart();
        }
    }
    public void Restart()
    {
        Spawner.GetComponent<pipeSpawn>().spawnList.Clear();
        floppy.GetComponent<Floppy>().isDead = false;
        floppy.GetComponent<pointCounter>().points = 0;
        scoreText.text = "0";
        floppy.transform.position = new Vector2(-1.05f, 0);
        floppyKaboum.SetActive(false);
        gameObject.SetActive(false);
        Spawner.SetActive(true);
    }
}