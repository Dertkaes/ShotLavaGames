using UnityEngine;

public class InputMetod: MonoBehaviour
{
    public GameManager gameManager;

    private void Update()
    {
        CheckInput();
    }

    public void CheckInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.point);
                gameManager.Shot(hit.point);
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
}
