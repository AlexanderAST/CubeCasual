using UnityEngine.SceneManagement;
using UnityEngine;

public class Back1 : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.B))
        {
            SceneManager.LoadScene(0);
        }
    }
}
