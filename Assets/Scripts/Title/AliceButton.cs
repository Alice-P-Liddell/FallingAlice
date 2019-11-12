using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AliceButton : MonoBehaviour
{
    public void AliceClick()
    {
        SceneManager.LoadScene("Closet");
    }
}
