using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console: MonoBehaviour
{
    private void Start()
    {
        // Sans modification particulière
        Debug.Log("Je suis un texte normal");

        // On ajoute la balise <b> au début et </b> a la fin pour mettre en gras
        Debug.Log("<b> Je suis un texte gras </b>");

        // On ajoute la balise <i> au début et </i> a la fin pour mettre en italique
        Debug.Log("<i> Je suis un texte qui penche </i>");

        // On ajoute la balise <size=10> au début et </size> a la fin pour changer la taille ( là 10 )
        Debug.Log("<size=10> Je suis un texte plus petit </size>");

        // On ajoute la balise <size=20> au début et </size> a la fin pour changer la taille ( là 20 )
        Debug.Log("<size=20> Je suis un texte plus grand </size>");

        // On ajoute la balise <color=green> au début et </color> a la fin pour changer la couleur
        Debug.Log("<color=green> Je suis un texte vert </color>");
    }
}