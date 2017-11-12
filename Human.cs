// Refrences

// Class Definition 
// Scope -- Type -- Name

public class Human
{
	public Human()
	{
        // Variables
        int age;
        float height;
        bool gender;
        string firstName, familyName;
        bool hungry;
        float energy;

        //Constructor
    public Human(int _age, float _height,  bool _gender, string _firstName, string _familyName)
        {
            age = _age;
            height = _height;
            gender = _gender;
            firstName = _familyName;
            familyName = _familyName;
            hungry = true;
            enerygy = 100;
               
        }


    // Functions (Methods)
    public void DayInLife()
        {
            Ageing();
            Eating();

        }
    public string GetFirstName()
        {
            return firstName;
        }

    public void Ageing()
        {
            age = age + 1;
            energy = energy - 1;
        }

}
