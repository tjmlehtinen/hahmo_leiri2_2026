using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public PartSelector hair;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadCharacter();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SavePart(PartSelector part, string id)
    {
        PlayerPrefs.SetInt(id + "sprite", part.GetIndex());
    }

    void LoadPart(PartSelector part, string id)
    {
        int partIndex = PlayerPrefs.GetInt(id + "sprite");
        part.SetIndex(partIndex);
    }
    public void SaveCharacter()
    {
        SavePart(hair, "hair");
    }

    public void LoadCharacter()
    {
        LoadPart(hair, "hair");
    }

   
}
