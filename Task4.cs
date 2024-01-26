TurnRightAndMove();
Move();
Move();
Move();
TurnLeftAndMove();
Move();
Move();
Move();
TurnRightAndMove();
TurnLeftAndMove();
TurnRightAndMove();
Move();
Move();
Move();
TurnLeftAndMove();
TurnRightAndMove();
Move();
Move();
Move();
Move();
TurnLeftAndMove();
Move();
Move();
TurnRightAndMove();
TurnLeftAndMove();
Move();
TurnRightAndMove();
TurnLeftAndMove();
Move();
TurnLeftAndMove();
Move();
Move();
Move();
Move();
TurnRightAndMove();
TurnLeftAndMove();
TurnRightAndMove();
Move();
TurnLeftAndMove();
Move();
Move();
TurnRightAndMove();
Move();
Move();
TurnLeftAndMove();
TurnRightAndMove();
Move();
TurnLeftAndMove();
Move();
Move();
TurnLeftAndMove();
Move();
Move();
TurnLeftAndMove();
Move();
Move();
Move();
Move();
TurnRightAndMove();
Move();
Move();
Move();
Move();
TurnRightAndMove();
TurnLeftAndMove();
TurnRightAndMove();
TurnLeftAndMove();
Move();
Move();
TurnRightAndMove();
Move();
Move();
Move();
Move();
TurnRightAndMove();
Move();
AtGoal = true;


#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void TurnRightAndMove()
{
    // Turns the car 90 deg clockwise.
    Move();
}

void TurnLeftAndMove()
{
    // Turns the car 90 deg counter clockwise.
    Move();
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