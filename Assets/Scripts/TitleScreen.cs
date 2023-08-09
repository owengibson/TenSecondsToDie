using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TenSecondsToDie
{
    public class TitleScreen : MonoBehaviour
    {
        private AudioSource soundtrack;

        [SerializeField] private GameObject mainCanvas;

        private void Start()
        {
            soundtrack = GetComponent<AudioSource>();
            soundtrack.Play();
        }
        public void PlayGame()
        {
            gameObject.SetActive(false);
            mainCanvas.SetActive(true);
        }
    }
}