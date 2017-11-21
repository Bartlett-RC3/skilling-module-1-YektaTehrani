using System;
namespace Application
{

    // Class Definition

    public class Dogs
    {
        public int age;
        public int weight;
        public int mealsPerDay;
        public string dogName;
        public bool canTravel;
        public bool smelly;
        float energy;


        public Dogs(int _age, int _weight, int _mealsPerDay, string _dogName, bool _canTravel, bool _smelly, float _energy)
        {
            age = _age;
            weight = _weight;
            mealsPerDay = _mealsPerDay;
            dogName = _dogName;
            canTravel = _canTravel;
            smelly = false;
            energy = 100;
        }
        public void SetDogName(string newDogName)
        {
            dogName = newDogName;
        }
        private void Ageing()
        {
            age = age + 1;
            mealsPerDay = mealsPerDay + 3;
            weight = mealsPerDay + 1;
        }

    }
}

