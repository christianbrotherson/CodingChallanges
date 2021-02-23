using System;
using Xunit;

namespace JobNimbusCodingChallenge
{
  public class UnitTest1
  {
    [Fact]
    public void BracketsTest()
    {
      Challenges challenges = new();
      Assert.True(challenges.ClosedBracketsStack(""));
      Assert.True(challenges.ClosedBracketsStack("{}"));
      Assert.True(challenges.ClosedBracketsStack("{{}}{}"));
      Assert.True(challenges.ClosedBracketsStack("Lorem { ipsum dolor sit amet, consectetur adipiscing elit, sed do { eiusmod tempor incididunt ut labore }et dolore magna aliqua.Ut enim ad minim ven} iam,"));
      Assert.False(challenges.ClosedBracketsStack("{{}}}{"));
      Assert.False(challenges.ClosedBracketsStack("}{"));
      Assert.False(challenges.ClosedBracketsStack("{{}"));
      Assert.False(challenges.ClosedBracketsStack("{}}"));
      Assert.False(challenges.ClosedBracketsStack("Duis{ aute irure dolor }in reprehenderit {in { voluptate} velit esse cillum dolore eu fugiat nulla pariatur."));

      Assert.True(challenges.ClosedBrackets(""));
      Assert.True(challenges.ClosedBrackets("{}"));
      Assert.True(challenges.ClosedBrackets("{{}}{}"));
      Assert.True(challenges.ClosedBrackets("Lorem { ipsum dolor sit amet, consectetur adipiscing elit, sed do { eiusmod tempor incididunt ut labore }et dolore magna aliqua.Ut enim ad minim ven} iam,"));
      Assert.False(challenges.ClosedBrackets("{{}}}{"));
      Assert.False(challenges.ClosedBrackets("}{"));
      Assert.False(challenges.ClosedBrackets("{{}"));
      Assert.False(challenges.ClosedBrackets("{}}"));
      Assert.False(challenges.ClosedBrackets("Duis{ aute irure dolor }in reprehenderit {in { voluptate} velit esse cillum dolore eu fugiat nulla pariatur."));
    }

    [Fact]
    public void SumTest()
    {
      Challenges challenges = new();
      Assert.Equal(233168, challenges.SumOfMultipleOfThreeOrFive(1000));
      Assert.Equal(23, challenges.SumOfMultipleOfThreeOrFive(10));
    }
  }
}
