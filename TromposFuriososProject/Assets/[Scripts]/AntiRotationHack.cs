using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AntiRotationHack : MonoBehaviour
{
 
    //rotate the screen 90° when we are in portrait mode
    // a nasty hack untill unity webgl sorts it out.
 
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
     
    }
 
    // Update is called once per frame
    void Update()
    {
        //do this only on mobile, it would suck if you just resized your screen on desktop
        if (Application.isMobilePlatform)
        {
            Debug.Log("running on mobile platform");
            //only when the vertical screen dimension is greater than the horizontal
            //Screen.currentResolution.height > Screen.currentResolution.width
            if (canvas.pixelRect.height > canvas.pixelRect.width)
            {
                gameObject.transform.eulerAngles= new Vector3(0,0,90);
                canvas.transform.eulerAngles = new Vector3(0, 0, 90);
            }
            else
            {
                gameObject.transform.eulerAngles= new Vector3(0,0,0);
                canvas.transform.eulerAngles = new Vector3(0, 0, 0);
            }
 
        }
    }
}
