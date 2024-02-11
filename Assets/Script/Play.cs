using System;
//using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Play : MonoBehaviour
{
    public Sprite[] allNumImg;
    public Button clickBtn;
    public GameObject[] Prefab;
    public GameObject[] clickBox;
    public GameObject[,] generatedBlock;
    GameObject g;
    string[] tagName = { "red-diamond","1","2","3","4","4","6"};
    int rn;
    int rows = 0, cols = 0;

    // Start is called before the first frame update
    void Start()
    {
        generatedBlock = new GameObject[rows,cols];

        rn = UnityEngine.Random.Range(1, 6);
        clickBtn.GetComponent<Image>().sprite = allNumImg[rn];

        Debug.Log("generate block name = " + allNumImg[rn].name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onlickLine(int n)
    {
        g = Instantiate(Prefab[rn], clickBox[n].transform);
        Start();
    }

    void checkSum(int n)
    {

    }
}
