using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LinkButton : MonoBehaviour
{
    public void GOlink()
    {
        SceneManager.LoadScene("Links");
    }
}
