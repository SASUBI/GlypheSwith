using UnityEngine;
using System.Collections;



public class ChoixCouleur : MonoBehaviour
{
    CouleurRune Couleur;
    SpriteRenderer BrickRenderer;

    // Use this for initialization
    void Update()
    {
      
        BrickRenderer = GetComponent<SpriteRenderer>();      
        //CouleurRune
        if (Couleur == CouleurRune.Rouge)
        {
            BrickRenderer.material.color = GestionCouleur.Rouge;
        }
        if (Couleur == CouleurRune.Violet)
        {
            BrickRenderer.material.color = GestionCouleur.Violet;
        }
        if (Couleur == CouleurRune.Bleu)
        {
            BrickRenderer.material.color = GestionCouleur.Bleu;
        }
        if (Couleur == CouleurRune.Turquoise)
        {
            BrickRenderer.material.color = GestionCouleur.Turquoise;
        }
        if (Couleur == CouleurRune.Vert)
        {
            BrickRenderer.material.color = GestionCouleur.Vert;
        }
        if (Couleur == CouleurRune.Orange)
        {
            BrickRenderer.material.color = GestionCouleur.Orange;
        }
    }
}

