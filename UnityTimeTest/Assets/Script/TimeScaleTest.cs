using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class TimeScaleTest : MonoBehaviour {

    public float _timeScaleSet;
    public float TimeScaleSet
    {
        get
        {
            return _timeScaleSet;
        }
        set
        {
            _timeScaleSet = value;
            Time.timeScale = _timeScaleSet;
        }
    }    

    void AutoSetTimeScale()
    {
        if (TimeScaleSet != Time.timeScale)
        {
            Time.timeScale = TimeScaleSet;
        }
    }

    static void Main()
    {
        var sdf = 22;
        Debug.Log(sdf.GetNameValueFormart(_=>sdf));

        //string abc = "123";
        //int b = 1;
        //test(() => abc);
        //test(() => b);
        //Console.ReadKey();
    }


	// Use this for initialization
	void Start () {
        Main();
	}
    

	// Update is called once per frame
	void Update () {
        AutoSetTimeScale();
        var sdf = 222;
        //Utils.Nameof<int>(d => sdf);
        Time.deltaTime.Nameof(_ => Time.deltaTime);
        Utils.Nameof(_ => Time.deltaTime);

    }

    void FixedUpdate()
    {
        AutoSetTimeScale();
    }



    string Nameof<T>(System.Linq.Expressions.Expression<Func<T, T>> exp)
    {
        return Utils.Nameof(exp);
    }

    string GetNameValueFormart<T>(System.Linq.Expressions.Expression<Func<T, T>> exp,
        string format = "{0} : {1}")
    {
        return Utils.GetNameValueFormart(exp, format);
    }

    string GetNameValueFormart1<T>(System.Linq.Expressions.Expression<Func<T, T>> exp)
    {
        return Utils.GetNameValueFormart1(exp);
    }
}
