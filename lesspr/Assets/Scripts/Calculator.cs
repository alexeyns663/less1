using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Calculator : MonoBehaviour
{
    public InputField Num1;
    public InputField Num2;

    public Text result;

    void Start()
    {
        result.text = "";
    }
    public void Sum()
    {
       
        if ((string.IsNullOrEmpty(Num1.text)) || (string.IsNullOrEmpty(Num2.text)))
        {
            result.text = ("Введите значение");
        }
        else
        {
            int num1 = int.Parse(Num1.text);
            int num2 = int.Parse(Num2.text);
            int a = (num1 + num2);
            result.text = a.ToString();
        }
                    
    }
    public void Minus()
    {
        if ((string.IsNullOrEmpty(Num1.text)) || (string.IsNullOrEmpty(Num2.text)))
        {
            result.text = ("Введите значение");
        }
        else
        {
            int num1 = int.Parse(Num1.text);
            int num2 = int.Parse(Num2.text);
            int a = (num1 - num2);
            result.text = a.ToString();
        }
    }
    public void Mult()
    {
        if ((string.IsNullOrEmpty(Num1.text)) || (string.IsNullOrEmpty(Num2.text)))
        {
            result.text = ("Введите значение");
        }
        else
        {
            int num1 = int.Parse(Num1.text);
            int num2 = int.Parse(Num2.text);
            int a = (num1 * num2);
            result.text = a.ToString();
        }
    }
    public void Dev()
    {
        if ((string.IsNullOrEmpty(Num1.text)) || (string.IsNullOrEmpty(Num2.text)))
        {
            result.text = ("Введите значение");
        }
        else
        {
            float num1 = float.Parse(Num1.text);
            float num2 = float.Parse(Num2.text);
            float a = (num1 / num2);
            result.text = a.ToString();
            if (num2 == 0)
            {
                result.text = ("Деление на 0 невозможно");
            }
            else
            {
                result.text = a.ToString();
            }
        }
                
    }
    public void Expo()
    {
        if ((string.IsNullOrEmpty(Num1.text)) || (string.IsNullOrEmpty(Num2.text)))
        {
            result.text = ("Введите значение");
        }
        else
        {
            float num1 = float.Parse(Num1.text);
            float num2 = float.Parse(Num2.text);
            float a = Mathf.Pow(num1,num2);
            result.text = a.ToString();
        }
    }
    public void Min()
    {
        if ((string.IsNullOrEmpty(Num1.text)) || (string.IsNullOrEmpty(Num2.text)))
        {
            result.text = ("Введите значение");
        }
        else
        {
            int num1 = int.Parse(Num1.text);
            int num2 = int.Parse(Num2.text);
        
            if (num1 > num2)
            {
                result.text = num2.ToString();
            }
            else
            {
                result.text = num1.ToString();
            }
        }
    }
    public void Max()
    {
        if ((string.IsNullOrEmpty(Num1.text)) || (string.IsNullOrEmpty(Num2.text)))
        {
            result.text = ("Введите значение");
        }
        else
        {
            int num1 = int.Parse(Num1.text);
            int num2 = int.Parse(Num2.text);

            if (num1 < num2)
            {
                result.text = num2.ToString();
            }
            else
            {
                result.text = num1.ToString();
            }
        }
    }
}