using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x47b2eccc : MonoBehaviour
{
    public Ease Ease = Ease.OutSine;
    public void _0xde663106()
    {
        this._0x206f31a6();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public void Show()
    {
        this._0xa806a7de();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x3d672026.Instance._0xdf87180f(_0x3d672026.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0x25c8d87d()
    {
        if (this.OuterBackground != null)
        {
            Image _0xa385a6e2 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xa385a6e2, true);
            _0xa385a6e2.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public float ScaleDuration = 0.4f;
    public TMP_Text MainText;
    public GameObject OuterBackground;
    private void _0x9ab82504()
    {
        if (this.OuterBackground != null)
        {
            Image _0x3b3f0ab3 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x3b3f0ab3, true);
            _0x3b3f0ab3.DOFade(1f, 0f);
        }
    }

    public TMP_Text HeaderText;
    public void _0xb97301dd()
    {
        this._0x9ab82504();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x3d672026.Instance._0xdf87180f(_0x3d672026.Instance.CurrentPanelIndex);
    }

    private void _0xa806a7de()
    {
        if (this.OuterBackground != null)
        {
            Image _0xdcc0b7b7 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xdcc0b7b7, true);
            _0xdcc0b7b7.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private bool _0x2a9c6ce6 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x25c8d87d();
    }

    private void _0x206f31a6()
    {
        if (this.OuterBackground != null)
        {
            Image _0x27eb95a1 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x27eb95a1, true);
            _0x27eb95a1.DOFade(0f, this.ScaleDuration);
        }
    }

    public bool IsScaledDownOnAwake = true;
    public GameObject Content;
}