using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementScript : MonoBehaviour
{
    [SerializeField] private string sceneName;
    // Start is called before the first frame update
    public void LoadScene(){
        SceneManager.LoadScene(sceneName);
    }
}
