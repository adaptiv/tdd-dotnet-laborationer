/*
 * PM Library (TDD training project)
 * Joakim Holm & Måns Sandström
 */

using NUnit.Framework;

namespace HelloWorld
{
	[TestFixture]
	public class HelloWorldTest
	{
		private HelloWorld _world;

		[SetUp]
		public void SetupWorld()
		{
			_world = new HelloWorld();
		}
		
		[Test]
		public void ShouldGreetUsPolitely()
		{
			Assert.That(_world.Hello(), Is.EqualTo("Hello!"));
		}
	}
}
