using UnityEngine;
using UnityEngine.UI;

public class _0x0b8dfd4f : MonoBehaviour
{
    public int PopToShowIndex;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
    public Button Button;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xc1be6679.Instance._0x5466cdb4();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xc1be6679.Instance._0xed679dda());
        else
            this.Button.onClick.AddListener(() => _0xc1be6679.Instance._0xcb33a0ba(this.PopToShowIndex));
    }

    public bool IsHideAllPops;
}