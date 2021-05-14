using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using CycloneDX.Xml;

namespace CycloneDX.Tests.Xml.v1_3
{
    public class ValidationTests
    {
        [Theory]
        [InlineData("valid-assembly-1.3.xml")]
        [InlineData("valid-bom-1.3.xml")]
        [InlineData("valid-component-hashes-1.3.xml")]
        [InlineData("valid-component-ref-1.3.xml")]
        [InlineData("valid-component-swid-1.3.xml")]
        [InlineData("valid-component-swid-full-1.3.xml")]
        [InlineData("valid-component-types-1.3.xml")]
        [InlineData("valid-compositions-1.3.xml")]
        [InlineData("valid-dependency-1.3.xml")]
        [InlineData("valid-empty-components-1.3.xml")]
        [InlineData("valid-evidence-1.3.xml")]
        // [InlineData("valid-external-elements-1.3.xml")]
        [InlineData("valid-external-reference-1.3.xml")]
        [InlineData("valid-license-expression-1.3.xml")]
        [InlineData("valid-license-id-1.3.xml")]
        [InlineData("valid-license-name-1.3.xml")]
        [InlineData("valid-metadata-author-1.3.xml")]
        [InlineData("valid-metadata-license-1.3.xml")]
        [InlineData("valid-metadata-manufacture-1.3.xml")]
        [InlineData("valid-metadata-supplier-1.3.xml")]
        [InlineData("valid-metadata-timestamp-1.3.xml")]
        [InlineData("valid-metadata-tool-1.3.xml")]
        [InlineData("valid-minimal-viable-1.3.xml")]
        [InlineData("valid-patch-1.3.xml")]
        [InlineData("valid-properties-1.3.xml")]
        // [InlineData("valid-random-attributes-1.3.xml")]
        [InlineData("valid-service-1.3.xml")]
        [InlineData("valid-service-empty-objects-1.3.xml")]
        // [InlineData("valid-xml-signature-1.3.xml")]
        public async Task ValidXmlTest(string filename)
        {
            var resourceFilename = Path.Join("Resources", "v1.3", filename);
            var xmlBom = File.ReadAllText(resourceFilename);

            var validationResult = await Validator.Validate(xmlBom, SchemaVersion.v1_3);

            Assert.True(validationResult.Valid);
        }

        [Theory]
        [InlineData("invalid-component-ref-1.3.xml")]
        [InlineData("invalid-component-swid-1.3.xml")]
        [InlineData("invalid-component-type-1.3.xml")]
        [InlineData("invalid-dependency-1.3.xml")]
        [InlineData("invalid-empty-component-1.3.xml")]
        [InlineData("invalid-hash-alg-1.3.xml")]
        [InlineData("invalid-hash-md5-1.3.xml")]
        [InlineData("invalid-hash-sha1-1.3.xml")]
        [InlineData("invalid-hash-sha256-1.3.xml")]
        [InlineData("invalid-hash-sha512-1.3.xml")]
        [InlineData("invalid-issue-type-1.3.xml")]
        [InlineData("invalid-license-choice-1.3.xml")]
        [InlineData("invalid-license-encoding-1.3.xml")]
        [InlineData("invalid-license-id-1.3.xml")]
        [InlineData("invalid-license-id-count-1.3.xml")]
        [InlineData("invalid-license-name-count-1.3.xml")]
        [InlineData("invalid-metadata-license-1.3.xml")]
        [InlineData("invalid-metadata-timestamp-1.3.xml")]
        [InlineData("invalid-missing-component-type-1.3.xml")]
        [InlineData("invalid-namespace-1.3.xml")]
        [InlineData("invalid-patch-type-1.3.xml")]
        [InlineData("invalid-scope-1.3.xml")]
        [InlineData("invalid-serialnumber-1.3.xml")]
        [InlineData("invalid-service-data-1.3.xml")]

        public async Task InvalidXmlTest(string filename)
        {
            var resourceFilename = Path.Join("Resources", "v1.3", filename);
            var xmlBom = File.ReadAllText(resourceFilename);

            var validationResult = await Validator.Validate(xmlBom, SchemaVersion.v1_3);

            Assert.False(validationResult.Valid);
        }

    }
}
