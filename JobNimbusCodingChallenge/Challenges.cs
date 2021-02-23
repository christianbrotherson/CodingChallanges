namespace JobNimbusCodingChallenge
{
  using System;
  using System.Collections.Generic;
  using System.Text;
  using System.Linq;

  /// <summary>
  /// A class that contains the challenge problems.
  /// </summary>
  class Challenges
  {
    /// <summary>
    /// Determines whether any brackets within the string are closed properly.
    /// </summary>
    /// <param name="str">The string to check.</param>
    /// <returns>True if all brackets are closed.</returns>
    public bool ClosedBrackets(string str)
    {
      var chars = str.ToCharArray().ToList();

      // Check to see if any obvious failing cases are present in the string.
      if ((chars.FindAll(x => x == '{').Count != chars.FindAll(x => x == '}').Count) ||
        (chars.IndexOf('{') > chars.IndexOf('}')))
      {
        return false;
      }
      else
      {
        int open = 0;
        int closed = 0;
        foreach (var c in chars)  // ensure that the closing brackets never exceed the opening brackets in the string.
        {
          if (closed > open) return false;
          if (c == '{') open++;
          else if (c == '}') closed++;
        }

        return true;
      }
    }

    /// <summary>
    /// Determines whether any brackets within the string are closed properly using a stack.
    /// </summary>
    /// <param name="str">The string to check.</param>
    /// <returns>True if the brackets close correctly.</returns>
    public bool ClosedBracketsStack(string str)
    {
      List<char> stack = new();
      var chars = str.ToCharArray().ToList();

      if (chars.Count == 0) return true;

      foreach (var c in chars)
      {
        if (c == '{') stack.Add(c);
        else if (c == '}')
        {
          if (stack.Count != 0) stack.RemoveAt(stack.Count - 1);
          else return false;
        }
      }

      return stack.Count > 0 ? false : true;
    }

    /// <summary>
    /// Finds the sum of all numbers in the provided range that are divisible by three and five.
    /// </summary>
    /// <param name="range">The range for the sum.</param>
    /// <returns>The sum.</returns>
    public int SumOfMultipleOfThreeOrFive(int range)
    {
      // create range of numbers --> find all numbers divisible by 3 and 5 --> add the result together and return.
      return Enumerable.Range(1, range - 1).Where(x => (x % 3 == 0) || (x % 5 == 0)).Sum();
    }
  }
}
