using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartCanvas : MonoBehaviour
{
    public int activeItemID; // WeaponManager���� ����

    public void GameStart()
    {
        // gameStartEvent<int> Invoke -> gameStartEvent: ActiveItem Activate, ...
        SceneManager.LoadScene("GeonuSampleScene", LoadSceneMode.Single);
    }

    // WeaponManager����
    public void SetActiveItemID(int id)
    {
        activeItemID = id;
    }

    public void EnableGameStartCanvas()
    {
        gameObject.SetActive(true);
    }

    public void DisableGameStartCanvas()
    {
        gameObject.SetActive(false);
    }
}
