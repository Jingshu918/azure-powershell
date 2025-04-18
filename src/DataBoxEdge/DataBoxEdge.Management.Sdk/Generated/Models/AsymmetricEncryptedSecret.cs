// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using System.Linq;

    /// <summary>
    /// Represent the secrets intended for encryption with asymmetric key pair.
    /// </summary>
    public partial class AsymmetricEncryptedSecret
    {
        /// <summary>
        /// Initializes a new instance of the AsymmetricEncryptedSecret class.
        /// </summary>
        public AsymmetricEncryptedSecret()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AsymmetricEncryptedSecret class.
        /// </summary>

        /// <param name="value">The value of the secret.
        /// </param>

        /// <param name="encryptionCertThumbprint">Thumbprint certificate used to encrypt \&#34;Value\&#34;. If the value is
        /// unencrypted, it will be null.
        /// </param>

        /// <param name="encryptionAlgorithm">The algorithm used to encrypt &#34;Value&#34;.
        /// Possible values include: &#39;None&#39;, &#39;AES256&#39;, &#39;RSAES_PKCS1_v_1_5&#39;</param>
        public AsymmetricEncryptedSecret(string value, string encryptionAlgorithm, string encryptionCertThumbprint = default(string))

        {
            this.Value = value;
            this.EncryptionCertThumbprint = encryptionCertThumbprint;
            this.EncryptionAlgorithm = encryptionAlgorithm;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the value of the secret.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value {get; set; }

        /// <summary>
        /// Gets or sets thumbprint certificate used to encrypt \&#34;Value\&#34;. If the value
        /// is unencrypted, it will be null.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptionCertThumbprint")]
        public string EncryptionCertThumbprint {get; set; }

        /// <summary>
        /// Gets or sets the algorithm used to encrypt &#34;Value&#34;. Possible values include: &#39;None&#39;, &#39;AES256&#39;, &#39;RSAES_PKCS1_v_1_5&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptionAlgorithm")]
        public string EncryptionAlgorithm {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Value == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Value");
            }
            if (this.EncryptionAlgorithm == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "EncryptionAlgorithm");
            }



        }
    }
}