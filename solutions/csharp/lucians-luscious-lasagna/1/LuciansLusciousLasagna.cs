class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualMinutes)
    {
        int expectedMinutesInOven = ExpectedMinutesInOven();
        return expectedMinutesInOven - actualMinutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layer)
    {
        return layer * 2;
    }


    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layer, int elapsedTime)
    {
        int totalTimeOfLayers = PreparationTimeInMinutes(layer);
        return totalTimeOfLayers + elapsedTime;
    }
}
