using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class end_score : MonoBehaviour
{

    public TextMeshProUGUI scoreFinal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void end_Score()
    {
        scoreFinal.text = GetComponent<GameManager>().endscore;
    }

}
