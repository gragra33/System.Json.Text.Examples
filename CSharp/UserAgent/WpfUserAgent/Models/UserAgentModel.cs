// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.Generic;
using System.Text.Json.Serialization;
using WpfUserAgent.JsonConverters;

namespace WpfUserAgent.Models;

public class UserAgentModel
{
    [JsonPropertyName("appCodeName")]
    public string? AppCodeName { get; set; }
    
    [JsonPropertyName("appName")]
    public string? AppName  { get; set; }
     
    [JsonPropertyName("appVersion")]
    public string? AppVersion  { get; set; }
     
    [JsonPropertyName("cookieEnabled")]
    public bool? CookieEnabled  { get; set; }
     
    [JsonPropertyName("platform")]
    public string? Platform  { get; set; }
     
    [JsonPropertyName("oscpu")]
    public string? OsCpu { get; set; }
     
    [JsonPropertyName("product")]
    public string? Product  { get; set; }
     
    [JsonPropertyName("userAgent")]
    public string? UserAgentString  { get; set; }
     
    [JsonPropertyName("language")]
    public string? Language  { get; set; }
     
    [JsonPropertyName("languages")]
    public string[]? Languages  { get; set; }
      
    [JsonPropertyName("hardwareConcurrency")]
    public int? HardwareConcurrency { get; set; }
      
    [JsonPropertyName("pdfViewerEnabled")]
    public bool? PdfViewerEnabled { get; set; }
      
    [JsonPropertyName("maxTouchPoints")]
    public int? MaxTouchPoints { get; set; }
      
    [JsonPropertyName("vendor")]
    public string? Vendor { get; set; }
       
    [JsonPropertyName("vendorSub")]
    public string? VendorSub { get; set; }
       
    [JsonPropertyName("productSub")]
    public string? ProductSub { get; set; }
       
    [JsonPropertyName("buildID")]
    public string? BuildID { get; set; }

    [JsonPropertyName("doNotTrack")]
    public string? DoNotTrack { get; set; }

    [JsonPropertyName("userAgentData")]
    public UserAgentDataModel? UserAgentData { get; set; }

    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    [JsonPropertyName("plugins"), JsonConverter(typeof(UserAgentPluginsConverter))]
    public List<PluginModel>? Plugins { get; set; }
}