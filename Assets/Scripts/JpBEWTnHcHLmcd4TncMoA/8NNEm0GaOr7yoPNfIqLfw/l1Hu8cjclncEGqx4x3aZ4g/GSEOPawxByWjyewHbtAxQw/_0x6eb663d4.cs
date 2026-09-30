using TMPro;
using UnityEngine;
using static _0x47a641fc;

public class _0x6eb663d4 : MonoBehaviour
{
    public void _0xb8e7d9eb()
    {
        this.MoneyCountText.text = _0x44cfec3f._0x678a3800.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x76e83e65;
            if (this.gameObject.TryGetComponent(out _0x76e83e65))
                this.MoneyCountText = _0x76e83e65;
        }

        this._0xb8e7d9eb();
    }
}