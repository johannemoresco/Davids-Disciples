using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{

    public List<PuzzleSlots> puzzleSlots;

    [SerializeField] GameObject key; 

    public bool allOccupied()
    {
        foreach (PuzzleSlots slot in puzzleSlots)
        {
            if (!slot.isOccupied)
            {
                return false;
            }
        }
           return true;
    }

    public bool puzzleComplete()
    {
        return allOccupied();
    }

    private void Update()
    {
        if (puzzleComplete() && key != null)
        {
            Debug.Log("Puzzle complete");
            key.SetActive(true);
        }
    }

    private void Start()
    {
        puzzleSlots = new List<PuzzleSlots>(FindObjectsOfType<PuzzleSlots>());
    }

}
