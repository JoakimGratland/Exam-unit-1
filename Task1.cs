
while(AtGoal() == false)
{
    if (Peek() == true)
    {
     Move();
     leaveTrailBehindCar();
    }
    else
    {
        Turn();
    }
}

#region Basic functions

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void leaveTrailBehindCar()
{
    //leaves a trail behind the car that prevents the car from going back where it came from
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion