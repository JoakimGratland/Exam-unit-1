while(AtGoal() == false)
{
    if (peekLeftIfMultipleChoises() == true)
    {
     TurnLeft();
    }
    else if (Peek() == true)
    {
     Move();
    }
    else
    {
     TurnRight();
    }
}


#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void TurnRight()
{
    // Turns the car 90 deg clockwise.
}

void TurnLeft()
{
    // Turns the car 90 deg counter clockwise.
}

bool peekLeftIfMultipleChoises()
{
    // when met with multiple choices of where to go it will always choose the leftmost path.
    return true; // Just a placeholder value. 
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