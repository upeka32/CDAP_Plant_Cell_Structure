using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttonClick : MonoBehaviour
{
    public void changemenuscene(int index){
		
	SceneManager.LoadScene(index);
	}
}
