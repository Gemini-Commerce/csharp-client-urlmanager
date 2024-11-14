# urlmanager.Api.BasicOperationsApi

All URIs are relative to *https://urlmanager.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UrlManagerChangeUrlRewriteRequestPath**](BasicOperationsApi.md#urlmanagerchangeurlrewriterequestpath) | **POST** /urlmanager/change_url_rewrite_request_path | Change Url Rewrite Request Path |
| [**UrlManagerChangeUrlRewriteRequestPath2**](BasicOperationsApi.md#urlmanagerchangeurlrewriterequestpath2) | **POST** /urlmanager.UrlManager/ChangeUrlRewriteRequestPath | Change Url Rewrite Request Path |
| [**UrlManagerCreateUrlRewrite**](BasicOperationsApi.md#urlmanagercreateurlrewrite) | **POST** /urlmanager/create_url_rewrite | Create Url Rewrite |
| [**UrlManagerCreateUrlRewrite2**](BasicOperationsApi.md#urlmanagercreateurlrewrite2) | **POST** /urlmanager.UrlManager/CreateUrlRewrite | Create Url Rewrite |
| [**UrlManagerDeleteUrlRewrite**](BasicOperationsApi.md#urlmanagerdeleteurlrewrite) | **POST** /urlmanager/delete_url_rewrite | Delete Url Rewrite |
| [**UrlManagerDeleteUrlRewrite2**](BasicOperationsApi.md#urlmanagerdeleteurlrewrite2) | **POST** /urlmanager.UrlManager/DeleteUrlRewrite | Delete Url Rewrite |
| [**UrlManagerGetUrlRewrite**](BasicOperationsApi.md#urlmanagergeturlrewrite) | **POST** /urlmanager/get_url_rewrite | Get Url Rewrite |
| [**UrlManagerGetUrlRewrite2**](BasicOperationsApi.md#urlmanagergeturlrewrite2) | **POST** /urlmanager.UrlManager/GetUrlRewrite | Get Url Rewrite |
| [**UrlManagerListUrlRewrites**](BasicOperationsApi.md#urlmanagerlisturlrewrites) | **POST** /urlmanager/list_url_rewrites | List Url Rewrites |
| [**UrlManagerListUrlRewrites2**](BasicOperationsApi.md#urlmanagerlisturlrewrites2) | **POST** /urlmanager.UrlManager/ListUrlRewrites | List Url Rewrites |
| [**UrlManagerListUrlRewritesByTargetPaths**](BasicOperationsApi.md#urlmanagerlisturlrewritesbytargetpaths) | **POST** /urlmanager/list_url_rewrites_by_target_paths | List Url Rewrites By Target Paths |
| [**UrlManagerListUrlRewritesByTargetPaths2**](BasicOperationsApi.md#urlmanagerlisturlrewritesbytargetpaths2) | **POST** /urlmanager.UrlManager/ListUrlRewritesByTargetPaths | List Url Rewrites By Target Paths |
| [**UrlManagerResolveUrlRewrite**](BasicOperationsApi.md#urlmanagerresolveurlrewrite) | **POST** /urlmanager/resolve_url_rewrite | Resolve Url Rewrite |
| [**UrlManagerResolveUrlRewrite2**](BasicOperationsApi.md#urlmanagerresolveurlrewrite2) | **POST** /urlmanager.UrlManager/ResolveUrlRewrite | Resolve Url Rewrite |

<a id="urlmanagerchangeurlrewriterequestpath"></a>
# **UrlManagerChangeUrlRewriteRequestPath**
> Object UrlManagerChangeUrlRewriteRequestPath (UrlmanagerChangeUrlRewriteRequestPathRequest body)

Change Url Rewrite Request Path

Modify the request path of a specific URL rewrite configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerChangeUrlRewriteRequestPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerChangeUrlRewriteRequestPathRequest(); // UrlmanagerChangeUrlRewriteRequestPathRequest | 

            try
            {
                // Change Url Rewrite Request Path
                Object result = apiInstance.UrlManagerChangeUrlRewriteRequestPath(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerChangeUrlRewriteRequestPath: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerChangeUrlRewriteRequestPathWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change Url Rewrite Request Path
    ApiResponse<Object> response = apiInstance.UrlManagerChangeUrlRewriteRequestPathWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerChangeUrlRewriteRequestPathWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerChangeUrlRewriteRequestPathRequest**](UrlmanagerChangeUrlRewriteRequestPathRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagerchangeurlrewriterequestpath2"></a>
# **UrlManagerChangeUrlRewriteRequestPath2**
> Object UrlManagerChangeUrlRewriteRequestPath2 (UrlmanagerChangeUrlRewriteRequestPathRequest body)

Change Url Rewrite Request Path

Modify the request path of a specific URL rewrite configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerChangeUrlRewriteRequestPath2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerChangeUrlRewriteRequestPathRequest(); // UrlmanagerChangeUrlRewriteRequestPathRequest | 

            try
            {
                // Change Url Rewrite Request Path
                Object result = apiInstance.UrlManagerChangeUrlRewriteRequestPath2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerChangeUrlRewriteRequestPath2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerChangeUrlRewriteRequestPath2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change Url Rewrite Request Path
    ApiResponse<Object> response = apiInstance.UrlManagerChangeUrlRewriteRequestPath2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerChangeUrlRewriteRequestPath2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerChangeUrlRewriteRequestPathRequest**](UrlmanagerChangeUrlRewriteRequestPathRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagercreateurlrewrite"></a>
# **UrlManagerCreateUrlRewrite**
> UrlmanagerUrlRewrite UrlManagerCreateUrlRewrite (UrlmanagerCreateUrlRewriteRequest body)

Create Url Rewrite

Create a new URL rewrite configuration with customizable rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerCreateUrlRewriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerCreateUrlRewriteRequest(); // UrlmanagerCreateUrlRewriteRequest | 

            try
            {
                // Create Url Rewrite
                UrlmanagerUrlRewrite result = apiInstance.UrlManagerCreateUrlRewrite(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerCreateUrlRewrite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerCreateUrlRewriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Url Rewrite
    ApiResponse<UrlmanagerUrlRewrite> response = apiInstance.UrlManagerCreateUrlRewriteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerCreateUrlRewriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerCreateUrlRewriteRequest**](UrlmanagerCreateUrlRewriteRequest.md) |  |  |

### Return type

[**UrlmanagerUrlRewrite**](UrlmanagerUrlRewrite.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagercreateurlrewrite2"></a>
# **UrlManagerCreateUrlRewrite2**
> UrlmanagerUrlRewrite UrlManagerCreateUrlRewrite2 (UrlmanagerCreateUrlRewriteRequest body)

Create Url Rewrite

Create a new URL rewrite configuration with customizable rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerCreateUrlRewrite2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerCreateUrlRewriteRequest(); // UrlmanagerCreateUrlRewriteRequest | 

            try
            {
                // Create Url Rewrite
                UrlmanagerUrlRewrite result = apiInstance.UrlManagerCreateUrlRewrite2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerCreateUrlRewrite2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerCreateUrlRewrite2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Url Rewrite
    ApiResponse<UrlmanagerUrlRewrite> response = apiInstance.UrlManagerCreateUrlRewrite2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerCreateUrlRewrite2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerCreateUrlRewriteRequest**](UrlmanagerCreateUrlRewriteRequest.md) |  |  |

### Return type

[**UrlmanagerUrlRewrite**](UrlmanagerUrlRewrite.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagerdeleteurlrewrite"></a>
# **UrlManagerDeleteUrlRewrite**
> Object UrlManagerDeleteUrlRewrite (UrlmanagerDeleteUrlRewriteRequest body)

Delete Url Rewrite

Delete an existing URL rewrite configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerDeleteUrlRewriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerDeleteUrlRewriteRequest(); // UrlmanagerDeleteUrlRewriteRequest | 

            try
            {
                // Delete Url Rewrite
                Object result = apiInstance.UrlManagerDeleteUrlRewrite(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerDeleteUrlRewrite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerDeleteUrlRewriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Url Rewrite
    ApiResponse<Object> response = apiInstance.UrlManagerDeleteUrlRewriteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerDeleteUrlRewriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerDeleteUrlRewriteRequest**](UrlmanagerDeleteUrlRewriteRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagerdeleteurlrewrite2"></a>
# **UrlManagerDeleteUrlRewrite2**
> Object UrlManagerDeleteUrlRewrite2 (UrlmanagerDeleteUrlRewriteRequest body)

Delete Url Rewrite

Delete an existing URL rewrite configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerDeleteUrlRewrite2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerDeleteUrlRewriteRequest(); // UrlmanagerDeleteUrlRewriteRequest | 

            try
            {
                // Delete Url Rewrite
                Object result = apiInstance.UrlManagerDeleteUrlRewrite2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerDeleteUrlRewrite2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerDeleteUrlRewrite2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Url Rewrite
    ApiResponse<Object> response = apiInstance.UrlManagerDeleteUrlRewrite2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerDeleteUrlRewrite2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerDeleteUrlRewriteRequest**](UrlmanagerDeleteUrlRewriteRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagergeturlrewrite"></a>
# **UrlManagerGetUrlRewrite**
> UrlmanagerUrlRewrite UrlManagerGetUrlRewrite (UrlmanagerGetUrlRewriteRequest body)

Get Url Rewrite

Retrieve the details of a specific URL rewrite configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerGetUrlRewriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerGetUrlRewriteRequest(); // UrlmanagerGetUrlRewriteRequest | 

            try
            {
                // Get Url Rewrite
                UrlmanagerUrlRewrite result = apiInstance.UrlManagerGetUrlRewrite(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerGetUrlRewrite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerGetUrlRewriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Url Rewrite
    ApiResponse<UrlmanagerUrlRewrite> response = apiInstance.UrlManagerGetUrlRewriteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerGetUrlRewriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerGetUrlRewriteRequest**](UrlmanagerGetUrlRewriteRequest.md) |  |  |

### Return type

[**UrlmanagerUrlRewrite**](UrlmanagerUrlRewrite.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagergeturlrewrite2"></a>
# **UrlManagerGetUrlRewrite2**
> UrlmanagerUrlRewrite UrlManagerGetUrlRewrite2 (UrlmanagerGetUrlRewriteRequest body)

Get Url Rewrite

Retrieve the details of a specific URL rewrite configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerGetUrlRewrite2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerGetUrlRewriteRequest(); // UrlmanagerGetUrlRewriteRequest | 

            try
            {
                // Get Url Rewrite
                UrlmanagerUrlRewrite result = apiInstance.UrlManagerGetUrlRewrite2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerGetUrlRewrite2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerGetUrlRewrite2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Url Rewrite
    ApiResponse<UrlmanagerUrlRewrite> response = apiInstance.UrlManagerGetUrlRewrite2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerGetUrlRewrite2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerGetUrlRewriteRequest**](UrlmanagerGetUrlRewriteRequest.md) |  |  |

### Return type

[**UrlmanagerUrlRewrite**](UrlmanagerUrlRewrite.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagerlisturlrewrites"></a>
# **UrlManagerListUrlRewrites**
> UrlmanagerListUrlRewritesResponse UrlManagerListUrlRewrites (UrlmanagerListUrlRewritesRequest body)

List Url Rewrites

Retrieve a list of all URL rewrite configurations in your application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerListUrlRewritesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerListUrlRewritesRequest(); // UrlmanagerListUrlRewritesRequest | 

            try
            {
                // List Url Rewrites
                UrlmanagerListUrlRewritesResponse result = apiInstance.UrlManagerListUrlRewrites(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerListUrlRewrites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerListUrlRewritesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Url Rewrites
    ApiResponse<UrlmanagerListUrlRewritesResponse> response = apiInstance.UrlManagerListUrlRewritesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerListUrlRewritesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerListUrlRewritesRequest**](UrlmanagerListUrlRewritesRequest.md) |  |  |

### Return type

[**UrlmanagerListUrlRewritesResponse**](UrlmanagerListUrlRewritesResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagerlisturlrewrites2"></a>
# **UrlManagerListUrlRewrites2**
> UrlmanagerListUrlRewritesResponse UrlManagerListUrlRewrites2 (UrlmanagerListUrlRewritesRequest body)

List Url Rewrites

Retrieve a list of all URL rewrite configurations in your application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerListUrlRewrites2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerListUrlRewritesRequest(); // UrlmanagerListUrlRewritesRequest | 

            try
            {
                // List Url Rewrites
                UrlmanagerListUrlRewritesResponse result = apiInstance.UrlManagerListUrlRewrites2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerListUrlRewrites2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerListUrlRewrites2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Url Rewrites
    ApiResponse<UrlmanagerListUrlRewritesResponse> response = apiInstance.UrlManagerListUrlRewrites2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerListUrlRewrites2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerListUrlRewritesRequest**](UrlmanagerListUrlRewritesRequest.md) |  |  |

### Return type

[**UrlmanagerListUrlRewritesResponse**](UrlmanagerListUrlRewritesResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagerlisturlrewritesbytargetpaths"></a>
# **UrlManagerListUrlRewritesByTargetPaths**
> UrlmanagerListUrlRewritesByTargetPathsRequest UrlManagerListUrlRewritesByTargetPaths (UrlmanagerListUrlRewritesByTargetPathsRequest body)

List Url Rewrites By Target Paths

Retrieve URL rewrite configurations based on target paths.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerListUrlRewritesByTargetPathsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerListUrlRewritesByTargetPathsRequest(); // UrlmanagerListUrlRewritesByTargetPathsRequest | 

            try
            {
                // List Url Rewrites By Target Paths
                UrlmanagerListUrlRewritesByTargetPathsRequest result = apiInstance.UrlManagerListUrlRewritesByTargetPaths(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerListUrlRewritesByTargetPaths: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerListUrlRewritesByTargetPathsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Url Rewrites By Target Paths
    ApiResponse<UrlmanagerListUrlRewritesByTargetPathsRequest> response = apiInstance.UrlManagerListUrlRewritesByTargetPathsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerListUrlRewritesByTargetPathsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerListUrlRewritesByTargetPathsRequest**](UrlmanagerListUrlRewritesByTargetPathsRequest.md) |  |  |

### Return type

[**UrlmanagerListUrlRewritesByTargetPathsRequest**](UrlmanagerListUrlRewritesByTargetPathsRequest.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagerlisturlrewritesbytargetpaths2"></a>
# **UrlManagerListUrlRewritesByTargetPaths2**
> UrlmanagerListUrlRewritesByTargetPathsRequest UrlManagerListUrlRewritesByTargetPaths2 (UrlmanagerListUrlRewritesByTargetPathsRequest body)

List Url Rewrites By Target Paths

Retrieve URL rewrite configurations based on target paths.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerListUrlRewritesByTargetPaths2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerListUrlRewritesByTargetPathsRequest(); // UrlmanagerListUrlRewritesByTargetPathsRequest | 

            try
            {
                // List Url Rewrites By Target Paths
                UrlmanagerListUrlRewritesByTargetPathsRequest result = apiInstance.UrlManagerListUrlRewritesByTargetPaths2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerListUrlRewritesByTargetPaths2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerListUrlRewritesByTargetPaths2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Url Rewrites By Target Paths
    ApiResponse<UrlmanagerListUrlRewritesByTargetPathsRequest> response = apiInstance.UrlManagerListUrlRewritesByTargetPaths2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerListUrlRewritesByTargetPaths2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerListUrlRewritesByTargetPathsRequest**](UrlmanagerListUrlRewritesByTargetPathsRequest.md) |  |  |

### Return type

[**UrlmanagerListUrlRewritesByTargetPathsRequest**](UrlmanagerListUrlRewritesByTargetPathsRequest.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagerresolveurlrewrite"></a>
# **UrlManagerResolveUrlRewrite**
> UrlmanagerUrlRewrite UrlManagerResolveUrlRewrite (UrlmanagerResolveUrlRewriteRequest body)

Resolve Url Rewrite

Resolve and retrieve the rewritten URL for a given input URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerResolveUrlRewriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerResolveUrlRewriteRequest(); // UrlmanagerResolveUrlRewriteRequest | 

            try
            {
                // Resolve Url Rewrite
                UrlmanagerUrlRewrite result = apiInstance.UrlManagerResolveUrlRewrite(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerResolveUrlRewrite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerResolveUrlRewriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resolve Url Rewrite
    ApiResponse<UrlmanagerUrlRewrite> response = apiInstance.UrlManagerResolveUrlRewriteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerResolveUrlRewriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerResolveUrlRewriteRequest**](UrlmanagerResolveUrlRewriteRequest.md) |  |  |

### Return type

[**UrlmanagerUrlRewrite**](UrlmanagerUrlRewrite.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="urlmanagerresolveurlrewrite2"></a>
# **UrlManagerResolveUrlRewrite2**
> UrlmanagerUrlRewrite UrlManagerResolveUrlRewrite2 (UrlmanagerResolveUrlRewriteRequest body)

Resolve Url Rewrite

Resolve and retrieve the rewritten URL for a given input URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using urlmanager.Api;
using urlmanager.Client;
using urlmanager.Model;

namespace Example
{
    public class UrlManagerResolveUrlRewrite2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://urlmanager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new UrlmanagerResolveUrlRewriteRequest(); // UrlmanagerResolveUrlRewriteRequest | 

            try
            {
                // Resolve Url Rewrite
                UrlmanagerUrlRewrite result = apiInstance.UrlManagerResolveUrlRewrite2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UrlManagerResolveUrlRewrite2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UrlManagerResolveUrlRewrite2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resolve Url Rewrite
    ApiResponse<UrlmanagerUrlRewrite> response = apiInstance.UrlManagerResolveUrlRewrite2WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UrlManagerResolveUrlRewrite2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UrlmanagerResolveUrlRewriteRequest**](UrlmanagerResolveUrlRewriteRequest.md) |  |  |

### Return type

[**UrlmanagerUrlRewrite**](UrlmanagerUrlRewrite.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

