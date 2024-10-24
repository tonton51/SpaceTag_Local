using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// アイテムを生成するためのスクリプト
public class ItemGenerator : MonoBehaviour
{
    float span = 1.0f; // アイテム生成間隔
    float delta = 0;
    float starttime = 0;
    public GameObject Star;

    public static bool startflag;
    int idx = 1;

    // Update is called once per frame
    void Update()
    {
        startflag = ButtonController.startflag;
        if (startflag)
        {
            this.delta += Time.deltaTime;
            this.starttime += Time.deltaTime;

            if (starttime > 3.0f)
            {
                if (this.delta > this.span)
                {
                    this.delta = 0;
                    float x = Random.Range(-8, 8);

                    // Starを生成
                    var starobj = Instantiate(Star, new Vector3(x, 7, 0), Quaternion.identity);
                    starobj.name = "star" + idx;

                    // StarLoggerを追加して、idxを設定
                    var starLogger = starobj.AddComponent<StarLogger>();  // StarLoggerスクリプトを追加
                    starLogger.idx = idx;  // idxをセット

                    idx++;  // idxをインクリメント
                }
            }
        }
    }
}
