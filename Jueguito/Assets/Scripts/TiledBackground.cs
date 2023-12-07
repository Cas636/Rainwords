using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiledBackground : MonoBehaviour
{
    public int textureSize = 40;

    public bool scaleVer = true;

    public bool scaleHor = true;

    // Start is called before the first frame update
    void Start()
    {
        var newWidth = !scaleHor? 1 : Mathf.Ceil (Screen.width / (textureSize * PixelPerfectCamera.scale) );
        var newHeight = !scaleVer? 1 : Mathf.Ceil (Screen.height / (textureSize * PixelPerfectCamera.scale) );

        transform.localScale = new Vector3 (newWidth * textureSize, newHeight * textureSize);

        GetComponent <Renderer>().material.mainTextureScale = new Vector3 (newWidth, newHeight, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
