using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x617d2a45 : MonoBehaviour
{
    private Image _0x18418ee9;
    private void _0x6974233b()
    {
        if (this._0x18418ee9.canvasRenderer.GetColor() != this._0x0266941b.canvasRenderer.GetColor())
            this._0x0266941b.canvasRenderer.SetColor(this._0x18418ee9.canvasRenderer.GetColor());
    }

    private TMP_Text _0x0266941b;
    private void Update()
    {
        this._0x6974233b();
    }
}