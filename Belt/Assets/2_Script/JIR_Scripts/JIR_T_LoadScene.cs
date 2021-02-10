﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JIR_T_LoadScene : MonoBehaviour
{
    JIR_TraningConveyorManager ir_T_cm;

    public GameObject dataMgr;
    public GameObject trainingInstruction;

    private void Awake()
    {
        ir_T_cm = GameObject.Find("ConveyorManager").GetComponent<JIR_TraningConveyorManager>();
        trainingInstruction.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ir_T_cm.isStopMoving == true)
        {
            Destroy(dataMgr);
            //JIR_LoadingScene.Instance.LoadScene("BeltTest_S1");
            //SceneManager.LoadScene(1);
            trainingInstruction.SetActive(true);
        }

    }
}