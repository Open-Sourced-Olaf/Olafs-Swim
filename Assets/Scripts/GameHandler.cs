using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("GameHandler.Start");

        // int count = 0;
        // FunctionPeriodic.Create(() => {
        //   CMDebug.TextPopupMouse("Ding! " + count);
        //   count++;
        //   }, .300f);

        // GameObject gameObject = new GameObject("Pipe", typeof(SpriteRenderer));
        // gameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.GetInstance().pipeHeadSprite;
    }
}
