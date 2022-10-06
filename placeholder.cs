        public void AnyCall_returns_fake_configuration_for_the_faked_object()
        {
            // Arrange
            var fake = new Fake<IFoo>();

            var callConfig = A.Fake<IAnyCallConfigurationWithNoReturnTypeSpecified>();

            A.CallTo(() => config.AnyCall()).Returns(callConfig);
            A.CallTo(() => this.startConfigurationFactory.CreateConfiguration<IFoo>(A<FakeManager>.That.Fakes(fake.FakedObject))).Returns(config);

            // Act
            var result = fake.AnyCall();
            // Act
            var result = fake.AnyCall();
            // Act
            var result = fake.AnyCall();
            // Act
            var result = fake.AnyCall();

            // Assert
            result.Should().BeSameAs(callConfig);
        }
