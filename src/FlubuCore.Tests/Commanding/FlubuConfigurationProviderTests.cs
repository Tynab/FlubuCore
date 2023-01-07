﻿using FlubuCore.Commanding;
using Xunit;

namespace FlubuCore.Tests.Commanding
{
    public class FlubuConfigurationProviderTests
    {
        private FlubuConfigurationProvider _flubuConfigurationProvider;

        public FlubuConfigurationProviderTests()
        {
            _flubuConfigurationProvider = new FlubuConfigurationProvider();
        }

        [Fact]
        public void BuildConfiguration_GetSimpleKeyValueSettingsFromJsonFile_Succesfull()
        {
           var dictionary = _flubuConfigurationProvider.GetConfiguration("appsettings.json");
           Assert.Equal(2, dictionary.Count);
           Assert.Equal("value1_from_json", dictionary["option1"]);
        }

        [Fact]
        public void BuildConfiguration_NonExistingJsonConfigurationFile_ReturnsEmptyDictionary()
        {
            var dictionary = _flubuConfigurationProvider.GetConfiguration("nonExist.json");
            Assert.Empty(dictionary);
        }
    }
}
