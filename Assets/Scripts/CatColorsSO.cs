using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cat Colors", menuName = "ScriptableObjects/Cat Colors", order = 1)]
public class CatColorsSO : ScriptableObject
{
    public Color Base = new Color(0,0,0,1);
    public Color Belly = new Color(0, 0, 0, 1);
    public Color Fur = new Color(0, 0, 0, 1);
    public Color Stripes = new Color(0, 0, 0, 1);
    public Color Nose = new Color(0, 0, 0, 1);
    public Color InnearEar = new Color(0, 0, 0, 1);
    public Color OuterEar = new Color(0, 0, 0, 1);
}
