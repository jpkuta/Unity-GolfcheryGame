using UnityEngine;

namespace Nokobot.Assets.Crossbow
{
    public class CrossbowShoot : MonoBehaviour
    {
        private AudioSource bowAudio;


        public GameObject arrowPrefab;
        public Transform arrowLocation;

        public float shotPower = 100f;

        void Start()
        {
            bowAudio = GetComponent<AudioSource>();

            if (arrowLocation == null)
                arrowLocation = transform;
        }

        void Update()
        {
            if(Input.GetButtonDown("Fire1"))
            {
                Instantiate(arrowPrefab, arrowLocation.position, arrowLocation.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shotPower);
                bowAudio.Play();
                gameFlow.currentStrokes++;
                gameFlow.totalStrokes += 1;
                gameFlow.ballMisses += 1;
                if(gameFlow.ballMisses > 0)
                {
                    gameFlow.currentScore -= 20;
                }
            }

            //changing shot power
            if (Input.GetButton("powerDown"))
            {
                shotPower = shotPower + 25;
                gameFlow.crossbowPower = shotPower;
            }

            if (Input.GetButton("powerUp"))
            {
                shotPower = shotPower - 25;
                gameFlow.crossbowPower = shotPower;
            }

            if(shotPower < 10)
            {
                shotPower = 10;
            }
            if(shotPower > 10000)
            {
                shotPower = 10000;
            }
        }
    }
}
