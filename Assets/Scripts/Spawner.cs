using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Zoo
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra, cow, goat;
        public List<GameObject> animals;

        private void Start()
        {
            AnimalInfo henk = Instantiate(lion, transform).GetComponent<AnimalInfo>();
            henk.name = "henk";
            animals.Add(henk.gameObject);

            AnimalInfo elsa = Instantiate(hippo, transform).GetComponent<AnimalInfo>();
            elsa.name = "elsa";
            animals.Add(elsa.gameObject);

            AnimalInfo dora = Instantiate(pig, transform).GetComponent<AnimalInfo>();
            dora.name = "dora";
            animals.Add(dora.gameObject);

            AnimalInfo wally = Instantiate(tiger, transform).GetComponent<AnimalInfo>();
            wally.name = "wally";
            animals.Add(wally.gameObject);

            AnimalInfo marty = Instantiate(zebra, transform).GetComponent<AnimalInfo>();
            marty.name = "marty";
            animals.Add(marty.gameObject);

            AnimalInfo betty = Instantiate(cow, transform).GetComponent<AnimalInfo>();
            betty.name = "betty";
            animals.Add(betty.gameObject);

            AnimalInfo gordon = Instantiate(goat, transform).GetComponent<AnimalInfo>();
            gordon.name = "gordon";
            animals.Add(gordon.gameObject);
        }
    }
}
