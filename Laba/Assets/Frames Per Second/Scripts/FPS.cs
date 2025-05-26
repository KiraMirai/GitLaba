using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class FPS : MonoBehaviour
{
    private TMP_Text _fpsText;

    private void Start()
    {
        _fpsText = GetComponent<TMP_Text>();
        StartCoroutine(FramesPerSecond());
    }

    private IEnumerator FramesPerSecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);

            int fps = (int) (1f / Time.deltaTime);
            DisplayFPS(fps);
        }
    }

    private void DisplayFPS(float fps)
    {
        _fpsText.text = $"{fps} FPS";
    }
}
