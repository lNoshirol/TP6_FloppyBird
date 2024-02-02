using UnityEngine;
public class Floppy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Vector2 _Vector;
    private AudioSource metalPipeFall;
    [SerializeField] AudioClip _metalPipeFall;
    public GameObject deathPanel;
    public GameObject spawner;
    public GameObject destroySprite;
    public bool isDead;
    void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody2D>();
        _Vector = new Vector2(0, 1);
        metalPipeFall = GetComponent<AudioSource>();
        metalPipeFall.clip = _metalPipeFall;
        isDead = false;
    }
    void Update()
    {
        jump();
    }
    void jump()
    {
        if (transform.localPosition.y < 4)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rb.velocity = new Vector2(0, 0);
                _rb.AddForce(_Vector * 300);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "APFSDS")
        {
            
            DestroyFloppy();
        }
    }
    private void DestroyFloppy()
    {
        if (isDead == false)
        {
            metalPipeFall.Play();
        }
        isDead = true;
        deathPanel.SetActive(true);
        destroySprite.SetActive(true);
        spawner.SetActive(false);
    }
}