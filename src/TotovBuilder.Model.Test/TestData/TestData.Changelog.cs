﻿using System;
using TotovBuilder.Model.Configuration;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static ChangelogEntry[] Changelog { get; } = new ChangelogEntry[]
        {
            new ChangelogEntry()
            {
                Changes = new ChangelogChange[]
                {
                    new ChangelogChange()
                    {
                        Language = "en",
                        Text = "Added a thing."
                    },
                    new ChangelogChange()
                    {
                        Language = "fr",
                        Text = "Ajout d'une chose."
                    }
                },
                Date = new DateTime(2022, 1, 2),
                Version = "1.5.0",
            },
            new ChangelogEntry()
            {
                Changes = new ChangelogChange[]
                {
                    new ChangelogChange()
                    {
                        Language = "en",
                        Text = "Added a thing."
                    },
                    new ChangelogChange()
                    {
                        Language = "fr",
                        Text = "Ajout d'une chose."
                    }
                },
                Date = new DateTime(2022, 1, 2),
                Version = "1.4.0",
            },
            new ChangelogEntry()
            {
                Changes = new ChangelogChange[]
                {
                    new ChangelogChange()
                    {
                        Language = "en",
                        Text = "Added a thing."
                    },
                    new ChangelogChange()
                    {
                        Language = "fr",
                        Text = "Ajout d'une chose."
                    }
                },
                Date = new DateTime(2022, 1, 2),
                Version = "1.3.0",
            },
            new ChangelogEntry()
            {
                Changes = new ChangelogChange[]
                {
                    new ChangelogChange()
                    {
                        Language = "en",
                        Text = "Added a thing."
                    },
                    new ChangelogChange()
                    {
                        Language = "fr",
                        Text = "Ajout d'une chose."
                    }
                },
                Date = new DateTime(2022, 1, 2),
                Version = "1.2.0",
            },
            new ChangelogEntry()
            {
                Changes = new ChangelogChange[]
                {
                    new ChangelogChange()
                    {
                        Language = "en",
                        Text = "Added a thing."
                    },
                    new ChangelogChange()
                    {
                        Language = "fr",
                        Text = "Ajout d'une chose."
                    }
                },
                Date = new DateTime(2022, 1, 2),
                Version = "1.1.0",
            },
            new ChangelogEntry()
            {
                Changes = new ChangelogChange[]
                {
                    new ChangelogChange()
                    {
                        Language = "en",
                        Text = "Initial release."
                    },
                    new ChangelogChange()
                    {
                        Language = "fr",
                        Text = "Sortie initiale."
                    }
                },
                Date = new DateTime(2022, 1, 1),
                Version = "1.0.0"
            }
        };
    }
}
