while(AtGoal() == false)
{
    if (Peek() == true)
    {
     Move();
    }
    else if (FinalStretch <= 2)
    {
        PeekRightandMove();
    } 
    else
    { 
        if (TurnCounter < 1)
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

    if (TurnCounter == 3)
    {
        TurnCounter = 0
        FinalStretch++;
    }
}

#mycode
int TurnCounter = 0;
int FinalStretch = 0;
void TurnLeft()
{
    for (int i = 0; i < 4; i++)
    (
     Turn();
    )
}

void PeekRightandMove()
{
       Turn(); 
        
        if (Peek()) 
        {
            Move(); 
        }
        else 
        { 
            TurnLeft(); 
            Move(); 
        }
}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

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