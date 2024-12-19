using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    // A classe NPCVelocity � uma subclasse de NPC que substitui o m�todo MoveNPC para mover o NPC utilizando MovePosition.
    [RequireComponent(typeof(Rigidbody2D))]
    public class NPCMovePosition : NPC
    {
        public override void MoveNPC()
        {
            rb.MovePosition(rb.position + direction * data.speed * Time.fixedDeltaTime);
        }

    }
}