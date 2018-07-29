using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardController : MonoBehaviour {

    public static ScoreBoardController instance;

    public Text playerHealthText;
    public Text scoreCounterText;
    public Slider healthSlider;

    public static int health = 100;
    public static int scoreCounter = 0;

    // Use this for initialization
    void Start () {
        instance = this;
        healthSlider.value = health;
        scoreCounterText.text = scoreCounter.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void UpdateHealth(int health)
    {
        healthSlider.value = health;
    }

    public void HealthDecrease()
    {
        health -= 50;
        healthSlider.value = health;
    }

    public void ScoreCounterIncrease()
    {
        scoreCounter += 10;
        scoreCounterText.text = scoreCounter.ToString();
    }

    //public static void ResetStatics(Type type)
    //{
    //    MemberInfo[] members = type.GetMembers();
    //    Type defaultValues = Type.GetType(type.Name + "_DefaultValues");
    //    if (defaultValues != null)
    //    {
    //        foreach (MemberInfo member in members)
    //        {
    //            if (member.MemberType == MemberTypes.Field)
    //            {
    //                FieldInfo field = (FieldInfo)member;
    //                FieldInfo defaultValueField = defaultValues.GetField(field.Name);
    //                if (field != null && defaultValueField != null && field.IsPublic && field.IsStatic && defaultValueField.IsStatic)
    //                {
    //                    field.SetValue(null, defaultValueField.GetValue(null));
    //                }
    //            }
    //        }
    //    }
    //}

    //public struct Test_DefaultValues
    //{
    //    public static int health = 100;
    //    public static int scoreCounter = 0;
    //}
}
