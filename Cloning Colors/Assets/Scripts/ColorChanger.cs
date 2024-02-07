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

    private Dictionary<ColorSet, Color> _colorSetToColor;
    private Dictionary<int, ColorSet> _indexToColorSet;

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

        _indexToColorSet = new Dictionary<int, ColorSet>(_colorSetToColor.Count);

        var i = 0;
        foreach (var colorSet in _colorSetToColor)
        {
            _indexToColorSet.Add(i, (ColorSet)colorSet.Key);
            i++;
        }



    }

    private void Start()
    {
        SetColor(_currentColor);
    }

    public void SetColor(ColorSet newColor)
    {
        mySpriteRenderer.color = _colorSetToColor[newColor];
        _currentColor = newColor;
    }

    public ColorSet GetCurrentColor()
    {
        return _currentColor;
    }

    public void SetRandomColor()
    {
        var newColorIndex = Random.Range(0, _indexToColorSet.Count);

        var newColorSet = _indexToColorSet[newColorIndex];

        SetColor(newColorSet);

    }
}
