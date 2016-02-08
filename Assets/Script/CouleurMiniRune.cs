using UnityEngine;
using System.Collections;

public class CouleurMiniRune : MonoBehaviour {
    public CouleurRune Couleur;
    SpriteRenderer BrickRenderer;
    // Use this for initialization
    void Start () {
        BrickRenderer = GetComponent<SpriteRenderer>();
        if (Couleur == CouleurRune.Rouge)
        {
            BrickRenderer.material.color = GestionCouleur.Rouge;
        }
        else if (Couleur == CouleurRune.Violet)
        {
            BrickRenderer.material.color = GestionCouleur.Violet;
        }
        else if (Couleur == CouleurRune.Bleu)
        {
            BrickRenderer.material.color = GestionCouleur.Bleu;
        }
        else if (Couleur == CouleurRune.Turquoise)
        {
            BrickRenderer.material.color = GestionCouleur.Turquoise;
        }
        else if (Couleur == CouleurRune.Vert)
        {
            BrickRenderer.material.color = GestionCouleur.Vert;
        }
        else if (Couleur == CouleurRune.Orange)
        {
            BrickRenderer.material.color = GestionCouleur.Orange;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
