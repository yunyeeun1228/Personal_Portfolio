using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Assistant : MonoBehaviour
{
    private Text messageText;
    private TextWriter.TextWriterSingle textWriterSingle;

    private int textIndex = 0;

    // private AudioSource talkingAuduiSource;

    private void Awake() {
        messageText = transform.Find("message").Find("messageText").GetComponent<Text>();
        // talkingAuduiSource = transform.Find("talkingSounds").GetComponent<AudioSource>();

        transform.Find("message").GetComponent<Button_UI>().ClickFunc = () => {
            if (textWriterSingle != null && textWriterSingle.IsActive()) {
                // Currently active TextWriter
                textWriterSingle.WriteAllAndDestroy();
           
            } else {
                string[] messageArray = new string[] {
                    "<1> Welcome to my world! this is the Secret Meow!",
                    "<2> I'm smith, call me when you need help.",
                    "<3> Well, this is a trial game for beta testing.",
                    "<4> I hope we could meet again in ScretMeow. Bye."
                };

                textWriterSingle = TextWriter.AddWriter_Static(messageText, messageArray[textIndex], 0.1f, true, true);
                textIndex++;;

            }
        };
    }


    private void Start() {
        //textWriter.AddWriter_Static(messageText, "Welcome to my World! this is SecretMeow!", .1f, true);
    }
}
