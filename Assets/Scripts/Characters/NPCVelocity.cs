using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    // A classe NPCVelocity � uma subclasse de NPC que substitui o m�todo MoveNPC para mover o NPC com base na velocidade.
    public class NPCVelocity : NPC
    {
        public override void MoveNPC()
        {
            rb.velocity = direction * data.speed;
        }
    }
}