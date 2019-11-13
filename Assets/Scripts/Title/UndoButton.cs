using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UndoButton : MonoBehaviour
{
    public void ClickUndoButton()
    {
        SceneManager.LoadScene("Title");
    }
}
