Turn();
Move();
Move();
Move();
TurnLeftAndMove();
Move();
Move();
Move();
Turn();
TurnLeftAndMove();
Turn();
Move();
Move();
Move();
TurnLeftAndMove();
Turn();
Move();
Move();
Move();
Move();
TurnLeftAndMove();
Move();
Move();
Turn();
TurnLeftAndMove();
Move();
Turn();
TurnLeftAndMove();
Move();
TurnLeftAndMove();
Move();
Move();
Move();
Move();
Turn();
TurnLeftAndMove();
Turn();
Move();
TurnLeftAndMove();
Move();
Move();
Turn();
Move();
Move();
TurnLeftAndMove();
Turn();
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
Turn();
Move();
Move();
Move();
Move();
Turn();
TurnLeftAndMove();
Turn();
TurnLeftAndMove();
Move();
Move();
Turn();
Move();
Move();
Move();
Move();
Turn();
Move();
AtGoal = true;


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
    Move();
}

void TurnLeftAndMove()
{
     for (int i = 0; i < 4; i++)
    (
     Turn();
    )
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