using Xunit;
using System;
using System.Collections.Generic;

namespace FindNReplace
{
  public class FindNReplaceProgramTest
  {
    [Fact]
    public void FindAndReplace_IfWordMatchesExactly_Replace()
    {
       FindNReplaceProgram testFindandReplace = new FindNReplaceProgram();
       Assert.Equal("hello universe", testFindandReplace.FindAndReplace("hello world", "world", "universe"));
    }
    [Fact]
    public void FindAndReplace_IfWordMatchesRegardlessOfCap_Replace()
    {
      FindNReplaceProgram testFindandReplace = new FindNReplaceProgram();
      Assert.Equal("Hello universe", testFindandReplace.FindAndReplace("Hello World", "world", "universe"));
    }
    [Fact]
    public void FindAndReplace_IfWordMatchesPartially_Replace()
    {
      FindNReplaceProgram testFindandReplace = new FindNReplaceProgram();
      Assert.Equal("Halo World", testFindandReplace.FindAndReplace("Hello World", "Hell", "Hal"));
    }

    [Fact]
    public void FindAndReplace_IfWordMatchesPartiallyCaseInsensitive_Replace()
    {
      FindNReplaceProgram testFindandReplace = new FindNReplaceProgram();
      Assert.Equal("Halo World", testFindandReplace.FindAndReplace("hello World", "Hell", "Hal"));
    }
  }
}
