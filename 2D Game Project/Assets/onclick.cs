using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class onclick : MonoBehaviour
{
    [SerializeField] GameObject panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        // クリックされた時に行いたい処理
        panel.SetActive(true);
        Debug.Log("押されたよ");

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    }
}
