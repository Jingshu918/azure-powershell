// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a single certificate reference in a Key Vault, and where the
    /// certificate should reside on the VM.
    /// </summary>
    public partial class VaultCertificate
    {
        /// <summary>
        /// Initializes a new instance of the VaultCertificate class.
        /// </summary>
        public VaultCertificate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultCertificate class.
        /// </summary>

        /// <param name="certificateUrl">This is the URL of a certificate that has been uploaded to Key Vault as a
        /// secret. For adding a secret to the Key Vault, see [Add a key or secret to
        /// the key
        /// vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be It is the Base64 encoding of the
        /// following JSON Object which is encoded in UTF-8: &lt;br&gt;&lt;br&gt; {&lt;br&gt; 
        /// &#34;data&#34;:&#34;&lt;Base64-encoded-certificate&gt;&#34;,&lt;br&gt;  &#34;dataType&#34;:&#34;pfx&#34;,&lt;br&gt; 
        /// &#34;password&#34;:&#34;&lt;pfx-file-password&gt;&#34;&lt;br&gt;} &lt;br&gt; To install certificates on a
        /// virtual machine it is recommended to use the [Azure Key Vault virtual
        /// machine extension for
        /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </param>

        /// <param name="certificateStore">For Windows VMs, specifies the certificate store on the Virtual Machine to
        /// which the certificate should be added. The specified certificate store is
        /// implicitly in the LocalMachine account. &lt;br&gt;&lt;br&gt;For Linux VMs, the
        /// certificate file is placed under the /var/lib/waagent directory, with the
        /// file name &amp;lt;UppercaseThumbprint&amp;gt;.crt for the X509 certificate file and
        /// &amp;lt;UppercaseThumbprint&amp;gt;.prv for private key. Both of these files are
        /// .pem formatted.
        /// </param>
        public VaultCertificate(string certificateUrl = default(string), string certificateStore = default(string))

        {
            this.CertificateUrl = certificateUrl;
            this.CertificateStore = certificateStore;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets this is the URL of a certificate that has been uploaded to Key
        /// Vault as a secret. For adding a secret to the Key Vault, see [Add a key or
        /// secret to the key
        /// vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be It is the Base64 encoding of the
        /// following JSON Object which is encoded in UTF-8: &lt;br&gt;&lt;br&gt; {&lt;br&gt; 
        /// &#34;data&#34;:&#34;&lt;Base64-encoded-certificate&gt;&#34;,&lt;br&gt;  &#34;dataType&#34;:&#34;pfx&#34;,&lt;br&gt; 
        /// &#34;password&#34;:&#34;&lt;pfx-file-password&gt;&#34;&lt;br&gt;} &lt;br&gt; To install certificates on a
        /// virtual machine it is recommended to use the [Azure Key Vault virtual
        /// machine extension for
        /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateUrl")]
        public string CertificateUrl {get; set; }

        /// <summary>
        /// Gets or sets for Windows VMs, specifies the certificate store on the
        /// Virtual Machine to which the certificate should be added. The specified
        /// certificate store is implicitly in the LocalMachine account. &lt;br&gt;&lt;br&gt;For
        /// Linux VMs, the certificate file is placed under the /var/lib/waagent
        /// directory, with the file name &amp;lt;UppercaseThumbprint&amp;gt;.crt for the X509
        /// certificate file and &amp;lt;UppercaseThumbprint&amp;gt;.prv for private key. Both
        /// of these files are .pem formatted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateStore")]
        public string CertificateStore {get; set; }
    }
}