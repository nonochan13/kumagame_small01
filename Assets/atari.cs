using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UnityChanController : MonoBehaviour
{
    private GameObject stateText;
    //スコアを表示するテキスト
    private GameObject scoreText;
    //得点
    private int score = 0;
    //案山子遭遇時の判定
    private bool isKakashi=false;



    // Use this for initialization
    void Start()
    {

        //シーン中のstateTextオブジェクトを取得
        this.stateText = GameObject.Find("GameResultText");

        //シーン中のscoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
    }

    //トリガーモードで他のオブジェクトと接触した場合の処理
    private void OnTriggerEnter(Collider other)
    {
        //食べ物を得る場合
        if (other.gameObject.tag == "TabemonoTag")
        {
            // 満腹スコアを加算（山の食べ物+1　畑の食べ物+2　スタートは0→100でゴールの権利が得られる）
            this.score += 1;

            //ScoreText獲得した点数を表示
            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";

            //完食パーティクルを再生
            GetComponent<ParticleSystem>().Play();

            //食べ終わった食物を破棄
            Destroy(other.gameObject);
        }

        //案山子に遭遇した場合
        if (other.gameObject.tag == "KakashiTag")
        {
            this.isKakashi = true;
            //stateTextに案山子の追憶と恐れ指数を表示
            //this.stateImage.GetComponent<Image>.sprite = other.GetComponent<Kakashi>().image;
        }

    }

}