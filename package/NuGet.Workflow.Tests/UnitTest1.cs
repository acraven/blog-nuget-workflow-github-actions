using NUnit.Framework;

namespace NuGet.Workflow.Tests
{
   public class UnitTest1
   {
      [Test]
      public void Test1()
      {
         var class1 = new Class1();

         Assert.That(class1.Value, Is.EqualTo("Foo"));
      }
   }
}
