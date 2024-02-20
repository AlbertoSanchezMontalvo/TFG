using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyController : MonoBehaviour
{
    private float speed = 2f;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        // Verifica si el jugador ha cruzado la coordenada de activación
        if (gameObject.activeSelf)
        {
            Mover(gameObject);
            // Si el enemigo ya está activado, lo movemos hasta la mesa.
        }
    }
    void Mover(GameObject obj)
    {
        Vector2 target = new Vector2(60, 0); // Creamos el vector 2D con las posiciones del objetivo al que va el enemigo (la mesa)
        MoveTowardsTarget(obj, target);
    }

    private void MoveTowardsTarget(GameObject obj, Vector2 target)
    {
        float step = speed * Time.deltaTime;
        obj.transform.position = Vector2.MoveTowards(obj.transform.position, target, step);
    }

}
