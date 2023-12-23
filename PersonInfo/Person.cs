using System;

namespace PersonInfo;

public class Person
{
    private string _firstName;          // Правим си прайвет полета 
    private string _lastName;
    private int _age;

    private const int NAME_MIN_LENGTH = 3; // Правим си променлива за да можем лесно да я променяме в кода.

    public Person(string firstName, string lastName, int age)   // Правим конструктор заради прайвет сетарите.
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName             // Правим публик проперти FirstName със прайвет сетар.
    {
        get { return this._firstName; }
        private set 
        {
            if (value.Length < NAME_MIN_LENGTH) // Първото име не може да бъде с по-малко от 3 символа.
            {
                throw new ArgumentException($"First name cannot contain fewer than {NAME_MIN_LENGTH} symbols!");
            }
            this._firstName = value; 
        }
    }

    public string LastName              // Правим публик проперти LastName със прайвет сетар.
    {
        get { return this._lastName; }
        private set
        {
            if (value.Length < NAME_MIN_LENGTH) // Последното име не може да бъде с по-малко от 3 символа.
            {
                throw new ArgumentException($"Last name cannot contain fewer than {NAME_MIN_LENGTH} symbols!");
            }
            this._lastName = value; 
        }
    }

    public int Age                      // Правим публик проперти Age със прайвет сетар.
    {
        get { return this._age; }
        private set
        {
            if (value <= 0)         // Годините не могат да бъдат 0 или отрицателно число.
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            this._age = value; 
        }
    }

    public override string ToString()   // Правим си шаблон за печатането със метода ТоСтринг.
    {
        return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
    }

}
