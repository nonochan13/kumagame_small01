using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BearCubController : MonoBehaviour
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
        //Rigidbodyコンポ―ネットを取得
        //this.myAnimator = GetComponent<Animator>();

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
        //食べ物（ドングリの実）を得る場合
        if (other.gameObject.tag == "DonguriTag")
        {
            // 満腹スコアを加算（ドングリの実+3　スタートは0→100でゴールの権利が得られる）
            this.score += 3;

            //ScoreText獲得した点数を表示
            this.scoreText.GetComponent<Text>().text = "満腹感 " + this.score + "%";

            //完食パーティクルを再生
            GetComponent<ParticleSystem>().Play();

            //食べ終わった木のテクスチャーを変更
            //GetComponent<Renderer>().material.mainTexture = TreeColors_A;
        }

        //食べ物（畑の食べ物）を得る場合
        if (other.gameObject.tag == "HatakeTag")
        {
            // 満腹スコアを加算（畑の食べ物+2　スタートは0→100でゴールの権利が得られる）
            this.score += 2;

            //ScoreText獲得した点数を表示
            this.scoreText.GetComponent<Text>().text = "満腹感 " + this.score + "%";

            //完食パーティクルを再生
            GetComponent<ParticleSystem>().Play();

            //食べ終わった食物を破棄
            Destroy(other.gameObject);
        }

        //食べ物（その他キノコの食べ物）を得る場合
        if (other.gameObject.tag == "KinokoTag")
        {
            // 満腹スコアを加算（その他キノコ+1　スタートは0→100でゴールの権利が得られる）
            this.score += 1;

            //ScoreText獲得した点数を表示
            this.scoreText.GetComponent<Text>().text = "満腹感 " + this.score + "%";

            //完食パーティクルを再生
            GetComponent<ParticleSystem>().Play();

            //食べ終わった食物を破棄
            Destroy(other.gameObject);
        }

    }

}