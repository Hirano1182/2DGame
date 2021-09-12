using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class 再開 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RETRY()//ここに書いた文字「Retry」が選択画面で表示される
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
