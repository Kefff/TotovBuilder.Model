using TotovBuilder.Model.Configuration;
using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public partial class TestData
    {
        public static ItemMissingProperties[] ItemMissingProperties { get; } = new ItemMissingProperties[]
        {
            new ItemMissingProperties()
            {
                Id = "601aa3d2b2bcb34913271e6d",
                MaxStackableAmount = 60
            },
            new ItemMissingProperties()
            {
                ConflictingItemIds = new string[]
                {
                    "5a16ba61fcdbcb098008728a",
                    "5a16b672fcdbcb001912fa83",
                    "5a16b7e1fcdbcb00165aa6c9",
                    "5aa7e3abe5b5b000171d064d",
                    "5c0e66e2d174af02a96252f4",
                    "5e00cdd986f7747473332240"
                },
                Id = "5ea18c84ecf1982c7712d9a2",
            },
            new ItemMissingProperties()
            {
                ConflictingItemIds = new string[]
                {
                    "5c0e66e2d174af02a96252f4",
                    "5c0696830db834001d23f5da",
                    "5c066e3a0db834001b7353f0",
                    "5c0558060db834001b735271",
                    "57235b6f24597759bf5a30f1",
                    "5c110624d174af029e69734c",
                    "5a16b8a9fcdbcb00165aa6ca"
                },
                Id = "5a16b7e1fcdbcb00165aa6c9",
            },
            new ItemMissingProperties()
            {
                Id = "569668774bdc2da2298b4568",
                MaxStackableAmount = 50000
            },
            new ItemMissingProperties()
            {
                Id = "57dc2fa62459775949412633",
                RangedWeaponChambers = new ModSlot[]
                {
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5c0d5e4486f77478390952fe",
                            "61962b617c6c7b169525f168",
                            "56dfef82d2720bbd668b4567",
                            "56dff026d2720bb8668b4567",
                            "56dff061d2720bb5668b4567",
                            "56dff0bed2720bb0668b4567",
                            "56dff216d2720bbd668b4568",
                            "56dff2ced2720bb4668b4567",
                            "56dff338d2720bbd668b4569",
                            "56dff3afd2720bba668b4567",
                            "56dff421d2720b5f5a8b4567",
                            "56dff4a2d2720bbd668b456a",
                            "56dff4ecd2720b5f5a8b4568"
                        },
                        Name = "chamber0"
                    }
                }
            },
            new ItemMissingProperties()
            {
                Id = "5e81c3cbac2bb513793cdc75",
                RangedWeaponChambers = new ModSlot[]
                {
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81f423763d9f754677bf2e",
                            "5efb0cabfb3e451d70735af5",
                            "5efb0fc6aeb21837e749c801",
                            "5efb0d4f4bc50b58e81710f3",
                            "5ea2a8e200685063ec28c05a"
                        },
                        Name = "chamber0"
                    }
                }
            },
            new ItemMissingProperties()
            {
                ConflictingItemIds = new string[]
                {
                    "5947db3f86f77447880cf76f",
                    "57486e672459770abd687134",
                    "5ac733a45acfc400192630e2",
                    "5649b0544bdc2d1b2b8b458a",
                    "5ac72e475acfc400180ae6fe",
                    "59d650cf86f7741b846413a4",
                    "5a0eb980fcdbcb001a3b00a6",
                    "59e8977386f77415a553c453",
                    "5649d9a14bdc2d79388b4580",
                    "5c82342f2e221644f31c060e",
                    "576fd4ec2459777f0b518431",
                    "5c82343a2e221644f31c0611",
                    "5cf638cbd7f00c06595bc936",
                    "5a7c74b3e899ef0014332c29",
                    "591ee00d86f774592f7b841e",
                    "5d0a29ead7ad1a0026013f27",
                    "57acb6222459771ec34b5cb0",
                    "5c61a40d2e2216001403158d",
                    "5c90c3622e221601da359851"
                },
                Id = "5d2c76ed48f03532f2136169"
            },
            new ItemMissingProperties()
            {
                ConflictingItemIds = new string[]
                {
                    "591c4efa86f7741030027726",
                    "570fd79bd2720bc7458b4583",
                    "570fd6c2d2720bc6458b457f",
                    "558022b54bdc2dac148b458d",
                    "58491f3324597764bc48fa02",
                    "584924ec24597768f12ae244",
                    "5b30b0dc5acfc400153b7124",
                    "60a23797a37c940de7062d02",
                    "5d2da1e948f035477b1ce2ba",
                    "5c0505e00db834001b735073",
                    "609a63b6e2ff132951242d09",
                    "584984812459776a704a82a6",
                    "59f9d81586f7744c7506ee62",
                    "570fd721d2720bc5458b4596",
                    "5c7d55f52e221644f31bff6a"
                },
                Id = "61714eec290d254f5e6b2ffc",
            }
        };
    }
}
