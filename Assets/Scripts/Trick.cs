using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class Trick : MonoBehaviour
    {

        [Range(-1, 1)] public float ySpeed;
        [Range(-1, 1)] public float xSpeed;

        public IEnumerator DoTrick()
        {
            var targetXRotation = 0f;
            var targetYRotation = 0f;

            while (true)
            {

                targetYRotation = Mathf.Clamp(targetYRotation + ySpeed, -360, 360);
                targetXRotation = Mathf.Clamp(targetXRotation + xSpeed, -360, 360);

                transform.eulerAngles = new Vector3(targetXRotation, targetYRotation, 0);

                if ((Mathf.Abs(targetXRotation) >= 360 && Mathf.Abs(targetYRotation) >= 360))
                {
                    break;
                }

                yield return new WaitForEndOfFrame();
            }
        }
    }
}
