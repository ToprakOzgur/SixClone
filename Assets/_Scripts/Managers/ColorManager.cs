using UnityEngine;

public class ColorManager : MonoBehaviour
{
    [SerializeField] private Color[] blockColors;
    public Color GetRandomColor()
    {
        return blockColors[Random.Range(0, blockColors.Length)];
    }
}
