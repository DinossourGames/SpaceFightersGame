using UnityEngine;
using UnityEngine.UIElements;

namespace Controllers
{
    public class MainMenuController : MonoBehaviour
    {
        void Start()
        {
            var root = GetComponent<UIDocument>().rootVisualElement;
            var playButton = root.Q<Button>("play-button");

            playButton.clicked += () => Debug.Log("Clicked on Play");
        }

    }
}
