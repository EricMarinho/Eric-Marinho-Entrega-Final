using UnityEngine;

// ScriptableObjects s�o uma �tima maneira de armazenar dados que s�o usados em v�rios lugares.
// Fazendo isso, voc� pode evitar a duplica��o de dados e garantir que todos os objetos que usam
// esses dados estejam sempre atualizados.
[CreateAssetMenu(fileName = "ProjectileData", menuName = "Data/ProjectileData")]
public class ProjectileData : ScriptableObject
{
    public float speed;
    public float despawnTime;
    public float pushForce;
}