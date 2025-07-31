using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return (!knightIsAwake);
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return ((knightIsAwake || archerIsAwake) || prisonerIsAwake);
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return (!archerIsAwake && prisonerIsAwake);
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        //Does the archer asleep?
        if (archerIsAwake)
            return false;
        //Since the archer is asleep, does the knight asleep?
        else if (knightIsAwake)
        {
            //If the knight is awake, does the pet dog present?
            if (petDogIsPresent)
                return true;
            return false;
        }
        //Eventhough archer and knight were asleep, we cant save the prisoner if he/she is asleep.
        else if (!prisonerIsAwake)
        {
            //I coded this just to satisfy the test.
            //How can we save the prisoner if she/he's asleep?
            //The prisoner would be also startled even if the pet dog is present.
            //Does the dog will just lick the prisoner?
            if (!petDogIsPresent)
                return false;
            return true;
        }
        return true;
    }
}
