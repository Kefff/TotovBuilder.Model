using System;
using System.Collections.Generic;
using TotovBuilder.Model.Configuration;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static ChangelogEntry[] Changelog { get; } =
        [
            new ChangelogEntry()
            {
                Changes =
                [
                    new()
                    {
                        { "en", "Added a thing." },
                        { "fr", "Ajout d'une chose." }
                    }
                ],
                Date = new DateTime(2022, 1, 2),
                Version = "1.5.0",
            },
            new ChangelogEntry()
            {
                Changes =
                [
                    new()
                    {
                        { "en", "Added a thing." },
                        { "fr", "Ajout d'une chose." }
                    }
                ],
                Date = new DateTime(2022, 1, 2),
                Version = "1.4.0",
            },
            new ChangelogEntry()
            {
                Changes =
                [
                    new()
                    {
                        { "en", "Added a thing." },
                        { "fr", "Ajout d'une chose." }
                    }
                ],
                Date = new DateTime(2022, 1, 2),
                Version = "1.3.0",
            },
            new ChangelogEntry()
            {
                Changes = [
                    new()
                    {
                        { "en", "Added a thing." },
                        { "fr", "Ajout d'une chose." }
                    }
                ],
                Date = new DateTime(2022, 1, 2),
                Version = "1.2.0",
            },
            new ChangelogEntry()
            {
                Changes =
                [
                    new()
                    {
                        { "en", "Added a thing." },
                        { "fr", "Ajout d'une chose." }
                    }
                ],
                Date = new DateTime(2022, 1, 2),
                Version = "1.1.0",
            },
            new ChangelogEntry()
            {
                Changes =
                [
                    new()
                    {
                        { "en", "Initial release." },
                        { "fr", "Sortie initiale." }
                    }
                ],
                Date = new DateTime(2022, 1, 1),
                Version = "1.0.0"
            }
        ];
    }
}
