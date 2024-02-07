// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{
    public enum ColorSet
    {
        Red,
        Blue,
        Yellow
    }

    [SerializeField] private ColorSet _currentColor;

    private Dictionary<ColorSet,Color> _colorSetToColor;

    private SpriteRenderer mySpriteRenderer;

    void Awake()
    {
        StartColorSetToColor();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void StartColorSetToColor()
    {
        _colorSetToColor = new Dictionary<ColorSet, Color>();
        _colorSetToColor.Add(ColorSet.Red, Color.red);
        _colorSetToColor.Add(ColorSet.Yellow, Color.yellow);
        _colorSetToColor.Add(ColorSet.Blue, Color.blue);
    }

    private void Start()
    {
        mySpriteRenderer.color = _colorSetToColor[_currentColor];
    }
}
