
public class Knight
{
    public Knight()
    {
        int Points = 200; //Knight begins with 200 armor pts

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

    // public bool killDragon {
    //     get {
    //         if (Points >= 2000) {
    //             _killDragon = true; 
    //         }
    //         else {
    //              _killDragon = false; 
    //              IsAlive = false; 
    //         }
    //     }
    // }

    public int Points
    {
        get; set;
    }


}