// LoyaltyPointsCalculator.cs
public class LoyaltyPointsCalculator
{
    private readonly LoyaltyPolicy policy;

    public LoyaltyPointsCalculator(LoyaltyPolicy policy)
    {
        this.policy = policy;
    }

    public int CalculatePoints(decimal amount) => policy.PointsFor(amount);
}
