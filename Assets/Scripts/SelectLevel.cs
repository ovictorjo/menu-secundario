using UnityEngine;
using UnityEngine.SceneManagement;
namespace Assets.Scripts
{
    public class SelectLevel : MonoBehaviour
    {
        public void ChangeLevel(int id)
        {
            SceneManager.LoadScene(id);
        }
    }
}
