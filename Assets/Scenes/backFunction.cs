using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backFunction : MonoBehaviour
{
    public void BacktoHome() {

        SceneManager.LoadScene("Home");
    }
}
