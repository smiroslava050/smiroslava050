using UnityEngine;
using UnityEngine.UI;

public class _0x0d2e2d68 : MonoBehaviour
{
    private bool _0xdca3a6d2;
    private void Awake()
    {
        if (this._0xd8ff34c9 == null)
            if (!this.TryGetComponent(out this._0xd8ff34c9))
                this._0xd8ff34c9 = this.GetComponentInChildren<Button>();
    }

    private Button _0xd8ff34c9;
    private void Start()
    {
        if (this._0xdca3a6d2)
            this._0xd8ff34c9.onClick.AddListener(() => _0x3d672026.Instance._0xe65d1564());
        else
            this._0xd8ff34c9.onClick.AddListener(() => _0x3d672026.Instance._0xb591be1b(this._0xa012ee53));
    }

    private int _0xa012ee53;
}