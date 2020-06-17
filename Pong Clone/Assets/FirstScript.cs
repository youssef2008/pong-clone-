
using UnityEngine;
using UnityEngine.UI;
public class FirstScript : MonoBehaviour
{
    public Text myText;
    public int x = 0;
#pragma warning disable IDE0040 // Add accessibility modifiers
#pragma warning disable UNT0001 // Empty Unity message
    void Start()
#pragma warning restore UNT0001 // Empty Unity message
#pragma warning restore IDE0040 // Add accessibility modifiers
    {
    }

    // Update is called once per frame
#pragma warning disable IDE0040 // Add accessibility modifiers
#pragma warning disable UNT0001 // Empty Unity message
    void Update()
#pragma warning restore UNT0001 // Empty Unity message
#pragma warning restore IDE0040 // Add accessibility modifiers
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        x++;
        Debug.Log(x);
    }

}//end