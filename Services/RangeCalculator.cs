namespace Services
{
    class RangeCalculator
    {
        public int[] calculateRanges(int xCord, int yCord, int vievRange)
        {
            PublicData publicData = new PublicData();

            int[] ranges = new int[4];
            if (xCord - vievRange < 0) ranges[0] = 0; else ranges[0] = xCord - vievRange;
            if (xCord + vievRange > publicData.FieldAxisSize) ranges[1] = publicData.FieldAxisSize; else ranges[1] = xCord + vievRange;
            if (yCord - vievRange < 0) ranges[2] = 0; else ranges[2] = yCord - vievRange;
            if (yCord + vievRange > publicData.FieldAxisSize) ranges[3] = publicData.FieldAxisSize; else ranges[3] = yCord + vievRange;

            return ranges;
        }
    }
}
