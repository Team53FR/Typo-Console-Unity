using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console: MonoBehaviour
{
    private void Start()
    {
        // Sans modification particuli�re
        Debug.Log("Je suis un texte normal");

        // On ajoute la balise <b> au d�but et </b> a la fin pour mettre en gras
        Debug.Log("<b> Je suis un texte gras </b>");

        // On ajoute la balise <i> au d�but et </i> a la fin pour mettre en italique
        Debug.Log("<i> Je suis un texte qui penche </i>");

        // On ajoute la balise <size=10> au d�but et </size> a la fin pour changer la taille ( l� 10 )
        Debug.Log("<size=10> Je suis un texte plus petit </size>");

        // On ajoute la balise <size=20> au d�but et </size> a la fin pour changer la taille ( l� 20 )
        Debug.Log("<size=20> Je suis un texte plus grand </size>");

        // On ajoute la balise <color=green> au d�but et </color> a la fin pour changer la couleur
        Debug.Log("<color=green> Je suis un texte vert </color>");
    }
}