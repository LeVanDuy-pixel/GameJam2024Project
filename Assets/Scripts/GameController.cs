using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] AudioSource sour;
    [SerializeField] AudioSource backgroundMusic;

    [SerializeField] GameObject Btn1;
    [SerializeField] GameObject Btn2;
    [SerializeField] GameObject Btn3;

    [SerializeField] TextMeshProUGUI txtQuestion;
    [SerializeField] TextMeshProUGUI txtPass;
    [SerializeField] TextMeshProUGUI txtPassMaybe;
    [SerializeField] TextMeshProUGUI txtFail;

    [SerializeField] Image emotionImg;

    [SerializeField] GameObject resultPanel;
    [SerializeField] TextMeshProUGUI txtResult;

    Emotion emotion;

    private enum Emo { Sad = 1 , Smile = 2, Angry = 3, Panic = 4, Doubtful = 5};

    private int turn = 1, pass=0, fail=0, passmaybe=0;
    private string test;
    void Start()
    {
        Btn1.SetActive(false);
        Btn2.SetActive(false);
        Btn3.SetActive(false);
        emotion = FindObjectOfType<Emotion>();
        txtQuestion.text = "START...";
        StartCoroutine(waitToStart());
        
    }

    // Update is called once per frame
    void Update()
    {
        txtPass.text = "Pass: "+pass;
        txtPassMaybe.text = "Pass Maybe: "+passmaybe;
        txtFail.text = "Fail: "+fail;
        if(turn == 6)
        {
            backgroundMusic.Stop();
            if (fail >= 2 && pass <3 || fail >=2 && passmaybe>=2)
            {
                test = "You have been detected for abnormal behavior, you are arrested and taken for research.";
            }
            if(passmaybe >= 2 && pass < 3)
            {
                test = "You were detected for abnormal but humorous behavior, you were captured, but the researchers tried to turn you into a meme symbol of the world :v.";
            }
            if(pass> 2)
            {
                test = "You were not detected due to normal behavior, you have integrated with the human world.";
            }
            
            txtResult.text = test;
            resultPanel.SetActive(true);
        }
    }
    IEnumerator waitToStart()
    {
        yield return new WaitForSeconds(3);
        randEmo(turn);
    }
    private void randEmo(int turn)
    {
        Btn1.SetActive(true);
        Btn2.SetActive(true);
        Btn3.SetActive(true);
        TextMeshProUGUI txtBtn1 = Btn1.GetComponentInChildren<TextMeshProUGUI>();
        TextMeshProUGUI txtBtn2 = Btn2.GetComponentInChildren<TextMeshProUGUI>();
        TextMeshProUGUI txtBtn3 = Btn3.GetComponentInChildren<TextMeshProUGUI>();
        txtQuestion.text = "Express emotion: " + (Emo)turn;
        txtBtn1.text = (Emo)turn + " 1";
        txtBtn2.text = (Emo)turn + " 2";
        txtBtn3.text = (Emo)turn + " 3";
        
    }
    public void emo1()
    {
        emotionImg.enabled = true;
       
        if (turn == 1)
        {
        emotionImg.sprite = emotion.sadSprites[0];
        sour.clip = emotion.sadAudioClips[0];
        sour.Play();
        Btn1.SetActive(false);
        Btn2.SetActive(false);
        Btn3.SetActive(false);
        StartCoroutine(waiting());
        test = "A bit unusual";
            passmaybe++;
        }
        if (turn == 2)
        {
            emotionImg.sprite = emotion.smileSprites[0];
            sour.clip = emotion.smileAudioClips[0];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "A bit unusual";
            passmaybe++;
        }
        if(turn == 3)
        {
            emotionImg.sprite = emotion.angrySprites[0];
            sour.clip = emotion.angryAudioClips[0];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "Excessive expression";
            fail++;
        }
        if (turn == 4)
        {
            emotionImg.sprite = emotion.panicSprites[0];
            sour.clip = emotion.panicAudioClips[0];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "A bit unusual";
            passmaybe++;
        }
        if (turn == 5)
        {
            emotionImg.sprite = emotion.doubtfulSprites[0];
            sour.clip = emotion.doubtfulAudioClips[0];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "Normal appearance";
            pass++;
        }


    }
    public void emo2()
    {
        emotionImg.enabled = true;

        if (turn == 1)
        {
            emotionImg.sprite = emotion.sadSprites[1];
            sour.clip = emotion.sadAudioClips[1];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "Excessive expression";
            fail++;
        }
        if (turn == 2)
        {
            emotionImg.sprite = emotion.smileSprites[1];
            sour.clip = emotion.smileAudioClips[1];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "Normal appearance";
            pass++;
        }
        if (turn == 3)
        {
            emotionImg.sprite = emotion.angrySprites[1];
            sour.clip = emotion.angryAudioClips[1];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "A bit unusual";
            passmaybe++;
        }
        if (turn == 4)
        {
            emotionImg.sprite = emotion.panicSprites[1];
            sour.clip = emotion.panicAudioClips[1];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "Normal appearance";
            pass++;
        }
        if (turn == 5)
        {
            emotionImg.sprite = emotion.doubtfulSprites[1];
            sour.clip = emotion.doubtfulAudioClips[1];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "A bit unusual";
            passmaybe++;
        }


    }
    public void emo3()
    {
        emotionImg.enabled = true;

        if (turn == 1)
        {
            emotionImg.sprite = emotion.sadSprites[2];
            sour.clip = emotion.sadAudioClips[2];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "Normal appearance";
            pass++;
        }
        if (turn == 2)
        {
            emotionImg.sprite = emotion.smileSprites[2];
            sour.clip = emotion.smileAudioClips[2];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "Excessive expression";
            fail++;
        }
        if (turn == 3)
        {
            emotionImg.sprite = emotion.angrySprites[2];
            sour.clip = emotion.angryAudioClips[2];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "Normal appearance";
            pass++;
        }
        if (turn == 4)
        {
            emotionImg.sprite = emotion.panicSprites[2];
            sour.clip = emotion.panicAudioClips[2];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "Excessive expression";
            fail++;
        }
        if (turn == 5)
        {
            emotionImg.sprite = emotion.doubtfulSprites[2];
            sour.clip = emotion.doubtfulAudioClips[2];
            sour.Play();
            Btn1.SetActive(false);
            Btn2.SetActive(false);
            Btn3.SetActive(false);
            StartCoroutine(waiting());
            test = "Excessive expression";
            fail++;
        }


    }

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(4);
        emotionImg.enabled=false;
        txtQuestion.text = test;
        yield return new WaitForSeconds(3);
        turn++;
        if(turn < 6)
        {
            randEmo(turn);
        }
        
    }
    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
