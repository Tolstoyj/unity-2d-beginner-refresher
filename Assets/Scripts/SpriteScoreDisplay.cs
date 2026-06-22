using UnityEngine;
using UnityEngine.UI;

public class SpriteScoreDisplay : MonoBehaviour
{
    public Sprite[] digitSprites = new Sprite[10];

    public int maxDigits = 3;
    public bool showLeadingZeros = false;

    public Vector2 startPosition = new Vector2(30f, -30f);
    public Vector2 digitSize = new Vector2(45f, 60f);
    public float spacing = 4f;

    private Image[] digitImages;

    private void Awake()
    {
        CreateDigitImages();
    }

    public void SetScore(int score)
    {
        if (digitImages == null || digitImages.Length == 0)
            CreateDigitImages();

        if (digitSprites == null || digitSprites.Length < 10)
        {
            Debug.LogWarning("Assign digit sprites from 0 to 9.");
            return;
        }

        int maxValue = (int)Mathf.Pow(10, maxDigits) - 1;
        score = Mathf.Clamp(score, 0, maxValue);

        string scoreText = showLeadingZeros
            ? score.ToString().PadLeft(maxDigits, '0')
            : score.ToString();

        for (int i = 0; i < digitImages.Length; i++)
        {
            if (i < scoreText.Length)
            {
                int digit = scoreText[i] - '0';

                digitImages[i].enabled = true;
                digitImages[i].sprite = digitSprites[digit];
                digitImages[i].preserveAspect = true;
            }
            else
            {
                digitImages[i].enabled = false;
            }
        }
    }

    private void CreateDigitImages()
    {
        digitImages = new Image[maxDigits];

        for (int i = 0; i < maxDigits; i++)
        {
            GameObject digitObject = new GameObject(
                "ScoreDigit_" + i,
                typeof(RectTransform),
                typeof(CanvasRenderer),
                typeof(Image)
            );

            digitObject.transform.SetParent(transform, false);

            RectTransform rectTransform = digitObject.GetComponent<RectTransform>();

            rectTransform.anchorMin = new Vector2(0, 1);
            rectTransform.anchorMax = new Vector2(0, 1);
            rectTransform.pivot = new Vector2(0, 1);

            rectTransform.sizeDelta = digitSize;
            rectTransform.anchoredPosition = startPosition + new Vector2(
                i * (digitSize.x + spacing),
                0
            );

            digitImages[i] = digitObject.GetComponent<Image>();
        }
    }
}
