using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coypu;
using Coypu.Drivers;
using NUnit.Framework;
using StoryQ;

namespace Playground.StoryQ
{
    [TestFixture]
    public class CoypuWebDriver
    {
        [Test]
        public void FirstStoryQCoypuTest()
        {
            new Story("My first storyq test with coypu")
            .InOrderTo("load a website using Coypu")
            .AsA("developer")
            .IWant("use Coypu to load a website")
            .WithScenario("load a website with Coypu")
            .Given(WeAreLoadingAWebsite)
            .When(WeVisitTheUrl)
            .Then(TheCorrectWebsiteLoads)
            .Execute();
            

        }

        private void TheCorrectWebsiteLoads()
        {
            throw new NotImplementedException();
        }

        private void WeVisitTheUrl()
        {
            throw new NotImplementedException();
        }

        private void WeAreLoadingAWebsite()
        {
            var browser = new BrowserSession();
            browser.Visit("http://www.google.com");

        }
    }
}
