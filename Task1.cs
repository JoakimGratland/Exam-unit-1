
while(AtGoal() == false)
{
    if (Peek() == true)
    {
     Move();
    }
    else
    {
        if (TurnCounter < 2)
        {
            Turn();
            TurnCounter++;
        }
        else
        {
            TurnLeft();
            TurnCounter++;
        }
    }

    if (TurnCounter == 4)
    {
        TurnCounter = 0
    }
}

#mycode
int TurnCounter = 0;
void TurnLeft()
{
    for (int i = 0; i < 4; i++)
    (
     Turn();
    )
}

#region Basic functions

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
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