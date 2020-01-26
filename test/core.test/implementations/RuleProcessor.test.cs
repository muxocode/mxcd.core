using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using mxcd.core.rules;
using mxcd.core.rules.implementations;
using Moq;
using core.test.clases;
using System.Diagnostics;

namespace core.test.implementations
{
    public class RuleProcessorTest
    {
        /*private readonly MockRepository mockRepository;

        private readonly Mock<IRule<TestUser>> correctRule1;
        private readonly Mock<IRule<TestUser>> correctRule2;
        private readonly Mock<IRule<TestUser>> falseRule1;
        private readonly Mock<IRule<TestUser>> falseRule2;


        public RuleProcessorTest()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.correctRule1 = this.mockRepository.Create<IRule<TestUser>>();
            this.correctRule2 = this.mockRepository.Create<IRule<TestUser>>();
            this.falseRule1 = this.mockRepository.Create<IRule<TestUser>>();
            this.falseRule2 = this.mockRepository.Create<IRule<TestUser>>();

            this.correctRule1.Setup(x => x.Check(It.IsAny<TestUser>())).Returns(new Task<bool>(() => true));
            this.correctRule2.Setup(x => x.Check(It.IsAny<TestUser>())).Returns(new Task<bool>(() => true));
            this.falseRule1.Setup(x => x.Check(It.IsAny<TestUser>())).Returns(new Task<bool>(() => false));
            this.falseRule2.Setup(x => x.Check(It.IsAny<TestUser>())).Returns(new Task<bool>(() => false));
        }

        internal void Dispose()
        {
            this.mockRepository.VerifyAll();
        }*/
        [Fact]
        public async Task NULL()
        {
            // Arrange
            var ruleProcessor = new RuleProcessor<TestUser>(null);

            // Act
            var result = await ruleProcessor.CheckRules(new TestUser());

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Correct()
        {
            // Arrange
            var myParams = new List<IRule<TestUser>>() { new CorrectRule() };
            var ruleProcessor = new RuleProcessor<TestUser>(myParams);

            // Act
            var result = await ruleProcessor.CheckRules(new TestUser());

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Correct_Array()
        {
            // Arrange
            var myParams = new List<IRule<TestUser>>() { new CorrectRule(), new CorrectRule(), new CorrectRule() };
            var ruleProcessor = new RuleProcessor<TestUser>(myParams);

            // Act
            var result = await ruleProcessor.CheckRules(new TestUser());

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Wrong()
        {
            // Arrange
            var myParams = new List<IRule<TestUser>>() { new WrongRule() };
            var ruleProcessor = new RuleProcessor<TestUser>(myParams);

            // Act
            var result = await ruleProcessor.CheckRules(new TestUser());

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task Wrong_Array()
        {
            // Arrange
            var myParams = new List<IRule<TestUser>>() { new WrongRule(), new WrongRule(), new WrongRule() };
            var ruleProcessor = new RuleProcessor<TestUser>(myParams);

            // Act
            var result = await ruleProcessor.CheckRules(new TestUser());

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task Mix()
        {
            // Arrange
            var myParams = new List<IRule<TestUser>>() { new CorrectRule(), new WrongRule(), new CorrectRule() };
            var ruleProcessor = new RuleProcessor<TestUser>(myParams);

            // Act
            var result = await ruleProcessor.CheckRules(new TestUser());

            // Assert
            Assert.False(result);
        }

        /*[Fact]
        public async Task PruebaSinTaskAll()
        {
            // Arrange
            for (int i = 0; i < 100; i++)
            {
                await Task.Run(() =>
                {
                    Trace.WriteLine($"PruebaSinTaskAll {i}");
                    System.Threading.Thread.Sleep(500);
                });
            }
        }

        [Fact]
        public async Task PruebaConTaskAll()
        {
            List<Task> aLista = new List<Task>();
            // Arrange
            for (int i = 0; i < 100; i++)
            {
                aLista.Add(Task.Run(() =>
                {
                    Trace.WriteLine($"PruebaConTaskAll {i}");
                    System.Threading.Thread.Sleep(500);
                }));
            }

            await Task.WhenAll(aLista);
        }*/
    }
}
