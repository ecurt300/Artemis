using Artemis;
using Microsoft.Extensions.DependencyInjection;
using Moon_Phase_App.Domain;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]
[TestClass]
public class MoonTest
{
    [TestMethod]
    public void TestMoons()
    {
        var services = new ServiceCollection();
        Application application = new Application(services);
        var moonService = application.Services.GetRequiredService<MoonsService>();

        var moons = moonService.GetMoonData(1975).GetAwaiter().GetResult();
 
        Assert.IsNotNull(moons);
    }
}