using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SterneScript : MonoBehaviour
{
    int zeilenAnzahl = 3;

    void Start()
    {
        for (int zeile = 1; zeile <= zeilenAnzahl; zeile++)
        {
            string ausgabe = "";

            ausgabe = GeneriereMinuszeichen(ausgabe);

            for (int sterne = 1; sterne <= 2 * zeile - 1; sterne++)
            {
                ausgabe += "*";
            }

            ausgabe = GeneriereMinuszeichen(ausgabe);

            Debug.Log(ausgabe);
        }
    }

    private string GeneriereMinuszeichen(string ausgabe, int zeile)
    {
        for(int minus= 1; minus <= zeilenAnzahl-zeile; minus++)
        {
            ausgabe += "-";
        }
       
        return ausgabe;
    }

}
