using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    private Button _PlayButton;

    void Start()
    {
        _PlayButton = GetComponent<Button>();
        _PlayButton.onClick.AddListener(Play);
    }

    public void Play()
    {
        SceneManager.LoadScene("BurstScene");
    }
}
