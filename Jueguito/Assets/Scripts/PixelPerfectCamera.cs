using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour
{
    public Vector2 resolutionNativa = new Vector2(240,160);

    public static float pixelToUnits = 1.0f;
    public static float scale = 1.0f;

    private void Awake () {
        var camara = GetComponent <Camera> ();
        if (camara.orthographic) {
            scale = Screen.height / resolutionNativa.y;
            pixelToUnits *= scale;
            camara.orthographicSize = (Screen.height/2.0f) / pixelToUnits;
        }
    }
}
