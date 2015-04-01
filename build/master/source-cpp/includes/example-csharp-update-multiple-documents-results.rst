result.MatchedCount.Should().Be(20);
if (result.IsModifiedCountAvailable)
{
    result.ModifiedCount.Should().Be(20);
}
