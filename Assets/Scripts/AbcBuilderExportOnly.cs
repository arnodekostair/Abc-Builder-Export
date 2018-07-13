using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbcBuilderExportOnly : MonoBehaviour {

    private MyManager myManager;

    [SerializeField]
    private Transform sceneObjectsRootTransform;

	// Use this for initialization
	void Start ()
    {
        myManager = new MyManager();
        myManager.BuilderExportOnlyMethod();

        GameObject newGO = new GameObject("AGameObject");
        newGO.AddComponent<FirstBehavior>();

        newGO.transform.SetParent(sceneObjectsRootTransform);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
