using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    string ai_player = "Black";
    Transform selectedPiece; // reference to the selected piece, initially empty
    Transform selectedSquare; // reference to the selected square, initially empty;
    List<Transform> aiPieces = new List<Transform>();

    void movePiece()
    {
        if (selectedSquare && selectedPiece) // check if there is piece to move and the destination for it was selected
        {
            selectedPiece.position = selectedSquare.position; // move the piece. Later, we will animate this step, but for now the move is immediate
            selectedSquare.GetComponent<Square>().piece = selectedPiece; // let square remember what piece is sitting on it
            selectedPiece.parent.GetComponent<Square>().piece = null; // remove piece from the current square
            selectedPiece.parent = selectedSquare; // let piece remember was piece it is sitting on, by setting it as parent
            GameState.playersTurn = true;

        }
    }

    void Start()
    {
        foreach(GameObject t in GameObject.FindGameObjectsWithTag("piece"))
        {
            if (t.name.Contains(ai_player))
                aiPieces.Add(t.transform);
        }
    }

    void makeRandomMove()
    {
        int pieceIndex = Random.Range(0, aiPieces.Count);
        Transform origin = aiPieces[pieceIndex].transform;

        bool valid = false;
        Transform destination;
        int maxCount = 300;
        int count = 0;

        //random square approach 
        while(!valid || count < maxCount)
        {
            count++; 

        }
        for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (GameState.isValidMove(origin, GameState.chessboard[i,j]))
                        {
                            destination = GameState.chessboard[i, j];
                        }
                }

            }

        /* 

        i = Random.Range(0, 64);
        destination = allSquares[i];

        GameState.isValidMove(origin, destination);*/

    }

    void Update()
    {
        if(!GameState.playersTurn)
        {
            makeRandomMove();
        }
    }


}
