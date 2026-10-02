using UnityEngine;

public class Datos : MonoBehaviour
{
    string datos_texto;

    class Jugador
    {
        public int vidas;
        public float energia;
        public int dinero;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        datos_texto = "{\"vidas\": 15} , \"energia\" : 30,\r\n    \"dinero\" : 300";

        Jugador objeto_jugador = JsonUtility.FromJson<Jugador>(datos_texto );

        Debug.Log(objeto_jugador.vidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
