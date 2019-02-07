//=============================================================================================================================
//
// Copyright (c) 2015-2017 VisionStar Information Technology (Shanghai) Co., Ltd. All Rights Reserved.
// EasyAR is the registered trademark or trademark of VisionStar Information Technology (Shanghai) Co., Ltd in China
// and other countries for the augmented reality technology developed by VisionStar Information Technology (Shanghai) Co., Ltd.
//
//=============================================================================================================================
using UnityEngine;
using EasyAR;


public class EasyImageTargetBehaviour : ImageTargetBehaviour
{

    public GameObject ss;
    public MassiveBody mb;
    public bool startPoint;
    protected override void Awake()
    {
        base.Awake();
        TargetFound += OnTargetFound;
        TargetLost += OnTargetLost;
        TargetLoad += OnTargetLoad;
        TargetUnload += OnTargetUnload;
    }


    void OnTargetFound(TargetAbstractBehaviour behaviour)
    {
        //if (startPoint)
        //{
        //    ss.SetActive(true);
        //}
        //mb.gameObject.SetActive(true);
        //mb.transform.position = GetComponent<Transform>().position + new Vector3(0, ss.transform.position.y, 0);
       


        Debug.Log("Found: " + Target.Id);
    }

    void OnTargetLost(TargetAbstractBehaviour behaviour)
    {
        //mb.gameObject.SetActive(false);
        Debug.Log("Lost: " + Target.Id);
    }

    void OnTargetLoad(ImageTargetBaseBehaviour behaviour, ImageTrackerBaseBehaviour tracker, bool status)
    {
        Debug.Log("Load target (" + status + "): " + Target.Id + " (" + Target.Name + ") " + " -> " + tracker);
    }

    void OnTargetUnload(ImageTargetBaseBehaviour behaviour, ImageTrackerBaseBehaviour tracker, bool status)
    {
        Debug.Log("Unload target (" + status + "): " + Target.Id + " (" + Target.Name + ") " + " -> " + tracker);
    }
}

