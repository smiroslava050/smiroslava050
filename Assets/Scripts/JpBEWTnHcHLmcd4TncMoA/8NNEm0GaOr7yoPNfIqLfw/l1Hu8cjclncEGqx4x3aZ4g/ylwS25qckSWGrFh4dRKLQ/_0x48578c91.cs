using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x48578c91 : MonoBehaviour
{
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public bool IsOnlyYScale;
    private bool _0xf62e3e5a => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Start()
    {
    // Content.SetActive(false);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x83a86810();
    }

    public TMP_Text ContentAdditionalText;
    public TMP_Text ContentHeaderText;
    public float scaleDuration = 0.4f;
    public Ease ease = Ease.OutSine;
    public bool IsScaledDownOnAwake = true;
    public TMP_Text ContentMainText;
    public GameObject Content;
    public static void HideAllPops()
    {
        _0xc1be6679.Instance._0xed679dda();
    }

    private void _0x83a86810()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public Image ContentImage;
    public void _0x548adf84()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }
}