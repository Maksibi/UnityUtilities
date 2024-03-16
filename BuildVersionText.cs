using TMPro;
using UnityEngine;

namespace CodeBase.Logic
{
    public class BuildVersionText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;

        private void Start()
        {
            text.text = Application.version;
        }
    }
}
