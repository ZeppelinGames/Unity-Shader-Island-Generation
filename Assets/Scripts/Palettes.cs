using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Palettes : MonoBehaviour
{
    public Texture2D[] palettes;
    public Dropdown palDropDown;

    private void Start()
    {
        List<Dropdown.OptionData> ddData = new List<Dropdown.OptionData>();
        foreach (Texture2D pal in palettes)
        {
            Sprite palSpr = Sprite.Create(pal, new Rect(0, 0, pal.width, pal.height), new Vector2(0.5f, 0.5f));
            ddData.Add(new Dropdown.OptionData(palSpr));
        }

        palDropDown.options = ddData;
    }

    public void PaletteChange()
    {
        if (palDropDown.value >= 0 && palDropDown.value < palettes.Length)
        {
            EditMap.instance.SetPalette(palettes[palDropDown.value]);
        }
    }
}
