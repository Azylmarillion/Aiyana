[System.Serializable]
public enum ClimbSort
{
    Walking,
    Jumping,
    Falling,
    Climbing,
    ClimbingTowardsPoint,
    ClimbingTowardPlateau,
    CheckingForClimbStart
}

[System.Serializable]
public enum CheckingSort
{
    normal,
    turning,
    falling
}