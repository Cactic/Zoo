using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Zoo
{
    public class AnimalBehaviour : MonoBehaviour
    {
        public Spawner spawner;
        public InputField name;

        public void EatLeaves()
        {

            for (int i = 0; i < spawner.animals.Count; i++)
            {
                var animalInfo = spawner.animals[i].GetComponent<AnimalInfo>();

                if (animalInfo.CompareTag("Herbivore") || spawner.animals[i].CompareTag("Omnivore"))
                {
                    animalInfo.Balloon.SetActive(true);
                    animalInfo.text.text = animalInfo.foodText;
                }
            }          
        }

        public void EatMeat()
        {
            for (int i = 0; i < spawner.animals.Count; i++)
            {
                var animalInfo = spawner.animals[i].GetComponent<AnimalInfo>();

                if (spawner.animals[i].CompareTag("Carnivore") || spawner.animals[i].CompareTag("Omnivore"))
                {
                    animalInfo.Balloon.SetActive(true);
                    animalInfo.text.text = animalInfo.foodText;
                }
            }
        }

        public void DoTrick()
        {
            for (int i = 0; i < spawner.animals.Count; i++)
            {
                var trick = spawner.animals[i].GetComponent<Trick>();

               StartCoroutine(trick.DoTrick());
            }
        }

        public void SayHello()
        {
            for (int i = 0; i < spawner.animals.Count; i++)
            {
                var animalInfo = spawner.animals[i].GetComponent<AnimalInfo>();

                if (string.IsNullOrEmpty(name.text))
                {
                    animalInfo.Balloon.SetActive(true);
                    animalInfo.text.text = animalInfo.helloText;
                }
                
                if (name.text == spawner.animals[i].GetComponent<AnimalInfo>().name)
                {
                    animalInfo.Balloon.SetActive(true);
                    animalInfo.text.text = animalInfo.helloText;
                }
            }
        }
    }

}

