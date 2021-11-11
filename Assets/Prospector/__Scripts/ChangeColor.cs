using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    //Color[] colors = new Color[4];
    public Color[] ColorBank;
    public bool mesh;
    public bool sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        int Num = Random.Range(0, ColorBank.Length);
        if (sprite)
        {
            SpriteRenderer s = GetComponent<SpriteRenderer>();
            s.color = ColorBank[Num];
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            int Num = Random.Range(0, ColorBank.Length);
            if (sprite)
            {
                SpriteRenderer s = GetComponent<SpriteRenderer>();
                s.color = ColorBank[Num];
            }
        }
    }
}
