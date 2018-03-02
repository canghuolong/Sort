using UnityEngine;
using System.Reflection;
using System;

public class Boot : MonoBehaviour {    
    public string ClassName;
    public string MethodName = "Sort";
    public int[] data = new int[] {9,2,12,31,62,0,1,87,12,22};

    public TextMesh textBefore;
    public TextMesh textAfter;
    MethodInfo methodInfo = null;
	// Use this for initialization
	void Start () {
        var type = Type.GetType(ClassName);
        methodInfo = type.GetMethod(MethodName, BindingFlags.Static | BindingFlags.Public);
        if(methodInfo == null)
        {
            Debug.LogError("There is no MethodInfo");
            return;
        }
        Debug.Log("<color=yellow>Type:" + type + "</color>---" + "<color=red>Method:" + methodInfo.Name + "</color>");

        Init();
    }
	
    void Init()
    {
        data = new int[10];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = UnityEngine.Random.Range(0, 100);
        }
        SetArrayText(textBefore, data);
        SetArrayText(textAfter, data);
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            methodInfo.Invoke(null,new object[] { data });
            SetArrayText(textAfter, data);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Init();
        }
	}



    void SetArrayText(TextMesh textMesh, int[] array)
    {
        var tempStr = string.Empty;
        var count = array.Length;
        foreach(var v in array)
        {
            count--;
            tempStr += (count > 0 ? (v.ToString() + ",") : v.ToString());
        }
        textMesh.text = tempStr;
    }
}
