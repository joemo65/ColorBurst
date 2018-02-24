using UnityEngine;
using UnityEngine.UI;

public class RainbowColorTextScript : MonoBehaviour
{
    public float RedSpeed = 1;
    public float GreenSpeed = 1;
    public float BlueSpeed = 1;

    private Text _Text;

    void Start()
    {
        _Text = GetComponent<Text>();
    }

    void Update()
    {
        var red = Mathf.PingPong(Time.time * RedSpeed, 1);
        var green = Mathf.PingPong(Time.time * GreenSpeed, 1);
        var blue = Mathf.PingPong(Time.time * BlueSpeed, 1);
        _Text.color = new Color(red, green, blue);
    }
}
