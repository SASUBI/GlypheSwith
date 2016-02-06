using UnityEngine;
using System.Collections;
using System;
public enum CouleurRune 
{
    Rouge,Violet,Bleu,Turquoise,Vert,Orange
}

public class GestionCouleur : MonoBehaviour
{

    SpriteRenderer BrickRenderer;
    CouleurRune Couleur;

    public static Color Rouge = new Color(0.659F, 0.306F, 0.306F);
    public static Color Violet = new Color(0.639F, 0.404F, 0.635F);
    public static Color Bleu = new Color(0.412F, 0.404F, 0.627F);
    public static Color Turquoise = new Color(0.404F, 0.561F, 0.62F);
    public static Color Vert = new Color(0.404F, 0.608F, 0.451F);
    public static Color Orange = new Color(0.667F, 0.475F, 0.224F);
    void Start()
    {
        RandomCouleurRune();
    }
    CouleurRune RandomCouleurRune()
    {
        return (CouleurRune)(UnityEngine.Random.Range(0, Enum.GetNames(typeof(CouleurRune)).Length));
        
    }
    
    void Update()
    {
        
        BrickRenderer = GetComponent<SpriteRenderer>();
        //CouleurRune
        if (RandomCouleurRune() == CouleurRune.Rouge)
        {
            BrickRenderer.material.color = Rouge;
        }
        if (RandomCouleurRune() == CouleurRune.Violet)
        {
            BrickRenderer.material.color = Violet;
        }
        if (RandomCouleurRune() == CouleurRune.Bleu)
        {
            BrickRenderer.material.color = Bleu;
        }
        if (RandomCouleurRune() == CouleurRune.Turquoise)
        {
            BrickRenderer.material.color = Turquoise;
        }
        if (RandomCouleurRune() == CouleurRune.Vert)
        {
            BrickRenderer.material.color = Vert;
        }
        if (RandomCouleurRune() == CouleurRune.Orange)
        {
            BrickRenderer.material.color = Orange;
        }
        
    }
}

