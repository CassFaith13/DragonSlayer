
public class Knight
{
    public Knight()
    {
        this.Points = 200; //Knight begins with 200 armor pts

    }
    private bool _isAlive;

    public bool IsAlive
    {
        get
        {
            if (Points <= 0) //Knight dies if points reach 0
            {
                _isAlive = false;
                return _isAlive;
            }
            else
            {
                _isAlive = true;
            }
            return _isAlive;
        }
        set
        {
            _isAlive = value;
        }
    }


    public int Points
    {
        get; set;
    }


}

//Old C# way
// public class MyClass
// {
//     private string _name;

    //reading the data.....
//     public string GetName()
//     {
//         return _name;
//     }

    //writing the data.....
//     public void SetName(string value)
//     {
//         _name = value;
//     }


// }