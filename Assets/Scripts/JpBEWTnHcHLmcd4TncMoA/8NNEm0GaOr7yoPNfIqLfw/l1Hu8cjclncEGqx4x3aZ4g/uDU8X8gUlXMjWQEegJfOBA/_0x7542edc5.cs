using UnityEngine;
using UnityEngine.UI;

public class _0x7542edc5 : MonoBehaviour
{
    public int EndTutorialPanelIndex = 1;
    public Button NextTutorialButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x3d672026.Instance._0xb591be1b(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x0e5ba754.Instance._0x31023a53());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x3d672026.Instance._0xb591be1b(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x3d672026.Instance._0xb591be1b(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x0e5ba754.Instance._0x31023a53());
        }
    }

    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
    public bool IsTutorialEndPanel;
}