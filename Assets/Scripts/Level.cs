using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public Button RestartButton;
    public void Restart()
    {
        SceneManager.LoadScene(0);
        GameManager.Score= 0;
    }
}
