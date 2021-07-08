using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager manager;
    [SerializeField] List<GameObject> levels;
    [SerializeField] GameObject loadingPanel;
    [SerializeField] Animator loadingAnim;
    private GameObject currentLevel;

    private int index;

    private void Awake() 
    {
        manager = this;    
    }
    private void Start() 
    {
        index = 0;
        StartCoroutine(LevelLoader());
    }
    public void LoadLevel()
    {
        StartCoroutine(LevelLoader());
    }
    IEnumerator LevelLoader()
    {
        loadingPanel.SetActive(true);
        loadingAnim.SetTrigger("fadeIn");
        yield return new WaitForSeconds(1f);
        if(currentLevel)
        {
            Destroy(currentLevel);
        }
        currentLevel = Instantiate(levels[index], Vector3.zero, Quaternion.identity);
        index++;
        loadingAnim.SetTrigger("fadeOut");
        yield return new WaitForSeconds(1f);
        loadingPanel.SetActive(false);
    }
}
