using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace DesignPatterns.Singleton
{
    public class Game
    {
        public static Game Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Game();
                        }
                    }
                }
                return _instance;
            } 
        }

        private static Game _instance;
        private static Object _lock = new Object();

        public Game()
        {
            Console.Write("Building instance");
        }
        public void Execute()
        {
            Console.WriteLine("Executing Game");
        }
    }
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void Should_Always_Return_Same_Instance()
        {
            var instance1 = Game.Instance;
            var instance2 = Game.Instance;
            Assert.That(instance2, Is.EqualTo(instance1));
        }

        [Test]
        public void Should_Resolve_Same_Instance_Using_Container()
        {
            var container = new UnityContainer();
            container.RegisterType<Game>(new ContainerControlledLifetimeManager());
            var instance1 = container.Resolve<Game>();
            var instance2 = container.Resolve<Game>();
            Assert.That(instance2, Is.EqualTo(instance1));
        }
    }
}
