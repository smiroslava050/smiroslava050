using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x2fd00157 : MonoBehaviour
{
    private AspectRatioFitter _0x96804364;
    private float _0x0e791427 = 0.6f;
    private void Update()
    {
        int _0x04a39501 = 1;
        if (this._0x5a6e53e8.Count > 0)
        {
            string _0x3e01e192 = this._0x8810be64.text;
            foreach (string _0x15541983 in this._0x5a6e53e8)
                while (_0x3e01e192.Contains(_0x15541983))
                    _0x3e01e192 = _0x3e01e192.Replace(_0x15541983, "");
            _0x04a39501 = _0x3e01e192.Length;
        }
        else
        {
            _0x04a39501 = this._0x8810be64.text.Length;
        }

        float _0x916cf8f5 = Mathf.Clamp(this._0x84d01409 + this._0x0e791427 * _0x04a39501, this._0x36f6c66f, this._0xe547f7ef);
        if (!Mathf.Approximately(this._0x96804364.aspectRatio, _0x916cf8f5))
            this._0x96804364.aspectRatio = _0x916cf8f5;
    }

    private List<string> _0x5a6e53e8 = new();
    private float _0x36f6c66f = 1.5f;
    private TMP_Text _0x8810be64;
    private float _0xe547f7ef = 4;
    private float _0x84d01409;
}