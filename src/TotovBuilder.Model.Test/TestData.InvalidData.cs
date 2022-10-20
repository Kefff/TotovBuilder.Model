namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public const string EmptyApiData1 = @"{
  ""data"": {
    ""items"": {}
  }
}";

        public const string EmptyApiData2 = @"{
  ""data"": {
    ""items"": []
  }
}";

        public const string EmptyApiData3 = @"{
  ""data"": {
    ""items"": """"
  }
}";

        public const string InvalidApiData1 = @"{
  data"": {
    ""items"": null
  }
}";

        public const string InvalidApiData2 = @"{
  ""invalid"": {
    ""items"": null
  }
}";

        public const string InvalidApiData3 = @"{
  ""data"": {
    ""invalid"": null
  }
}";
    }
}
