using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EGN",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "437c8867-bda0-4f88-8daa-33cd48d580f1", "b051306d-a41f-42a4-a405-742e11435cf7", "Admin", "Admin" },
                    { "d0c581b9-32e9-4aef-935c-411bc7d69ff3", "aa308ade-0b8b-4882-ad2e-5f13fe40536e", "Customer", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ceebe0c9-0006-4d49-96ee-6a4bc7d494e2", 0, "d71292b5-50f5-4fb4-8a55-11747955c5fd", "1572274356", "customer71@abv.bg", false, "Nasko", "Noto", false, null, "customer71@abv.bg", "customer71@abv.bg", "AQAAAAEAACcQAAAAECUJxeaV/zGRvALY/fmPYm3C5tSkjT4y/gHu2W0Jai9sUta+wvIoOoiXTCDWA+Wyaw==", null, false, "", false, "customer71@abv.bg" },
                    { "eeaf5491-182e-45ac-a6d5-d09c1678529f", 0, "721b3980-0724-4ff1-8b6f-a9d8d5270d14", "7836685628", "customer70@abv.bg", false, "Nikolay", "Tsanov", false, null, "customer70@abv.bg", "customer70@abv.bg", "AQAAAAEAACcQAAAAEFoZ9XJi6PPTK5hPrW4tKjCUQkrmEWua+9iInXrpvZZn4ssNmO2QVptv1yDz8dyVVQ==", null, false, "", false, "customer70@abv.bg" },
                    { "81da9f5d-7815-4f87-86b1-db210e79932f", 0, "4d6b19d4-b47c-46fd-b40a-05167808377f", "4678266777", "customer69@abv.bg", false, "Peter", "Murtin", false, null, "customer69@abv.bg", "customer69@abv.bg", "AQAAAAEAACcQAAAAEJFykF22VBml8m9s8PK/WMX30LyfywOsRtnG/VrRDG2+tauRj9l9+44j9ycIIM4fyQ==", null, false, "", false, "customer69@abv.bg" },
                    { "1884c97f-0175-4b05-8efa-8044be01a002", 0, "9ed3f93e-c4fa-4de3-be50-160c16bd34f1", "3334116520", "customer68@abv.bg", false, "Kiro", "Syuleymezyan", false, null, "customer68@abv.bg", "customer68@abv.bg", "AQAAAAEAACcQAAAAEDseT6bu+fcvSZn+uZR9U/Ec336YBexEEcM+Ut9LbW0bF4TGFwkq42JZ252DLEOJnQ==", null, false, "", false, "customer68@abv.bg" },
                    { "0d0771c9-f606-41bf-b89d-9a6c4684b19d", 0, "b24af056-f007-4af2-95c3-f953a389cd78", "0518657005", "customer67@abv.bg", false, "Peter", "Murtin", false, null, "customer67@abv.bg", "customer67@abv.bg", "AQAAAAEAACcQAAAAEM7K1kKrNniwVbm7QZ18usJiJmOs0AlbQVDD3BXnVitRpiyStIaL2K/03/lSjCygEg==", null, false, "", false, "customer67@abv.bg" },
                    { "be12392a-c32a-4dc7-81e1-d9dc32e9e5f3", 0, "ff35b129-85d6-405e-a98e-7c66e46b027c", "5845280822", "customer66@abv.bg", false, "Kiro", "Noto", false, null, "customer66@abv.bg", "customer66@abv.bg", "AQAAAAEAACcQAAAAEF9Bdk5Azf+02L2RmFXw94Q5sKCSBSLud0782bLCCezmovRcKEStoHVnX2r/EHZMGQ==", null, false, "", false, "customer66@abv.bg" },
                    { "823710b1-0d4a-4765-bae6-52ae4412c2cf", 0, "d21bacff-81b6-4943-ac00-7f5365918963", "7136816684", "customer65@abv.bg", false, "Nasko", "Murtin", false, null, "customer65@abv.bg", "customer65@abv.bg", "AQAAAAEAACcQAAAAECFQMjAoyDrewoKu3QTOOuY7y89RUwo8WYexyc9dKbNmbmpKfTWYT3giY9yB1XLd3g==", null, false, "", false, "customer65@abv.bg" },
                    { "1b5a1aef-0ce7-44e7-af16-bdb50275f88f", 0, "4d446314-4760-4607-9c24-aa27b98114c4", "1133082036", "customer64@abv.bg", false, "Peter", "Tsanov", false, null, "customer64@abv.bg", "customer64@abv.bg", "AQAAAAEAACcQAAAAEO0uRD2fk45UDNjyqqCTnafTlrpIpxWu1FBTQetbEstjyO3JLo6vm0QPjCrZHtF0yg==", null, false, "", false, "customer64@abv.bg" },
                    { "18492512-bba5-42e7-9a15-34e6599091d0", 0, "f8cd7da2-ada8-4914-942b-27608e2b990c", "3780421742", "customer63@abv.bg", false, "Nasko", "Gagov", false, null, "customer63@abv.bg", "customer63@abv.bg", "AQAAAAEAACcQAAAAEGHWXrkCbehMio9ZOMtmuwQO28vmZpCOQTBXnHqmIxl/KjQGdOblvNnBF91dpZv9eA==", null, false, "", false, "customer63@abv.bg" },
                    { "cfaef36c-0b61-4c07-9b55-1faf4dee7c4a", 0, "4088b5f9-2293-4b4a-9126-35be6e187c66", "1432760752", "customer62@abv.bg", false, "Nikolay", "Noto", false, null, "customer62@abv.bg", "customer62@abv.bg", "AQAAAAEAACcQAAAAEHZBlMicisyVtcQp8Itxl5tZd2NQaXz3j5uvD5H8kQ2lbno37TGZ5lJOsXzULzHCjQ==", null, false, "", false, "customer62@abv.bg" },
                    { "2e1cc6a8-84af-4def-86de-fd89761f77d3", 0, "b63d8095-0111-4a53-a5a2-8b4624bff1b8", "6233667715", "customer61@abv.bg", false, "Peter", "Murtin", false, null, "customer61@abv.bg", "customer61@abv.bg", "AQAAAAEAACcQAAAAED4Z6Vf2Ja72hW7pi8nQiZ70zQIyjEedwruIUB7MOXKXC7uXXSuZAsEBo9mqgmQNPQ==", null, false, "", false, "customer61@abv.bg" },
                    { "0b4dfef9-e127-4684-9f38-e241742a4591", 0, "5d67f8be-6fab-4ee2-b664-42060cd66a4d", "5225011764", "customer60@abv.bg", false, "Nasko", "Tsanov", false, null, "customer60@abv.bg", "customer60@abv.bg", "AQAAAAEAACcQAAAAEGPmgfzOkovkWWjrSMKKvDHGPqffZD4j0YZ8htFEhcz6OCnp0NLuWPR/I72lBR+0AQ==", null, false, "", false, "customer60@abv.bg" },
                    { "81bae5fe-107b-45cc-b763-060db486419b", 0, "117b5bdd-196d-489d-8e75-176a845d818b", "5176362461", "customer59@abv.bg", false, "Nikolay", "Syuleymezyan", false, null, "customer59@abv.bg", "customer59@abv.bg", "AQAAAAEAACcQAAAAEIX6hKf+iR89ei/1wdlbpocqkl2uIHt6DZwaEPzkm7CsFp9T7r8nIXz4fzSoreen4g==", null, false, "", false, "customer59@abv.bg" },
                    { "f32cc995-0928-4cb7-828f-edd1b2c9a9a4", 0, "2a83da3f-37ef-465f-b73c-e9adcd564e02", "0124318386", "customer58@abv.bg", false, "Nikolay", "Noto", false, null, "customer58@abv.bg", "customer58@abv.bg", "AQAAAAEAACcQAAAAEDxz4X/k0wpAFbKCCAq+RVT/GAEaRs2qxSOHDCbuqIyFB9sx7Bdj9hDNJXvO1kICHg==", null, false, "", false, "customer58@abv.bg" },
                    { "9da155c1-e223-41dd-889d-b5d9d2c85cbd", 0, "2a4706d8-1d09-432d-a2b5-a9bb582459a8", "1464146023", "customer57@abv.bg", false, "Peter", "Gagov", false, null, "customer57@abv.bg", "customer57@abv.bg", "AQAAAAEAACcQAAAAEJ2GVl8cFIEYtllIDOr1l8jC9Y25paUrnUzpJ4SSp5yd+wEs9Go1a9PODmfAffFWMQ==", null, false, "", false, "customer57@abv.bg" },
                    { "04f47b43-cb60-44e0-bda7-0a69e1074b87", 0, "4637846f-4548-41d3-a504-2c206ec0718c", "4367660177", "customer56@abv.bg", false, "Kiro", "Syuleymezyan", false, null, "customer56@abv.bg", "customer56@abv.bg", "AQAAAAEAACcQAAAAEPCUipBnRhKoYi4sM5cU+zz0U/6ou73SUSD2T5ihbaCr+oz5fhcQ1QDVJ4eLEyEu+A==", null, false, "", false, "customer56@abv.bg" },
                    { "e1a27e3b-fc05-4d77-bf7b-2031de220852", 0, "87dc25a7-f644-482b-be02-59bb7fd68ade", "3108514082", "customer55@abv.bg", false, "Nasko", "Murtin", false, null, "customer55@abv.bg", "customer55@abv.bg", "AQAAAAEAACcQAAAAEJCIcoHipnWoXizwnZaaE//b61LH3H3N4I4uhASB1Fmv4KiCy4RrPwYMj9RNSWf6Hg==", null, false, "", false, "customer55@abv.bg" },
                    { "c26d3bd6-e239-40bd-a60d-b9786a6a614b", 0, "d9874d28-5c2a-4154-af02-d96e3d16fdc8", "4064122822", "customer54@abv.bg", false, "Peter", "Tsanov", false, null, "customer54@abv.bg", "customer54@abv.bg", "AQAAAAEAACcQAAAAECoq0soHh+xvNnHP0B6wVf2MIcz2royHSzzTwSBtHhdtMAvIlBl9rudaFy+u8OG4Uw==", null, false, "", false, "customer54@abv.bg" },
                    { "7869b58e-2540-4180-814a-005c46ed5243", 0, "8932a0c7-3705-4000-a0af-7f395625e463", "4721141070", "customer53@abv.bg", false, "Peter", "Gagov", false, null, "customer53@abv.bg", "customer53@abv.bg", "AQAAAAEAACcQAAAAEL2Pu7oXoNyIoyhEHZ2fT0ctnnRBFbm29gmEToPDNEqJbTdWuUPqRTfdN5dFg1LL3Q==", null, false, "", false, "customer53@abv.bg" },
                    { "432cc6d9-5ffa-44c4-83f1-72e3e712c343", 0, "fd1c3ad5-43f9-4366-9852-bf08b8eba665", "7448252310", "customer52@abv.bg", false, "Nikolay", "Noto", false, null, "customer52@abv.bg", "customer52@abv.bg", "AQAAAAEAACcQAAAAEG7AMzOZuNnRcxSVHY6Br5JWYO3elEpvm18La2bb17K0mippaYlywbTwGyhvHg24kA==", null, false, "", false, "customer52@abv.bg" },
                    { "08042f0a-56ff-4a40-89ee-c82e966a9390", 0, "ca84a354-5891-4e92-94d6-4f53c030ce1b", "0610030010", "customer51@abv.bg", false, "Kiro", "Noto", false, null, "customer51@abv.bg", "customer51@abv.bg", "AQAAAAEAACcQAAAAELq/28b7NiDhgp9w50XbH6Hc/VKgrImYJC709GxA9jG1KK4ObwLrS7dGNoP5rbIKpg==", null, false, "", false, "customer51@abv.bg" },
                    { "b68b6c1f-8e48-444a-9487-8f3303ae7a51", 0, "6aeb3a5a-7e04-4a12-958a-98462a5f91f3", "8374606110", "customer50@abv.bg", false, "Kiro", "Tsanov", false, null, "customer50@abv.bg", "customer50@abv.bg", "AQAAAAEAACcQAAAAEDLMP8YCFjdq/qwNyHADZSjWMZ3paguFgx3LMzjoPahjmmgTyskDkpKQGzmpmWYSDQ==", null, false, "", false, "customer50@abv.bg" },
                    { "967ba096-4682-4594-8e0d-67049cad525f", 0, "f2ba6543-807e-49ad-859d-d4b9b47b7bed", "7863787078", "customer72@abv.bg", false, "Peter", "Murtin", false, null, "customer72@abv.bg", "customer72@abv.bg", "AQAAAAEAACcQAAAAEGAoaKsMjJR5cOraNOF3mTNb3sYj6nBcHVUBWtdPipH6V/MgZAxNZPUK9xjRR3BtUw==", null, false, "", false, "customer72@abv.bg" },
                    { "85f2f828-39a0-4ad8-9730-93c670901404", 0, "7182dacb-e38e-4d38-b083-96aeff54f9c6", "6353420803", "customer73@abv.bg", false, "Kiro", "Tsanov", false, null, "customer73@abv.bg", "customer73@abv.bg", "AQAAAAEAACcQAAAAEC2OdnONDVQ9NfA46fanBHBG/kXiMzgvsmWMXYmnALvSR+Fj9sodQqNSlTc9xZMIRQ==", null, false, "", false, "customer73@abv.bg" },
                    { "48247e9f-7d55-44bc-ac49-f317a0db4c0b", 0, "b3341588-6b13-477d-a326-dc2c8701c043", "7012287418", "customer74@abv.bg", false, "Nasko", "Syuleymezyan", false, null, "customer74@abv.bg", "customer74@abv.bg", "AQAAAAEAACcQAAAAEJccWsu9i0KU7iHtH9ng+Du0oi3GYu+ait/Odjq1KCjKq/Jg3K88hjPwngK93LNgFg==", null, false, "", false, "customer74@abv.bg" },
                    { "35363f8f-3841-49d4-b734-fc68416238ae", 0, "cec20d04-70e1-4729-88c6-a1b4b740fc48", "7437670577", "customer75@abv.bg", false, "Nikolay", "Tsanov", false, null, "customer75@abv.bg", "customer75@abv.bg", "AQAAAAEAACcQAAAAEKi5KXkgaZlcoolHhz6MJC8N6zGjWHD+e1owny40Mr7xkuldiVwyHFsZ4G0srbEV9Q==", null, false, "", false, "customer75@abv.bg" },
                    { "6c7ec71c-15de-47b9-82ea-7fa90c4cdeb3", 0, "c2175458-f72e-4dac-8618-c4016d2c18f3", "7602520580", "customer97@abv.bg", false, "Nikolay", "Gagov", false, null, "customer97@abv.bg", "customer97@abv.bg", "AQAAAAEAACcQAAAAEOJ3ImUcCfNXJY34oT0CIT6opUg8yF3cAF6emnc9O4oeuQPiaQ2mPr1vZZVuyKjOqg==", null, false, "", false, "customer97@abv.bg" },
                    { "1215e32b-6168-4ae9-97e9-2a23d255a83f", 0, "47d64b71-8011-464e-b388-58d54b29039f", "8373862536", "customer96@abv.bg", false, "Kiro", "Murtin", false, null, "customer96@abv.bg", "customer96@abv.bg", "AQAAAAEAACcQAAAAEP0schgeM3Q/r71ruYo0p6u/r5WPfPyP0Z4bl1rcfjbHREWohqwvDKVtAyAnhuHBEQ==", null, false, "", false, "customer96@abv.bg" },
                    { "656b9c5f-3e45-4dc2-ba59-f4308ded43f5", 0, "8b4c7dc4-36bf-4961-a226-c241fbd31fff", "6015746154", "customer95@abv.bg", false, "Kiro", "Gagov", false, null, "customer95@abv.bg", "customer95@abv.bg", "AQAAAAEAACcQAAAAEAYeLBaHKcnOJ5KTkVBpeQSBU6mur+azLHWxGP3z1tTHeSVGHkdlDygJ2fhBjxtv0Q==", null, false, "", false, "customer95@abv.bg" },
                    { "c4d45f8d-fdf0-41b7-8778-2286dd502932", 0, "129cffbc-777a-4335-a314-7d0eee80944b", "8825657778", "customer94@abv.bg", false, "Peter", "Murtin", false, null, "customer94@abv.bg", "customer94@abv.bg", "AQAAAAEAACcQAAAAEEkEaDmf4IHFyIRaxkW90Ym//qxAMU0b8bA5zfEZ5gOkeTp8T/TVWWUsjfzuFtTv0A==", null, false, "", false, "customer94@abv.bg" },
                    { "6daaa969-13e1-42c0-82f5-98c03057ebfb", 0, "1a062879-09fc-4dfa-9d11-9ae0d59338ed", "6255837477", "customer93@abv.bg", false, "Nasko", "Tsanov", false, null, "customer93@abv.bg", "customer93@abv.bg", "AQAAAAEAACcQAAAAEOsTfs/yPqRd9Fta7Xt2vrvzvSko5Xa26+fNmYMrUqT8Jf38g9wEtlLD2BlYq125zw==", null, false, "", false, "customer93@abv.bg" },
                    { "25896b1b-2dcf-4de2-b53b-8ba298b3a71c", 0, "dcd8c789-2a4b-4d81-aa29-2af9fb77e125", "3370522207", "customer92@abv.bg", false, "Peter", "Tsanov", false, null, "customer92@abv.bg", "customer92@abv.bg", "AQAAAAEAACcQAAAAEKxwAmPbvTR703vDWtyu0lEHv9yLSkAD58z4SoRijNkPn5SwvcVFSxiZOIn0jI9rFw==", null, false, "", false, "customer92@abv.bg" },
                    { "6a980e2c-f534-4a5d-bd24-c09a19b73383", 0, "f87d48e2-2775-4c29-b0d3-36286229541c", "7768701170", "customer91@abv.bg", false, "Kiro", "Noto", false, null, "customer91@abv.bg", "customer91@abv.bg", "AQAAAAEAACcQAAAAEDAIX+wQZNeweOn7mww9o6CA99wwMmcPSkrIAlqjeAFobo+mryGy2WX/3PSQv1+nVA==", null, false, "", false, "customer91@abv.bg" },
                    { "617a02c6-b4cc-4593-96eb-4f6b32d7fcd5", 0, "1a7c2a7c-ee52-4d6e-bb32-d896bea1224e", "0625055711", "customer90@abv.bg", false, "Kiro", "Noto", false, null, "customer90@abv.bg", "customer90@abv.bg", "AQAAAAEAACcQAAAAEKootmYlRQcmqcEISRCjnL3wn1x4b7hObq044o9BjiNqY9RFD4vaEXN6ME2LwRGm0A==", null, false, "", false, "customer90@abv.bg" },
                    { "0e1abe7d-2a90-494e-9226-b7820608fc49", 0, "7e3cdc06-0d8a-4118-a869-92ffd2289350", "4736205753", "customer89@abv.bg", false, "Peter", "Noto", false, null, "customer89@abv.bg", "customer89@abv.bg", "AQAAAAEAACcQAAAAENM6rz1mYO1Xy2jEVmvX6uJTSi0kWWr7OB5KE2+Q0Yv52yzfkMEcncew5ymmeGCDiA==", null, false, "", false, "customer89@abv.bg" },
                    { "76295d2c-4881-4d8f-a33d-61353826102b", 0, "fe1268bb-ba07-412e-a5b3-81415e1e4051", "0214421221", "customer88@abv.bg", false, "Kiro", "Noto", false, null, "customer88@abv.bg", "customer88@abv.bg", "AQAAAAEAACcQAAAAEGutS4VV7wxii8W0qKuba07lWHpgDtp4RCRtIMvvJGaqIdqEm5FOMfmTEnh2QRyNzg==", null, false, "", false, "customer88@abv.bg" },
                    { "143c4fb7-15d9-4a22-b810-90b7a0874e86", 0, "fb623ef3-268c-49a5-88fa-29f4b8d4b39d", "2178833258", "customer49@abv.bg", false, "Nasko", "Syuleymezyan", false, null, "customer49@abv.bg", "customer49@abv.bg", "AQAAAAEAACcQAAAAEBpfREVxiv0yXuMm2Sh55FfMfl0sCzZ1AdZZi1ydV67lDgO+pPfBOwv3qr/6+nxhyw==", null, false, "", false, "customer49@abv.bg" },
                    { "d01144d1-0a29-4a54-af8e-1eb84df4b41d", 0, "dbfdd762-e2ec-4068-bfed-e0e770bff329", "2056435100", "customer87@abv.bg", false, "Nikolay", "Syuleymezyan", false, null, "customer87@abv.bg", "customer87@abv.bg", "AQAAAAEAACcQAAAAEN03f5T51gBZY1NcnIoTkpk9Agel+E8iM7sMNWog9cSdTO+S3bE+aELbOZ52VlasNQ==", null, false, "", false, "customer87@abv.bg" },
                    { "bfc8fbec-d764-465d-ab85-9e800838bfce", 0, "7ee388fb-ce1c-4346-91f7-2147a630dd4e", "2102725721", "customer85@abv.bg", false, "Kiro", "Gagov", false, null, "customer85@abv.bg", "customer85@abv.bg", "AQAAAAEAACcQAAAAEPe9VmVOSitVsw9bW5jp3YVonuZ0ctiY5P4bTpgqMMRPIphNyaLEBC0JEtr8oA22zQ==", null, false, "", false, "customer85@abv.bg" },
                    { "d5031b00-849b-47c5-a868-8b614e530935", 0, "ba200431-414a-4fc7-869f-3cb4fbf302d6", "8748477073", "customer84@abv.bg", false, "Nikolay", "Tsanov", false, null, "customer84@abv.bg", "customer84@abv.bg", "AQAAAAEAACcQAAAAENH4sOCV2TEBqT8dgR6mCL3cgXXVXTZRMY8wl9J+KNUXi4l1EkRhWRjdApqPi8J9Ww==", null, false, "", false, "customer84@abv.bg" },
                    { "74fa61e5-610a-4fc9-8d4e-69105e04fa72", 0, "0353b9b8-6628-47ef-96c4-cc427a4ecdc3", "8685064681", "customer83@abv.bg", false, "Nikolay", "Murtin", false, null, "customer83@abv.bg", "customer83@abv.bg", "AQAAAAEAACcQAAAAEJXC+lJUlHrEvmGinsl5UNadKhQdAzIaIzC+BQ7/dgr4Da4hc1qvS2ZThGoQoOk4Ww==", null, false, "", false, "customer83@abv.bg" },
                    { "3f3acbe4-a7e4-4b82-b70f-044e22cd767f", 0, "0e04ec8b-710d-46e9-8dd2-a76031c64aa7", "5536761353", "customer82@abv.bg", false, "Kiro", "Gagov", false, null, "customer82@abv.bg", "customer82@abv.bg", "AQAAAAEAACcQAAAAENGgIt40Wyp9fCjmC7A1ypSy2vkrqHmfiZ6hNjbZun0cc4HIDzRcO8vaJO748aCJcg==", null, false, "", false, "customer82@abv.bg" },
                    { "c379e547-f047-4944-a6f6-aac480820cf4", 0, "b4387386-31a1-4916-a1f5-b5d7d7a01ce5", "2851054576", "customer81@abv.bg", false, "Nikolay", "Murtin", false, null, "customer81@abv.bg", "customer81@abv.bg", "AQAAAAEAACcQAAAAEIR6TKIDmE+WjD+s3Rm0OKtQZk7mk+YkkxRVjsT7m6moDU4QRVlpksRMwJxmNV5kWg==", null, false, "", false, "customer81@abv.bg" },
                    { "ec945073-e5bf-48cd-bc86-27baa5496016", 0, "5f82b68c-9a4b-43ea-bb0e-ef6b6871dacc", "1856731536", "customer80@abv.bg", false, "Nikolay", "Murtin", false, null, "customer80@abv.bg", "customer80@abv.bg", "AQAAAAEAACcQAAAAEHT0S65mxfh9t199AJrmwjuoLbV4y5WoUb3Z/qAStaBJC9WatRof5VTyMRiQL6lKvA==", null, false, "", false, "customer80@abv.bg" },
                    { "4f9a38ed-0275-41e3-a337-282a09f5a280", 0, "530b8020-829b-44ab-be1c-f84e87837cc8", "7362387788", "customer79@abv.bg", false, "Kiro", "Syuleymezyan", false, null, "customer79@abv.bg", "customer79@abv.bg", "AQAAAAEAACcQAAAAEJnnCT0zdqZE4P+fFF9RRnEwI2o2PqN2qoVQSbcv+m8tlVm3kNArX4AHybrQ14BMyQ==", null, false, "", false, "customer79@abv.bg" },
                    { "9b00963d-34d5-46c3-bda7-5ddc274dbcff", 0, "24ce5e51-4372-422b-9ce6-aedeee5982d6", "2101867054", "customer78@abv.bg", false, "Nikolay", "Syuleymezyan", false, null, "customer78@abv.bg", "customer78@abv.bg", "AQAAAAEAACcQAAAAEEmBCsGJY3jGX+8s7n/O1l/QrmLllBHl2ggpY8POPEWkwYCvDQfFG1hiKAMp3BTWVQ==", null, false, "", false, "customer78@abv.bg" },
                    { "9d1d4b96-a43b-4606-b1f1-1357a664d69f", 0, "90980586-6f0f-4945-a141-a5a6e14b69c2", "1353552434", "customer77@abv.bg", false, "Kiro", "Gagov", false, null, "customer77@abv.bg", "customer77@abv.bg", "AQAAAAEAACcQAAAAED3QmB7RYVkgeb4jG3NZVzsxX57VhiMCY+y7SOmu4YclXBVFD+wbC9q2/zKzgFm6FA==", null, false, "", false, "customer77@abv.bg" },
                    { "6bc9cd5c-9cf4-4ad4-9dd2-ec0e03756d6c", 0, "93715222-2df7-49d4-a1ff-e3c38b70b70a", "3467883542", "customer76@abv.bg", false, "Peter", "Murtin", false, null, "customer76@abv.bg", "customer76@abv.bg", "AQAAAAEAACcQAAAAELexsAU91GU9AWGK4LA7urQ2zMZu57Cj4eSNOyl3qhD2lRU1F9ot7MPvBM6rVfsSKQ==", null, false, "", false, "customer76@abv.bg" },
                    { "c74ce8ed-98a9-4968-929e-a95bcaea619f", 0, "39a181ad-74bb-4bdc-bab8-3e387e216bd2", "0602502264", "customer86@abv.bg", false, "Peter", "Murtin", false, null, "customer86@abv.bg", "customer86@abv.bg", "AQAAAAEAACcQAAAAEK2YQkefZD3ZO2TdjwG66LObwz+DTWgc3fVSTclGIaak0Uq3LWHdlNhxTo6ipgAdoQ==", null, false, "", false, "customer86@abv.bg" },
                    { "ef34c213-0787-4e3b-810e-182076379c0a", 0, "1f766904-a4ae-4d7d-ab69-493a7d073a33", "3824845856", "customer48@abv.bg", false, "Peter", "Murtin", false, null, "customer48@abv.bg", "customer48@abv.bg", "AQAAAAEAACcQAAAAEBov9hnthwsWrL2ccN+UWKaMiWvi6CFyF1TspXPVsvArHiIWIgES1U0NpvAyg18VXw==", null, false, "", false, "customer48@abv.bg" },
                    { "48d47ce3-cc7b-4520-9d46-5bdc5c46d3d7", 0, "c67be6cd-8875-4d85-bbae-6bc7fab53998", "2625331246", "customer47@abv.bg", false, "Kiro", "Gagov", false, null, "customer47@abv.bg", "customer47@abv.bg", "AQAAAAEAACcQAAAAEF04bvfAPkA/KuTnAg+sJHTJ6Gw94alDkOPAv/bYkrNwEVPTlDB3CgXyOQYMCbsMMA==", null, false, "", false, "customer47@abv.bg" },
                    { "f2c2626f-8030-4c4f-91d0-2f35249b649e", 0, "9e3d1d1e-b7b2-4e31-a0b9-f0f6f84a5527", "7728835717", "customer46@abv.bg", false, "Kiro", "Tsanov", false, null, "customer46@abv.bg", "customer46@abv.bg", "AQAAAAEAACcQAAAAEMvVyGlPJl6zpSHfYFZjMGJng5tPwDRiT7SN3tOdYu5zrwbwTbU0BFZk561cL+lNPA==", null, false, "", false, "customer46@abv.bg" },
                    { "ccb2af36-7067-4cdc-98ce-af507ad8e545", 0, "e13e0f10-b3cc-4482-8493-14f8a8ecb421", "7764782662", "customer18@abv.bg", false, "Kiro", "Syuleymezyan", false, null, "customer18@abv.bg", "customer18@abv.bg", "AQAAAAEAACcQAAAAEFE7tATYCnp1XftYr+7aFn8096VOwimaVVNaHRHo7T5AGQ9k5a1z/E/mK+Kt6mfYEw==", null, false, "", false, "customer18@abv.bg" },
                    { "92cf0ccc-1244-4e7c-a809-c5dd9d231976", 0, "eddbf994-c6e6-48e3-90d2-f26a109c5e6e", "6645670133", "customer17@abv.bg", false, "Nikolay", "Gagov", false, null, "customer17@abv.bg", "customer17@abv.bg", "AQAAAAEAACcQAAAAEE00NpkfuCpZ3TqZkSvrT0GnukPrTmYiiekRPq+N8lm3oSB3tkb3Nze+enhOmCoAQg==", null, false, "", false, "customer17@abv.bg" },
                    { "e674d9d2-856d-47e2-bd02-541eb743cf42", 0, "a690a4f2-d259-4577-9a89-f312848b313e", "1635718257", "customer16@abv.bg", false, "Nasko", "Murtin", false, null, "customer16@abv.bg", "customer16@abv.bg", "AQAAAAEAACcQAAAAEMK47LAyCATCPJVQQLGUtucDZIg3R0uFpGedxyblsUi/BFxrPDuw3vDHpmtGov4wRw==", null, false, "", false, "customer16@abv.bg" },
                    { "ffa13245-464d-4e14-a769-9b7c5477a52f", 0, "704d889a-54a4-41ef-b9b8-4233381c23d0", "3518246047", "customer15@abv.bg", false, "Kiro", "Gagov", false, null, "customer15@abv.bg", "customer15@abv.bg", "AQAAAAEAACcQAAAAEHlM+fjqIbzOUlHzbNo5QT5tkJOcyspRAyFSt/2FhcOBxU7wosWClRqE+JCYIv7WOA==", null, false, "", false, "customer15@abv.bg" },
                    { "27e34f32-34d0-4dee-8fb4-00622331b076", 0, "d5b809dc-ebf0-4f6e-9ad3-b3e299057ad1", "5121685872", "customer14@abv.bg", false, "Peter", "Tsanov", false, null, "customer14@abv.bg", "customer14@abv.bg", "AQAAAAEAACcQAAAAEETyeFlMxO1MYEdqzJ71In6kj+S8/fEPvcBQxtjfAIcgScN3pUtBq6hvOBlVe5JVSw==", null, false, "", false, "customer14@abv.bg" },
                    { "26cc4662-25c5-4e1f-ad9a-0c8e2efd61d2", 0, "8e6859f1-ce50-4ba9-ba9d-52c293672443", "8730611571", "customer13@abv.bg", false, "Kiro", "Syuleymezyan", false, null, "customer13@abv.bg", "customer13@abv.bg", "AQAAAAEAACcQAAAAEGElP93ol9Xg2FiCSLWCpKBWOWtNGeSZyFTBo2XwQGe/5ip1IyCM8N7sV969ZYWzYQ==", null, false, "", false, "customer13@abv.bg" },
                    { "38d59fc0-8091-4ca9-af25-a6473c95317c", 0, "e258d57f-20e3-48be-9895-dfa5de18ba8d", "1256803353", "customer12@abv.bg", false, "Nasko", "Murtin", false, null, "customer12@abv.bg", "customer12@abv.bg", "AQAAAAEAACcQAAAAEN3z+TN/IQf8WFkBS7Uz3+O/X79+rGvg3/iYWDenGCjDwsDvuFYbLGnEjvnyQcUDqA==", null, false, "", false, "customer12@abv.bg" },
                    { "6b411719-1618-4f85-b390-7088d6f68c18", 0, "0703fa06-bfa7-4b18-aa11-e16a28e199d0", "7173578318", "customer11@abv.bg", false, "Kiro", "Noto", false, null, "customer11@abv.bg", "customer11@abv.bg", "AQAAAAEAACcQAAAAEBX4m/dVUWvkSZbB/PqLoeUIw1z0sduXJ0dopvP3O5frXfZJp466fxTIW7+duHgSIg==", null, false, "", false, "customer11@abv.bg" },
                    { "3780b550-dbe0-4e69-bc96-667766c60061", 0, "3e7d0b4c-1b04-463c-bbed-5433342e035f", "2736364385", "customer10@abv.bg", false, "Nasko", "Noto", false, null, "customer10@abv.bg", "customer10@abv.bg", "AQAAAAEAACcQAAAAEHGmrSSbcmiw3VMj9iPOmQ9a9EqRzk8ErmapUdMnhFK63Q3s+oPyUTDy0zMjV5i0TA==", null, false, "", false, "customer10@abv.bg" },
                    { "8815eba1-07d1-4b6b-9b0f-71a1ed62468e", 0, "29028009-44d1-46de-8e72-e375e4777700", "0315441073", "customer9@abv.bg", false, "Peter", "Noto", false, null, "customer9@abv.bg", "customer9@abv.bg", "AQAAAAEAACcQAAAAEOQO+7YLyrZyp9Zf5J/ArZ3yPxIjI/zpnTxvO4aGtgRMP9KtlYekrJDqCt6iM+Os8g==", null, false, "", false, "customer9@abv.bg" },
                    { "4f4d1604-d81c-40f5-9506-33344b6b78a9", 0, "2a616467-f90c-4b3f-b43c-85f4c92f813c", "6621405583", "customer19@abv.bg", false, "Kiro", "Tsanov", false, null, "customer19@abv.bg", "customer19@abv.bg", "AQAAAAEAACcQAAAAEPjgS+AqiDljhw0sj2rKjt/oHTPu/o3k8/F7v9fEdEbITkMG9Cu2juUo/1B6335XDw==", null, false, "", false, "customer19@abv.bg" },
                    { "3c6f3aeb-d661-4c94-a61f-3c4e632eac61", 0, "46bf37c0-22c9-4db5-b9cb-2390f5015998", "7362218152", "customer8@abv.bg", false, "Nikolay", "Murtin", false, null, "customer8@abv.bg", "customer8@abv.bg", "AQAAAAEAACcQAAAAENgFQs/TCYX8OGt834mW2Bkal/c2hVEGdYWHr5qAWP6LpBz1m9ZogiGZAzBcwSSzpg==", null, false, "", false, "customer8@abv.bg" },
                    { "172603a8-4894-4b4f-bb2c-180ad9aea623", 0, "14850118-b7ec-444e-b216-568cfce13c14", "2155077331", "customer6@abv.bg", false, "Nikolay", "Gagov", false, null, "customer6@abv.bg", "customer6@abv.bg", "AQAAAAEAACcQAAAAEFOYpaSsxKWbBEn39KcUCbc12j6cCydakehK2seG8e9csetjUOb1MKPLYhwKzIigUA==", null, false, "", false, "customer6@abv.bg" },
                    { "4296910d-c529-422c-af2e-1635b95be87a", 0, "5c7cab88-4d7b-4828-bfdd-efeac2d3bc49", "7261110703", "customer5@abv.bg", false, "Nikolay", "Noto", false, null, "customer5@abv.bg", "customer5@abv.bg", "AQAAAAEAACcQAAAAEHB5ymJxtC3zhW09qYVL/629T+fWM9UmhF8Y/EclDGbk58XIZ51KpDgdRfzQrJE2Pw==", null, false, "", false, "customer5@abv.bg" },
                    { "77d6a78d-bc61-474b-8dc0-4f4e072730a8", 0, "f50dffff-82be-43ff-bf1b-ef830deb4952", "1311621022", "customer4@abv.bg", false, "Nikolay", "Syuleymezyan", false, null, "customer4@abv.bg", "customer4@abv.bg", "AQAAAAEAACcQAAAAEFDP4QXcTK7iqXtTA0iUk3RDG8HijBTL6ma8sPOCcTqP9fJcmBdq2Z2tj3QJsqRi4w==", null, false, "", false, "customer4@abv.bg" },
                    { "c97c4f4c-42b8-42b7-89c7-72012d63d802", 0, "cd645120-8932-49d1-ab1a-1604bd6cb429", "6263351476", "customer3@abv.bg", false, "Peter", "Noto", false, null, "customer3@abv.bg", "customer3@abv.bg", "AQAAAAEAACcQAAAAECQS3sQHsUY62iQcRUP+yXeeD1lut+u3rBGmnSOPMgE3RHmwqjkQlw+hyIEAltTl7w==", null, false, "", false, "customer3@abv.bg" },
                    { "3d2d85e1-b01f-4741-bd14-2d6c24c24705", 0, "2f9e3906-ad70-4bd9-aead-4895612b79c4", "1204065414", "customer2@abv.bg", false, "Nikolay", "Noto", false, null, "customer2@abv.bg", "customer2@abv.bg", "AQAAAAEAACcQAAAAEF/kqg1wv/rezI1WeTE1J22T35ICPoQaomRe9ndneRByNkicRoKlPArTnyUGH6iUuw==", null, false, "", false, "customer2@abv.bg" },
                    { "9b75315c-bdbb-408a-ba8b-a18f647b991b", 0, "cd247785-ed4b-4f76-9395-8e6c60c64664", "0244808003", "customer1@abv.bg", false, "Kiro", "Syuleymezyan", false, null, "customer1@abv.bg", "customer1@abv.bg", "AQAAAAEAACcQAAAAEMQhc8XWEitWPR5QKWp6mV09rPL8t+c/cFr2llCtkVzlDiwf5gQmXOgWRFy9daRaqQ==", null, false, "", false, "customer1@abv.bg" },
                    { "e457f38b-cc94-4e8c-a6d5-beb0aeb90130", 0, "bcbf6f1e-9ae2-4fb3-9ab3-27e928b81873", "7634104880", "customer0@abv.bg", false, "Kiro", "Syuleymezyan", false, null, "customer0@abv.bg", "customer0@abv.bg", "AQAAAAEAACcQAAAAEPf93gjq3ON86wMFXq/0XeaZm8Ntuloh9XrdgdBQjUE11ae83Rnr6soF8t8rjqZXqQ==", null, false, "", false, "customer0@abv.bg" },
                    { "52ed4cc0-f4f5-4c20-a555-f09f0651d346", 0, "a5a5162e-1daa-4a42-b51a-50e973dc5868", "4666507172", "syuleymezyan@abv.bg", false, "Kiro", "Gagov", false, null, "syuleymezyan@abv.bg", "syuleymezyan@abv.bg", "AQAAAAEAACcQAAAAEBl5uTBSt3FTzHjotCyNqq1SAOQ/OFd8IFdlYH2qYUDRSLjJSG5GEnIVOfF4vhZswQ==", null, false, "", false, "syuleymezyan@abv.bg" },
                    { "0bff1bb0-d05d-40e4-b55b-00dfc54efcea", 0, "fed659ee-f140-4275-a1f3-ac11b7c9ed7f", "0437885680", "murtin@abv.bg", false, "Peter", "Tsanov", false, null, "murtin@abv.bg", "murtin@abv.bg", "AQAAAAEAACcQAAAAEBFmECxPS0IrUHVogARQ9brFWqnhZvXFFdrweN65z0KHyTqIkFGB1s87E+R+H0dm5w==", null, false, "", false, "murtin@abv.bg" },
                    { "0f547efe-a0d4-4b0a-b1a0-81bbc4c341f9", 0, "bf8c83ad-1fae-41a4-836b-7dc4e696e88e", "0680452651", "gagov@abv.bg", false, "Kiro", "Syuleymezyan", false, null, "gagov@abv.bg", "gagov@abv.bg", "AQAAAAEAACcQAAAAENwamTjf6jNSfVyWH8xq8Up8WtuPPcICzthMwyyXWofq9kL46Kqv1QvZAvzyoHQwzg==", null, false, "", false, "gagov@abv.bg" },
                    { "4997d6e7-15ff-4bdf-a680-bff5d9b873da", 0, "110b1e6d-137b-4487-8a7f-60e0a35fa1fd", "8756558817", "customer7@abv.bg", false, "Nasko", "Murtin", false, null, "customer7@abv.bg", "customer7@abv.bg", "AQAAAAEAACcQAAAAELWjyJW+EF+cBLVIkLMDjAz6UfEj9YUK2vXMUBXlJKOx4UnLJ9durYU21FQ23ODwVw==", null, false, "", false, "customer7@abv.bg" },
                    { "4cf9630b-561e-4431-9e41-44d82ebe78e4", 0, "c197b15d-df0d-4839-9b4f-70428547b5bf", "4603004181", "customer20@abv.bg", false, "Peter", "Noto", false, null, "customer20@abv.bg", "customer20@abv.bg", "AQAAAAEAACcQAAAAEOqC70E2+LzGtqv7uhywpgnhMM4X0bhB2tkNTSQnL3qe8UpAEeWub1Py8lHuq+YHjA==", null, false, "", false, "customer20@abv.bg" },
                    { "f2907d24-32c0-4f5f-a312-b8cc9295f729", 0, "b56e7538-5586-4936-b959-2c1045676bcd", "1300637200", "customer21@abv.bg", false, "Nasko", "Syuleymezyan", false, null, "customer21@abv.bg", "customer21@abv.bg", "AQAAAAEAACcQAAAAEGxz0d7JUygGd8g2i5Y9xm4MYKZZkXHz4J/frXsCJvZ6x9fCHacQXMEi462yD7gWnw==", null, false, "", false, "customer21@abv.bg" },
                    { "b4bc6143-ae51-424b-983f-b64c302a311c", 0, "8c87db07-618d-4a5e-aa6a-283b2f1aee73", "2642477227", "customer22@abv.bg", false, "Nikolay", "Noto", false, null, "customer22@abv.bg", "customer22@abv.bg", "AQAAAAEAACcQAAAAEMjizAN5liF/zaeqeZ69bawTzLVQjbSgW9GGFplpVsQpGF1T9IiIkpTWlogrDQrCVA==", null, false, "", false, "customer22@abv.bg" },
                    { "c9f575af-03a3-4d0c-8982-97051cd9bf45", 0, "ccedc8a1-e50a-4f33-9901-6be8448a59d3", "2316051074", "customer45@abv.bg", false, "Nasko", "Gagov", false, null, "customer45@abv.bg", "customer45@abv.bg", "AQAAAAEAACcQAAAAEC/eQh5Ko2l+jh3f47ajdD69qDXjLRpei5m6foc0wYprh9meYAhMCNeoF6n2//kYuA==", null, false, "", false, "customer45@abv.bg" },
                    { "b576058c-df43-49bd-bedb-2655f35fc360", 0, "46eff988-5da6-42dc-a74b-3fdfe4521a66", "2168347221", "customer44@abv.bg", false, "Nasko", "Noto", false, null, "customer44@abv.bg", "customer44@abv.bg", "AQAAAAEAACcQAAAAEP+0cCpnx5OVSNKljfZ0S+Y/otXNrGOr3Fv+JLW01Hhi7v4GLlEgchkYpxV2aS3zZQ==", null, false, "", false, "customer44@abv.bg" },
                    { "7ad1fd7b-9948-4bec-9dfd-4c4c0ba402b9", 0, "2462365f-71e8-4064-ba3f-4349566aa8b4", "7164074175", "customer43@abv.bg", false, "Kiro", "Tsanov", false, null, "customer43@abv.bg", "customer43@abv.bg", "AQAAAAEAACcQAAAAEHlh5mx4Eq2hyqPlAHUs1WlqLm624tKme/4+/HkXAwSAxwqC4cppKWWvpF8WMsi+wg==", null, false, "", false, "customer43@abv.bg" },
                    { "2c7531be-4f8d-4d31-9045-12d23fefc3a2", 0, "edfcb69f-df68-433c-80dd-f6ff0fce88b8", "4616803040", "customer42@abv.bg", false, "Kiro", "Syuleymezyan", false, null, "customer42@abv.bg", "customer42@abv.bg", "AQAAAAEAACcQAAAAEDKvM4trhKpdzY9YjxE7bpCg/SIjURAhaWoqx/AVNS+EqMWzH+DybSsWUpGvJ8Ck2Q==", null, false, "", false, "customer42@abv.bg" },
                    { "b9e862a8-a9d0-45bf-b322-b82f859ddd0b", 0, "4c23eae1-b150-4873-8b94-af377d3e3f0b", "3041573805", "customer41@abv.bg", false, "Peter", "Gagov", false, null, "customer41@abv.bg", "customer41@abv.bg", "AQAAAAEAACcQAAAAEJAjpa+bM3SjydGCURhvPApICYl2rqdbKM7NTbpiklgPxkqnXPijefGDWMwycB47CA==", null, false, "", false, "customer41@abv.bg" },
                    { "492b38d8-391d-46e8-9046-e6a5b0ec3817", 0, "3a863812-03c4-4e14-beb7-c53856c8bcef", "6474366467", "customer40@abv.bg", false, "Nasko", "Gagov", false, null, "customer40@abv.bg", "customer40@abv.bg", "AQAAAAEAACcQAAAAEPb6xRHpfu7U9axnYlJdgRbITtQ9mCvpLkmbwEFf1MhXbNigTZiLIskseGu9i/RCMA==", null, false, "", false, "customer40@abv.bg" },
                    { "1184324f-49cf-4efd-934e-23dcde3aaaba", 0, "f54cf897-214d-4954-9402-40c4109d86fe", "7276410251", "customer39@abv.bg", false, "Nikolay", "Tsanov", false, null, "customer39@abv.bg", "customer39@abv.bg", "AQAAAAEAACcQAAAAEDECYe8TIEiREj34WzZLRIccO+Btl1GKvZ5qJz5/+craZc1oCTM9NC6kzL/UURDwUw==", null, false, "", false, "customer39@abv.bg" },
                    { "0e7aa368-6fa8-462d-965d-b460e83ccbef", 0, "f862774a-56e4-46da-96a8-f6aae0b9cf71", "5556041446", "customer38@abv.bg", false, "Nasko", "Gagov", false, null, "customer38@abv.bg", "customer38@abv.bg", "AQAAAAEAACcQAAAAEPS0H2kIIoKXjYtEdx/+RXsVOzZh42/P6u4F9AepKKZqLrGgOjsBLJ3sVLaUeRgF1A==", null, false, "", false, "customer38@abv.bg" },
                    { "3ea03449-6b09-419d-9996-956b80edaba4", 0, "5114fbbb-b8bb-49cb-92d3-9d8d4b46ebca", "6728683282", "customer37@abv.bg", false, "Nikolay", "Tsanov", false, null, "customer37@abv.bg", "customer37@abv.bg", "AQAAAAEAACcQAAAAEEXmstTn0++p2cr6SVpWkLelQFwwLvl9F9L4zunJrkYyx/nMxox5x18jwP1m+2LamA==", null, false, "", false, "customer37@abv.bg" },
                    { "c9652ff0-8337-4582-b349-cc64d3e966da", 0, "bfdf488e-aa84-4725-9dd1-cd170802769b", "2457700611", "customer36@abv.bg", false, "Nasko", "Syuleymezyan", false, null, "customer36@abv.bg", "customer36@abv.bg", "AQAAAAEAACcQAAAAEHw5ZYVDUnvOVFl6m6rbMm56Gcgl4IRaD118ZWi7IFHvwq38dEIf5GVnAMQRl1oXQw==", null, false, "", false, "customer36@abv.bg" },
                    { "032351ba-de9a-4fdf-a9d2-60d3ee699a85", 0, "2cb5e373-428c-4653-a8d5-f424f9565791", "7217567485", "customer35@abv.bg", false, "Nikolay", "Syuleymezyan", false, null, "customer35@abv.bg", "customer35@abv.bg", "AQAAAAEAACcQAAAAEL8MEHJI+TNVzWWW2io3g/O2OaxFdxKz8+kn+VpbovQo0o47EBC64muiphYMELsWMw==", null, false, "", false, "customer35@abv.bg" },
                    { "5242648f-4336-48a6-bcf0-94714ffef3ee", 0, "0303583c-23fe-4f07-850d-ab45f5825a9e", "2161652443", "customer34@abv.bg", false, "Nikolay", "Noto", false, null, "customer34@abv.bg", "customer34@abv.bg", "AQAAAAEAACcQAAAAEK8biiFy6S+xwx2v2LzqPytrnoXkmWhjijOPJanfXDbur8EJPDLjpejlvES/+avUQQ==", null, false, "", false, "customer34@abv.bg" },
                    { "b09abb2a-8468-4e81-8c19-f9aab7c0d4dc", 0, "c7fb48a0-ba27-454f-881f-a2de3063368e", "7413305740", "customer33@abv.bg", false, "Kiro", "Murtin", false, null, "customer33@abv.bg", "customer33@abv.bg", "AQAAAAEAACcQAAAAEFgqNeD58KKI6xZ+pcujBtBPMAjCA7M71w5k6s3ADTUlWxvBkzCjFN63b1FnBU/oqw==", null, false, "", false, "customer33@abv.bg" },
                    { "07b568f0-31e5-416b-a6c9-ae4c85511746", 0, "3665e5b0-78d9-4bf3-905c-025d0ccbf98d", "8003437788", "customer32@abv.bg", false, "Nikolay", "Murtin", false, null, "customer32@abv.bg", "customer32@abv.bg", "AQAAAAEAACcQAAAAEDcZAIWJKh9Lun/d0Ppc5MrLID0pjJWvcl0WqJbIz4t6kR0+1K8EhVeGG4VSimoIFQ==", null, false, "", false, "customer32@abv.bg" },
                    { "f8b4e412-7812-4abf-b5f8-ef19fb66e642", 0, "e00f73f7-71df-40d7-acb7-dda07d264db0", "1365606103", "customer31@abv.bg", false, "Peter", "Noto", false, null, "customer31@abv.bg", "customer31@abv.bg", "AQAAAAEAACcQAAAAEAjKPimeSRMUjtp8cEz6kLiKROCAz81MQYC1gUQAyFJ0BRd/Ve4KKsC6MiWvDVpqjw==", null, false, "", false, "customer31@abv.bg" },
                    { "6f75975c-fbca-4cf6-9874-5d8f56b1fbfe", 0, "e8198ea5-4c53-4b3c-a031-7ceca0b3c820", "5047506338", "customer30@abv.bg", false, "Nikolay", "Syuleymezyan", false, null, "customer30@abv.bg", "customer30@abv.bg", "AQAAAAEAACcQAAAAEPeeOHoMggEVzIzel3b+tScN9IrKqE6fxXTYQgqc/bfi2y79BHwMmNU3JVFOdrZ5lA==", null, false, "", false, "customer30@abv.bg" },
                    { "0c6ac627-96f4-4727-99fc-a174cb8afd04", 0, "019d447a-0da5-407e-824f-913b1651502a", "1357035701", "customer29@abv.bg", false, "Kiro", "Syuleymezyan", false, null, "customer29@abv.bg", "customer29@abv.bg", "AQAAAAEAACcQAAAAECIJhfQ1PxaO15OUE+Zst5K3XsJIW5Rk+wDJzbLRVgSbotNmbNk0n254sNt1RdyuJg==", null, false, "", false, "customer29@abv.bg" },
                    { "4fccd97f-8fe4-48c3-aa37-f29f483be228", 0, "17912788-b1f5-4bc6-a734-3a38dc37fbd4", "4188848457", "customer28@abv.bg", false, "Nasko", "Tsanov", false, null, "customer28@abv.bg", "customer28@abv.bg", "AQAAAAEAACcQAAAAEIM0RbH1dvTz797ch1AhZ31iRvVcKx/kKZA+cKzRKFw80tst5HOPgm3soxqx9I6jjw==", null, false, "", false, "customer28@abv.bg" },
                    { "68a78eb5-8082-488a-b765-92da166f13ae", 0, "bd1bacac-5fa8-4bcf-9b1c-e2d79c44c8be", "2686457827", "customer27@abv.bg", false, "Nasko", "Gagov", false, null, "customer27@abv.bg", "customer27@abv.bg", "AQAAAAEAACcQAAAAEJiv0dpNB+MKLr7kkVOrKTpzHKjfRgtgz6D4Bv4KBcOdNimACurHq28mIvWfgIvhwA==", null, false, "", false, "customer27@abv.bg" },
                    { "1059d819-9348-43f7-9c04-4ddca00fd827", 0, "a60e418f-c0ad-424c-9682-abf2ee529da6", "7711246421", "customer26@abv.bg", false, "Peter", "Gagov", false, null, "customer26@abv.bg", "customer26@abv.bg", "AQAAAAEAACcQAAAAEE507i/NDcJkiYb00tMYyHd/ZNN+kQz+Okpt4WFd3kgJrUL3P66sGwgvdzYEvNdV6Q==", null, false, "", false, "customer26@abv.bg" },
                    { "6bc7cd4a-bbdd-405b-b75d-3b7d3ebac122", 0, "1a431242-6760-4659-9343-9ddfad28ccd4", "2000517052", "customer25@abv.bg", false, "Peter", "Murtin", false, null, "customer25@abv.bg", "customer25@abv.bg", "AQAAAAEAACcQAAAAEBnZ9ugK1ZVWHTKxDnp+ViJeRZS7jUn+PETLJi21xgxGzcX1qeX5iSaTMB5Ptdd+QQ==", null, false, "", false, "customer25@abv.bg" },
                    { "126124f1-fab0-4585-b186-a87a7bd9e138", 0, "7f61d8fc-8f98-47f3-9c4b-5fa1712d449d", "3814281482", "customer24@abv.bg", false, "Peter", "Murtin", false, null, "customer24@abv.bg", "customer24@abv.bg", "AQAAAAEAACcQAAAAEHBsaXptmJqkKoI+vjapJrGfzYLI0LFGLh9FswC426U+eaUou0qP2SvDiHkQk15XWQ==", null, false, "", false, "customer24@abv.bg" },
                    { "7f765c1c-8f0b-41f3-a901-abc13fb00faf", 0, "4616770e-e591-4b0a-b568-81dc2eb7f369", "6504067883", "customer23@abv.bg", false, "Nasko", "Syuleymezyan", false, null, "customer23@abv.bg", "customer23@abv.bg", "AQAAAAEAACcQAAAAEPNbXRHbuF7XVGkFybID/OzUN9wxCQDSkFIXEOM7c7iHFbmgbqfrLnFvbAAnIRs03A==", null, false, "", false, "customer23@abv.bg" },
                    { "af73d8ae-cadb-4087-9f27-581bbb632b30", 0, "9c695441-05d8-48c4-ad84-404e960ed68c", "3706130531", "customer98@abv.bg", false, "Peter", "Murtin", false, null, "customer98@abv.bg", "customer98@abv.bg", "AQAAAAEAACcQAAAAEJQbsR83L4dhSj1aC5RHI2Jzh7AG1R9jPkM6s+MCg/Hi0vrszOGrHHxYTQyxzkjMYQ==", null, false, "", false, "customer98@abv.bg" },
                    { "836f34ba-7617-488e-ac9c-6e4112d95257", 0, "3557a808-3aeb-40b2-a492-b37b989d8c3e", "1717670028", "customer99@abv.bg", false, "Peter", "Noto", false, null, "customer99@abv.bg", "customer99@abv.bg", "AQAAAAEAACcQAAAAEHJ6q2DsPfPhsFj2Y+9CZpdC0WHBmEqpghozMNXUftzqFotHRXUFpAWglnH6Y9ZlGg==", null, false, "", false, "customer99@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "0f547efe-a0d4-4b0a-b1a0-81bbc4c341f9", "437c8867-bda0-4f88-8daa-33cd48d580f1" },
                    { "ceebe0c9-0006-4d49-96ee-6a4bc7d494e2", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "eeaf5491-182e-45ac-a6d5-d09c1678529f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "81da9f5d-7815-4f87-86b1-db210e79932f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "1884c97f-0175-4b05-8efa-8044be01a002", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "0d0771c9-f606-41bf-b89d-9a6c4684b19d", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "be12392a-c32a-4dc7-81e1-d9dc32e9e5f3", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "823710b1-0d4a-4765-bae6-52ae4412c2cf", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "1b5a1aef-0ce7-44e7-af16-bdb50275f88f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "18492512-bba5-42e7-9a15-34e6599091d0", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "cfaef36c-0b61-4c07-9b55-1faf4dee7c4a", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "967ba096-4682-4594-8e0d-67049cad525f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "2e1cc6a8-84af-4def-86de-fd89761f77d3", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "81bae5fe-107b-45cc-b763-060db486419b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "f32cc995-0928-4cb7-828f-edd1b2c9a9a4", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "9da155c1-e223-41dd-889d-b5d9d2c85cbd", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "04f47b43-cb60-44e0-bda7-0a69e1074b87", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "e1a27e3b-fc05-4d77-bf7b-2031de220852", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "c26d3bd6-e239-40bd-a60d-b9786a6a614b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "7869b58e-2540-4180-814a-005c46ed5243", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "432cc6d9-5ffa-44c4-83f1-72e3e712c343", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "08042f0a-56ff-4a40-89ee-c82e966a9390", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "b68b6c1f-8e48-444a-9487-8f3303ae7a51", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "0b4dfef9-e127-4684-9f38-e241742a4591", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "143c4fb7-15d9-4a22-b810-90b7a0874e86", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "85f2f828-39a0-4ad8-9730-93c670901404", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "35363f8f-3841-49d4-b734-fc68416238ae", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "6c7ec71c-15de-47b9-82ea-7fa90c4cdeb3", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "1215e32b-6168-4ae9-97e9-2a23d255a83f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "656b9c5f-3e45-4dc2-ba59-f4308ded43f5", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "c4d45f8d-fdf0-41b7-8778-2286dd502932", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "6daaa969-13e1-42c0-82f5-98c03057ebfb", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "25896b1b-2dcf-4de2-b53b-8ba298b3a71c", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "6a980e2c-f534-4a5d-bd24-c09a19b73383", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "617a02c6-b4cc-4593-96eb-4f6b32d7fcd5", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "0e1abe7d-2a90-494e-9226-b7820608fc49", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "76295d2c-4881-4d8f-a33d-61353826102b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "48247e9f-7d55-44bc-ac49-f317a0db4c0b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "d01144d1-0a29-4a54-af8e-1eb84df4b41d", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "bfc8fbec-d764-465d-ab85-9e800838bfce", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "d5031b00-849b-47c5-a868-8b614e530935", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "74fa61e5-610a-4fc9-8d4e-69105e04fa72", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "3f3acbe4-a7e4-4b82-b70f-044e22cd767f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "c379e547-f047-4944-a6f6-aac480820cf4", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "ec945073-e5bf-48cd-bc86-27baa5496016", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "4f9a38ed-0275-41e3-a337-282a09f5a280", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "9b00963d-34d5-46c3-bda7-5ddc274dbcff", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "9d1d4b96-a43b-4606-b1f1-1357a664d69f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "6bc9cd5c-9cf4-4ad4-9dd2-ec0e03756d6c", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "c74ce8ed-98a9-4968-929e-a95bcaea619f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "af73d8ae-cadb-4087-9f27-581bbb632b30", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "ef34c213-0787-4e3b-810e-182076379c0a", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "f2c2626f-8030-4c4f-91d0-2f35249b649e", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "4f4d1604-d81c-40f5-9506-33344b6b78a9", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "ccb2af36-7067-4cdc-98ce-af507ad8e545", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "92cf0ccc-1244-4e7c-a809-c5dd9d231976", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "e674d9d2-856d-47e2-bd02-541eb743cf42", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "ffa13245-464d-4e14-a769-9b7c5477a52f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "27e34f32-34d0-4dee-8fb4-00622331b076", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "26cc4662-25c5-4e1f-ad9a-0c8e2efd61d2", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "38d59fc0-8091-4ca9-af25-a6473c95317c", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "6b411719-1618-4f85-b390-7088d6f68c18", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "3780b550-dbe0-4e69-bc96-667766c60061", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "4cf9630b-561e-4431-9e41-44d82ebe78e4", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "8815eba1-07d1-4b6b-9b0f-71a1ed62468e", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "4997d6e7-15ff-4bdf-a680-bff5d9b873da", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "172603a8-4894-4b4f-bb2c-180ad9aea623", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "4296910d-c529-422c-af2e-1635b95be87a", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "77d6a78d-bc61-474b-8dc0-4f4e072730a8", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "c97c4f4c-42b8-42b7-89c7-72012d63d802", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "3d2d85e1-b01f-4741-bd14-2d6c24c24705", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "9b75315c-bdbb-408a-ba8b-a18f647b991b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "e457f38b-cc94-4e8c-a6d5-beb0aeb90130", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "52ed4cc0-f4f5-4c20-a555-f09f0651d346", "437c8867-bda0-4f88-8daa-33cd48d580f1" },
                    { "0bff1bb0-d05d-40e4-b55b-00dfc54efcea", "437c8867-bda0-4f88-8daa-33cd48d580f1" },
                    { "3c6f3aeb-d661-4c94-a61f-3c4e632eac61", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "48d47ce3-cc7b-4520-9d46-5bdc5c46d3d7", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "f2907d24-32c0-4f5f-a312-b8cc9295f729", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "7f765c1c-8f0b-41f3-a901-abc13fb00faf", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "c9f575af-03a3-4d0c-8982-97051cd9bf45", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "b576058c-df43-49bd-bedb-2655f35fc360", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "7ad1fd7b-9948-4bec-9dfd-4c4c0ba402b9", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "2c7531be-4f8d-4d31-9045-12d23fefc3a2", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "b9e862a8-a9d0-45bf-b322-b82f859ddd0b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "492b38d8-391d-46e8-9046-e6a5b0ec3817", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "1184324f-49cf-4efd-934e-23dcde3aaaba", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "0e7aa368-6fa8-462d-965d-b460e83ccbef", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "3ea03449-6b09-419d-9996-956b80edaba4", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "c9652ff0-8337-4582-b349-cc64d3e966da", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "b4bc6143-ae51-424b-983f-b64c302a311c", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "032351ba-de9a-4fdf-a9d2-60d3ee699a85", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "b09abb2a-8468-4e81-8c19-f9aab7c0d4dc", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "07b568f0-31e5-416b-a6c9-ae4c85511746", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "f8b4e412-7812-4abf-b5f8-ef19fb66e642", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "6f75975c-fbca-4cf6-9874-5d8f56b1fbfe", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "0c6ac627-96f4-4727-99fc-a174cb8afd04", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "4fccd97f-8fe4-48c3-aa37-f29f483be228", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "68a78eb5-8082-488a-b765-92da166f13ae", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "1059d819-9348-43f7-9c04-4ddca00fd827", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "6bc7cd4a-bbdd-405b-b75d-3b7d3ebac122", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "126124f1-fab0-4585-b186-a87a7bd9e138", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "5242648f-4336-48a6-bcf0-94714ffef3ee", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" },
                    { "836f34ba-7617-488e-ac9c-6e4112d95257", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "032351ba-de9a-4fdf-a9d2-60d3ee699a85", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "04f47b43-cb60-44e0-bda7-0a69e1074b87", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "07b568f0-31e5-416b-a6c9-ae4c85511746", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "08042f0a-56ff-4a40-89ee-c82e966a9390", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0b4dfef9-e127-4684-9f38-e241742a4591", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0bff1bb0-d05d-40e4-b55b-00dfc54efcea", "437c8867-bda0-4f88-8daa-33cd48d580f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0c6ac627-96f4-4727-99fc-a174cb8afd04", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0d0771c9-f606-41bf-b89d-9a6c4684b19d", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0e1abe7d-2a90-494e-9226-b7820608fc49", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0e7aa368-6fa8-462d-965d-b460e83ccbef", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0f547efe-a0d4-4b0a-b1a0-81bbc4c341f9", "437c8867-bda0-4f88-8daa-33cd48d580f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1059d819-9348-43f7-9c04-4ddca00fd827", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1184324f-49cf-4efd-934e-23dcde3aaaba", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1215e32b-6168-4ae9-97e9-2a23d255a83f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "126124f1-fab0-4585-b186-a87a7bd9e138", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "143c4fb7-15d9-4a22-b810-90b7a0874e86", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "172603a8-4894-4b4f-bb2c-180ad9aea623", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "18492512-bba5-42e7-9a15-34e6599091d0", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1884c97f-0175-4b05-8efa-8044be01a002", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1b5a1aef-0ce7-44e7-af16-bdb50275f88f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "25896b1b-2dcf-4de2-b53b-8ba298b3a71c", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "26cc4662-25c5-4e1f-ad9a-0c8e2efd61d2", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "27e34f32-34d0-4dee-8fb4-00622331b076", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2c7531be-4f8d-4d31-9045-12d23fefc3a2", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2e1cc6a8-84af-4def-86de-fd89761f77d3", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "35363f8f-3841-49d4-b734-fc68416238ae", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3780b550-dbe0-4e69-bc96-667766c60061", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "38d59fc0-8091-4ca9-af25-a6473c95317c", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3c6f3aeb-d661-4c94-a61f-3c4e632eac61", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3d2d85e1-b01f-4741-bd14-2d6c24c24705", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3ea03449-6b09-419d-9996-956b80edaba4", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3f3acbe4-a7e4-4b82-b70f-044e22cd767f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4296910d-c529-422c-af2e-1635b95be87a", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "432cc6d9-5ffa-44c4-83f1-72e3e712c343", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "48247e9f-7d55-44bc-ac49-f317a0db4c0b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "48d47ce3-cc7b-4520-9d46-5bdc5c46d3d7", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "492b38d8-391d-46e8-9046-e6a5b0ec3817", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4997d6e7-15ff-4bdf-a680-bff5d9b873da", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4cf9630b-561e-4431-9e41-44d82ebe78e4", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4f4d1604-d81c-40f5-9506-33344b6b78a9", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4f9a38ed-0275-41e3-a337-282a09f5a280", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4fccd97f-8fe4-48c3-aa37-f29f483be228", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5242648f-4336-48a6-bcf0-94714ffef3ee", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "52ed4cc0-f4f5-4c20-a555-f09f0651d346", "437c8867-bda0-4f88-8daa-33cd48d580f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "617a02c6-b4cc-4593-96eb-4f6b32d7fcd5", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "656b9c5f-3e45-4dc2-ba59-f4308ded43f5", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "68a78eb5-8082-488a-b765-92da166f13ae", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6a980e2c-f534-4a5d-bd24-c09a19b73383", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6b411719-1618-4f85-b390-7088d6f68c18", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6bc7cd4a-bbdd-405b-b75d-3b7d3ebac122", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6bc9cd5c-9cf4-4ad4-9dd2-ec0e03756d6c", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6c7ec71c-15de-47b9-82ea-7fa90c4cdeb3", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6daaa969-13e1-42c0-82f5-98c03057ebfb", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6f75975c-fbca-4cf6-9874-5d8f56b1fbfe", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "74fa61e5-610a-4fc9-8d4e-69105e04fa72", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "76295d2c-4881-4d8f-a33d-61353826102b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "77d6a78d-bc61-474b-8dc0-4f4e072730a8", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7869b58e-2540-4180-814a-005c46ed5243", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7ad1fd7b-9948-4bec-9dfd-4c4c0ba402b9", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7f765c1c-8f0b-41f3-a901-abc13fb00faf", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "81bae5fe-107b-45cc-b763-060db486419b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "81da9f5d-7815-4f87-86b1-db210e79932f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "823710b1-0d4a-4765-bae6-52ae4412c2cf", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "836f34ba-7617-488e-ac9c-6e4112d95257", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "85f2f828-39a0-4ad8-9730-93c670901404", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8815eba1-07d1-4b6b-9b0f-71a1ed62468e", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "92cf0ccc-1244-4e7c-a809-c5dd9d231976", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "967ba096-4682-4594-8e0d-67049cad525f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9b00963d-34d5-46c3-bda7-5ddc274dbcff", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9b75315c-bdbb-408a-ba8b-a18f647b991b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9d1d4b96-a43b-4606-b1f1-1357a664d69f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9da155c1-e223-41dd-889d-b5d9d2c85cbd", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "af73d8ae-cadb-4087-9f27-581bbb632b30", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b09abb2a-8468-4e81-8c19-f9aab7c0d4dc", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b4bc6143-ae51-424b-983f-b64c302a311c", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b576058c-df43-49bd-bedb-2655f35fc360", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b68b6c1f-8e48-444a-9487-8f3303ae7a51", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b9e862a8-a9d0-45bf-b322-b82f859ddd0b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "be12392a-c32a-4dc7-81e1-d9dc32e9e5f3", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bfc8fbec-d764-465d-ab85-9e800838bfce", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c26d3bd6-e239-40bd-a60d-b9786a6a614b", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c379e547-f047-4944-a6f6-aac480820cf4", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c4d45f8d-fdf0-41b7-8778-2286dd502932", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c74ce8ed-98a9-4968-929e-a95bcaea619f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c9652ff0-8337-4582-b349-cc64d3e966da", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c97c4f4c-42b8-42b7-89c7-72012d63d802", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c9f575af-03a3-4d0c-8982-97051cd9bf45", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ccb2af36-7067-4cdc-98ce-af507ad8e545", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ceebe0c9-0006-4d49-96ee-6a4bc7d494e2", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cfaef36c-0b61-4c07-9b55-1faf4dee7c4a", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d01144d1-0a29-4a54-af8e-1eb84df4b41d", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d5031b00-849b-47c5-a868-8b614e530935", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e1a27e3b-fc05-4d77-bf7b-2031de220852", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e457f38b-cc94-4e8c-a6d5-beb0aeb90130", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e674d9d2-856d-47e2-bd02-541eb743cf42", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ec945073-e5bf-48cd-bc86-27baa5496016", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "eeaf5491-182e-45ac-a6d5-d09c1678529f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ef34c213-0787-4e3b-810e-182076379c0a", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f2907d24-32c0-4f5f-a312-b8cc9295f729", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f2c2626f-8030-4c4f-91d0-2f35249b649e", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f32cc995-0928-4cb7-828f-edd1b2c9a9a4", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f8b4e412-7812-4abf-b5f8-ef19fb66e642", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ffa13245-464d-4e14-a769-9b7c5477a52f", "d0c581b9-32e9-4aef-935c-411bc7d69ff3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "437c8867-bda0-4f88-8daa-33cd48d580f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0c581b9-32e9-4aef-935c-411bc7d69ff3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "032351ba-de9a-4fdf-a9d2-60d3ee699a85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04f47b43-cb60-44e0-bda7-0a69e1074b87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07b568f0-31e5-416b-a6c9-ae4c85511746");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08042f0a-56ff-4a40-89ee-c82e966a9390");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b4dfef9-e127-4684-9f38-e241742a4591");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bff1bb0-d05d-40e4-b55b-00dfc54efcea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c6ac627-96f4-4727-99fc-a174cb8afd04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d0771c9-f606-41bf-b89d-9a6c4684b19d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1abe7d-2a90-494e-9226-b7820608fc49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e7aa368-6fa8-462d-965d-b460e83ccbef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f547efe-a0d4-4b0a-b1a0-81bbc4c341f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1059d819-9348-43f7-9c04-4ddca00fd827");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1184324f-49cf-4efd-934e-23dcde3aaaba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1215e32b-6168-4ae9-97e9-2a23d255a83f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126124f1-fab0-4585-b186-a87a7bd9e138");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143c4fb7-15d9-4a22-b810-90b7a0874e86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "172603a8-4894-4b4f-bb2c-180ad9aea623");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18492512-bba5-42e7-9a15-34e6599091d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1884c97f-0175-4b05-8efa-8044be01a002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b5a1aef-0ce7-44e7-af16-bdb50275f88f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25896b1b-2dcf-4de2-b53b-8ba298b3a71c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26cc4662-25c5-4e1f-ad9a-0c8e2efd61d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27e34f32-34d0-4dee-8fb4-00622331b076");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c7531be-4f8d-4d31-9045-12d23fefc3a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e1cc6a8-84af-4def-86de-fd89761f77d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35363f8f-3841-49d4-b734-fc68416238ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3780b550-dbe0-4e69-bc96-667766c60061");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38d59fc0-8091-4ca9-af25-a6473c95317c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c6f3aeb-d661-4c94-a61f-3c4e632eac61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d2d85e1-b01f-4741-bd14-2d6c24c24705");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ea03449-6b09-419d-9996-956b80edaba4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f3acbe4-a7e4-4b82-b70f-044e22cd767f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4296910d-c529-422c-af2e-1635b95be87a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "432cc6d9-5ffa-44c4-83f1-72e3e712c343");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48247e9f-7d55-44bc-ac49-f317a0db4c0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48d47ce3-cc7b-4520-9d46-5bdc5c46d3d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "492b38d8-391d-46e8-9046-e6a5b0ec3817");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4997d6e7-15ff-4bdf-a680-bff5d9b873da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4cf9630b-561e-4431-9e41-44d82ebe78e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f4d1604-d81c-40f5-9506-33344b6b78a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f9a38ed-0275-41e3-a337-282a09f5a280");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fccd97f-8fe4-48c3-aa37-f29f483be228");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5242648f-4336-48a6-bcf0-94714ffef3ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52ed4cc0-f4f5-4c20-a555-f09f0651d346");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "617a02c6-b4cc-4593-96eb-4f6b32d7fcd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "656b9c5f-3e45-4dc2-ba59-f4308ded43f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a78eb5-8082-488a-b765-92da166f13ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a980e2c-f534-4a5d-bd24-c09a19b73383");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b411719-1618-4f85-b390-7088d6f68c18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc7cd4a-bbdd-405b-b75d-3b7d3ebac122");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc9cd5c-9cf4-4ad4-9dd2-ec0e03756d6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c7ec71c-15de-47b9-82ea-7fa90c4cdeb3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6daaa969-13e1-42c0-82f5-98c03057ebfb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f75975c-fbca-4cf6-9874-5d8f56b1fbfe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74fa61e5-610a-4fc9-8d4e-69105e04fa72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76295d2c-4881-4d8f-a33d-61353826102b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77d6a78d-bc61-474b-8dc0-4f4e072730a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7869b58e-2540-4180-814a-005c46ed5243");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ad1fd7b-9948-4bec-9dfd-4c4c0ba402b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f765c1c-8f0b-41f3-a901-abc13fb00faf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81bae5fe-107b-45cc-b763-060db486419b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81da9f5d-7815-4f87-86b1-db210e79932f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "823710b1-0d4a-4765-bae6-52ae4412c2cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "836f34ba-7617-488e-ac9c-6e4112d95257");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85f2f828-39a0-4ad8-9730-93c670901404");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8815eba1-07d1-4b6b-9b0f-71a1ed62468e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92cf0ccc-1244-4e7c-a809-c5dd9d231976");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "967ba096-4682-4594-8e0d-67049cad525f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b00963d-34d5-46c3-bda7-5ddc274dbcff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b75315c-bdbb-408a-ba8b-a18f647b991b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d1d4b96-a43b-4606-b1f1-1357a664d69f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9da155c1-e223-41dd-889d-b5d9d2c85cbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af73d8ae-cadb-4087-9f27-581bbb632b30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b09abb2a-8468-4e81-8c19-f9aab7c0d4dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4bc6143-ae51-424b-983f-b64c302a311c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b576058c-df43-49bd-bedb-2655f35fc360");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b68b6c1f-8e48-444a-9487-8f3303ae7a51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9e862a8-a9d0-45bf-b322-b82f859ddd0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be12392a-c32a-4dc7-81e1-d9dc32e9e5f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfc8fbec-d764-465d-ab85-9e800838bfce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c26d3bd6-e239-40bd-a60d-b9786a6a614b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c379e547-f047-4944-a6f6-aac480820cf4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4d45f8d-fdf0-41b7-8778-2286dd502932");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ce8ed-98a9-4968-929e-a95bcaea619f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9652ff0-8337-4582-b349-cc64d3e966da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c97c4f4c-42b8-42b7-89c7-72012d63d802");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9f575af-03a3-4d0c-8982-97051cd9bf45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccb2af36-7067-4cdc-98ce-af507ad8e545");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ceebe0c9-0006-4d49-96ee-6a4bc7d494e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfaef36c-0b61-4c07-9b55-1faf4dee7c4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d01144d1-0a29-4a54-af8e-1eb84df4b41d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5031b00-849b-47c5-a868-8b614e530935");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1a27e3b-fc05-4d77-bf7b-2031de220852");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e457f38b-cc94-4e8c-a6d5-beb0aeb90130");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e674d9d2-856d-47e2-bd02-541eb743cf42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec945073-e5bf-48cd-bc86-27baa5496016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeaf5491-182e-45ac-a6d5-d09c1678529f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef34c213-0787-4e3b-810e-182076379c0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2907d24-32c0-4f5f-a312-b8cc9295f729");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2c2626f-8030-4c4f-91d0-2f35249b649e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f32cc995-0928-4cb7-828f-edd1b2c9a9a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b4e412-7812-4abf-b5f8-ef19fb66e642");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffa13245-464d-4e14-a769-9b7c5477a52f");

            migrationBuilder.DropColumn(
                name: "EGN",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
