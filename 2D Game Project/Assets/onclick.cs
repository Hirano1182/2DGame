using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class onclick : MonoBehaviour
{
    [SerializeField] GameObject panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        // �N���b�N���ꂽ���ɍs����������
        panel.SetActive(true);
        Debug.Log("�����ꂽ��");

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
