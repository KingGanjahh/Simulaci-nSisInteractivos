using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct MyVector
{
    public float x;
    public float y;

    public MyVector(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public MyVector AddVector(MyVector other)
    {
        return this + other;
    }

    public MyVector SubVector(MyVector other)
    {
        return this - other;
    }

    public MyVector Multiply(float scalar)
    {
        return this * scalar;
    }

    public void Draw(MyVector a, MyVector b)
    {
        Debug.DrawLine(new Vector2((int)a.x , (int)a.y), new Vector2 ((int)b.x, (int)b.y));
    }

    public void DrawFromZero(MyVector vector)
    {
        Debug.DrawLine(new Vector2(0,0), new Vector2((int)vector.x, (int)vector.y));
    }

    public float CalculateMagnitude()
    {
        float result = Mathf.Sqrt(this.x * this.x + this.y * this.y);

        return result;
    }

    public MyVector Normalize()
    {
        float magnitude = this.CalculateMagnitude();

        return new MyVector (this.x / magnitude, this.y / magnitude);
    }

    public static MyVector operator + (MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y);
    }

    public static MyVector operator - (MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.x - b.y);
    }

    public static MyVector operator * (MyVector a, float scalar)
    {
        return new MyVector(a.x * scalar, a.y * scalar);
    }

    public static MyVector operator * (float scalar, MyVector a)
    {
        return new MyVector(a.x * scalar, a.y * scalar);
    }

    public static MyVector operator / (MyVector a, float scalar)
    {
        return new MyVector(a.x / scalar, a.y / scalar);
    }
}
