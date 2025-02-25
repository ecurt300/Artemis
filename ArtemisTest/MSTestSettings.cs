using MoonData.Domain;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]

[TestClass]
public class Test
{

    [TestMethod]
    public void GetAPICallToObject()
    {
        Moon moon = new Moon();
        HttpClient client = new HttpClient();
        

        Assert.IsTrue(moon.MoonDate.Year > 0);
    }
}
