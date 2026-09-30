using UnityEngine;
using UnityEngine.UI;

public class _0x093395dc : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x0e5ba754.Instance._0x81d24962(this.IsPhysicsRunOnClick));
    }

    public Button Button;
    public bool IsPhysicsRunOnClick;
}