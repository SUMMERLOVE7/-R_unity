using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    //프레임 시작시 딱 한번 불러져오는 함수
    void Start()
    {
        
    }

    // Update is called once per frame 매 프레임마다 불러져옴
    void Update()
    {
        this.gameObject.transform.Rotate(Vector3.up*10);
    }
}
