namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public partial class TestData
    {

        public const string AzureFunctionsConfigurationJson = @"{
    ""ApiBartersQuery"": ""{ barters { level requiredItems { item { id } quantity } rewardItems { item { id } quantity } trader { normalizedName } taskUnlock { id name wikiLink } } }"",
    ""ApiItemsQuery"": ""{ items { categories { id } conflictingItems { id } iconLink id inspectImageLink link name properties { __typename ... on ItemPropertiesAmmo { accuracyModifier armorDamage caliber damage durabilityBurnFactor fragmentationChance heavyBleedModifier initialSpeed lightBleedModifier penetrationChance penetrationPower projectileCount recoilModifier ricochetChance stackMaxSize tracer } ... on ItemPropertiesArmor { class durability ergoPenalty material { name } speedPenalty turnPenalty zones } ... on ItemPropertiesArmorAttachment { blindnessProtection class durability ergoPenalty headZones material { name } speedPenalty turnPenalty } ... on ItemPropertiesBackpack { capacity ergoPenalty speedPenalty turnPenalty } ... on ItemPropertiesBarrel { ergonomics recoilModifier slots { nameId filters { allowedItems { id } } } } ... on ItemPropertiesChestRig { capacity class durability ergoPenalty material { name } speedPenalty turnPenalty zones } ... on ItemPropertiesContainer { capacity } ... on ItemPropertiesGlasses { blindnessProtection class durability material { name } } ... on ItemPropertiesGrenade { contusionRadius fragments fuse maxExplosionDistance minExplosionDistance type } ... on ItemPropertiesHelmet { blocksHeadset class deafening durability ergoPenalty headZones material { name } ricochetX slots { nameId filters { allowedItems { id } } } speedPenalty turnPenalty } ... on ItemPropertiesMagazine { allowedAmmo { id } ammoCheckModifier capacity ergonomics loadModifier malfunctionChance slots { nameId filters { allowedItems { id } } } } ... on ItemPropertiesPreset { baseItem { id } moa } ... on ItemPropertiesMelee { hitRadius slashDamage stabDamage } ... on ItemPropertiesScope { ergonomics recoilModifier slots { nameId filters { allowedItems { id } } } zoomLevels } ... on ItemPropertiesWeapon { caliber defaultPreset { id } ergonomics fireModes fireRate recoilHorizontal recoilVertical slots { nameId filters { allowedItems { id } } } } ... on ItemPropertiesWeaponMod { accuracyModifier ergonomics recoilModifier slots { nameId filters { allowedItems { id } } } } } shortName weight wikiLink } }"",
    ""ApiPresetsQuery"": ""{ items(type: preset) { containsItems { item { id } quantity } id } }"",
    ""ApiPricesQuery"": ""{ items { id buyFor { currency price priceRUB vendor { ... on TraderOffer { minTraderLevel taskUnlock { id name wikiLink } trader { normalizedName } } ... on FleaMarket { normalizedName } } } } }"",
    ""ApiUrl"": ""https://api.tarkov.dev/graphql"",
    ""AzureBlobStorageConnectionString"": ""DefaultEndpointsProtocol=https;AccountName=;AccountKey=;EndpointSuffix=core.windows.net"",
    ""AzureBlobStorageRawDataContainerName"": ""totov-builder-raw-data"",
    ""AzureBlobStorageWebsiteContainerName"": ""$web"",
    ""AzureFunctionsConfigurationBlobName"": ""azure-functions-configuration.json"",
    ""CacheDuration"": 43200,
    ""FetchTimeout"": 30,
    ""PriceCacheDuration"": 3600,
    ""RawArmorPenetrationsBlobName"": ""armor-penetrations.json"",
    ""RawChangelogBlobName"": ""changelog.json"",
    ""RawItemCategoriesBlobName"": ""item-categories.json"",
    ""RawItemMissingPropertiesBlobName"": ""item-missing-properties.json"",
    ""RawTarkovValuesBlobName"": ""tarkov-values.json"",
    ""RawWebsiteConfigurationBlobName"": ""website-configuration.json"",
    ""WebsiteChangelogBlobName"": ""data/changelog.json"",
    ""WebsiteItemCategoriesBlobName"": ""data/item-categories.json"",
    ""WebsiteItemsBlobName"": ""data/items.json"",
    ""WebsitePresetsBlobName"": ""data/presets.json"",
    ""WebsitePricesBlobName"": ""data/prices.json"",
    ""WebsiteTarkovValuesBlobName"": ""data/tarkov-values.json"",
    ""WebsiteWebsiteConfigurationBlobName"": ""data/website-configuration.json""
}";
    }
}
