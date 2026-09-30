using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x47a641fc;

public class _0xc1be6679 : MonoBehaviour
{
    public void _0xed679dda()
    {
        this.LastPopIndexes.Clear();
        this._0x1fee9fa2();
        foreach (GameObject _0x3e507254 in this.GameObjectsToHide)
            if (_0x3e507254 != null)
                _0x3e507254.SetActive(true);
        this._0xbe7f4f86();
    }

    public static _0xc1be6679 Instance;
    public List<_0x48578c91> Pops;
    public _0x48578c91 _0x2fa7501b(int _0x6d5639e0)
    {
        return this.Pops[_0x6d5639e0];
    }

    private void _0xbe7f4f86()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc1be6679>();
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public List<int> LastPopIndexes = new();
    public void _0x5466cdb4()
    {
        this.LastPopIndexes.RemoveAll(_0xe2e9d7f6 => _0xe2e9d7f6 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xed679dda();
        else
            this._0xcb33a0ba(this.LastPopIndexes.Last());
    }

    private void _0x52cd1693()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public GameObject BlurBackground;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x48578c91 _0x268c7a00 in this.Pops)
            if (_0x268c7a00 != null)
                _0x268c7a00.gameObject.SetActive(true);
    }

    public List<GameObject> GameObjectsToHide;
    public void _0xcb33a0ba(int _0xad427e07)
    {
        this.CurrentPopIndex = _0xad427e07;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x1fee9fa2(true);
        this._0x52cd1693();
        this.Pops[_0xad427e07].Show();
        foreach (GameObject _0xdefa929f in this.GameObjectsToHide)
            _0xdefa929f.SetActive(false);
    }

    private void _0x1fee9fa2(bool _0x18f5ae2a = false)
    {
        for (int _0x4b012768 = 0; _0x4b012768 < this.Pops.Count; ++_0x4b012768)
            if (this.Pops[_0x4b012768] != null && !(_0x4b012768 == this.CurrentPopIndex && _0x18f5ae2a))
                this.Pops[_0x4b012768]._0x548adf84();
    }

    public int CurrentPopIndex;
}