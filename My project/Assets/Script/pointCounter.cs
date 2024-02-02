using UnityEngine;
using TMPro;
public class pointCounter : MonoBehaviour
{
    public int points;
    public TextMeshProUGUI text;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "point")
        {
            points++;
            text.text = points.ToString();
        }
    }
}