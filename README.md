#Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (M3ScaleAccountManagement.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=3Scale%20Account%20Management-CSharp&workspaceName=M3ScaleAccountManagement&projectName=M3ScaleAccountManagement.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the M3ScaleAccountManagement library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=3Scale%20Account%20Management-CSharp&workspaceName=M3ScaleAccountManagement&projectName=M3ScaleAccountManagement.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=3Scale%20Account%20Management-CSharp&workspaceName=M3ScaleAccountManagement&projectName=M3ScaleAccountManagement.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=3Scale%20Account%20Management-CSharp&workspaceName=M3ScaleAccountManagement&projectName=M3ScaleAccountManagement.PCL)

### 3. Add reference of the library project

In order to use the M3ScaleAccountManagement library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=3Scale%20Account%20Management-CSharp&workspaceName=M3ScaleAccountManagement&projectName=M3ScaleAccountManagement.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` M3ScaleAccountManagement.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```M3ScaleAccountManagement.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=3Scale%20Account%20Management-CSharp&workspaceName=M3ScaleAccountManagement&projectName=M3ScaleAccountManagement.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=3Scale%20Account%20Management-CSharp&workspaceName=M3ScaleAccountManagement&projectName=M3ScaleAccountManagement.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

M3ScaleAccountManagementClient client = new M3ScaleAccountManagementClient();
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [ApplicationPlanController](#application_plan_controller)
* [AccountController](#account_controller)
* [SignupController](#signup_controller)
* [AccountPlanController](#account_plan_controller)
* [AccountFeatureController](#account_feature_controller)
* [ProxyController](#proxy_controller)
* [UserController](#user_controller)
* [ApplicationController](#application_controller)
* [WebhooksController](#webhooks_controller)
* [UserProviderAccountController](#user_provider_account_controller)
* [ServiceController](#service_controller)
* [MappingRuleController](#mapping_rule_controller)
* [EndUserController](#end_user_controller)
* [EndUserPlanController](#end_user_plan_controller)
* [ServicePlanController](#service_plan_controller)
* [ServicePlanFeatureController](#service_plan_feature_controller)
* [ServiceFeatureController](#service_feature_controller)
* [MetricController](#metric_controller)
* [MetricMethodController](#metric_method_controller)
* [EndUserPlanLimitController](#end_user_plan_limit_controller)
* [ApplicationPlanPricingRulesController](#application_plan_pricing_rules_controller)
* [ApplicationPlanLimitController](#application_plan_limit_controller)
* [ApplicationPlanLimitsController](#application_plan_limits_controller)
* [ApplicationPlanFeatureController](#application_plan_feature_controller)
* [ActiveDocsController](#active_docs_controller)
* [NginxController](#nginx_controller)
* [AccountPlanFeatureController](#account_plan_feature_controller)

### <a name="application_plan_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanController") ApplicationPlanController

#### Get singleton instance

The singleton instance of the ``` ApplicationPlanController ``` class can be accessed from the API Client.

```csharp
ApplicationPlanController applicationPlan = client.ApplicationPlan;
```

#### <a name="get_admin_api_application_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanController.GetAdminApiApplicationPlansXml") GetAdminApiApplicationPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all application plans across services. Note that application plans are scoped by service.


```csharp
Task<dynamic> GetAdminApiApplicationPlansXml(string accessToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";

dynamic result = await applicationPlan.GetAdminApiApplicationPlansXml(accessToken);

```


#### <a name="update_admin_api_services_application_plans_default_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanController.UpdateAdminApiServicesApplicationPlansDefaultXml") UpdateAdminApiServicesApplicationPlansDefaultXml

> *Tags:*  ``` Skips Authentication ``` 

> Makes the application plan the default one. New applications will be assigned to the default plan unless an application_plan_id is explicity passed (e.g. on the signup express operation).


```csharp
Task<dynamic> UpdateAdminApiServicesApplicationPlansDefaultXml(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 105;
int id = 105;

dynamic result = await applicationPlan.UpdateAdminApiServicesApplicationPlansDefaultXml(accessToken, serviceId, id);

```


#### <a name="delete_admin_api_services_application_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanController.DeleteAdminApiServicesApplicationPlansXml") DeleteAdminApiServicesApplicationPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes an application plan.


```csharp
Task<dynamic> DeleteAdminApiServicesApplicationPlansXml(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 105;
int id = 105;

dynamic result = await applicationPlan.DeleteAdminApiServicesApplicationPlansXml(accessToken, serviceId, id);

```


#### <a name="update_admin_api_services_application_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanController.UpdateAdminApiServicesApplicationPlansXml") UpdateAdminApiServicesApplicationPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Updates an application plan.


```csharp
Task<dynamic> UpdateAdminApiServicesApplicationPlansXml(
        string accessToken,
        int serviceId,
        int id,
        string name = null,
        Dictionary<string, object> queryParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | TODO: Add a parameter description |
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 105;
int id = 105;
string name = "name";
// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


dynamic result = await applicationPlan.UpdateAdminApiServicesApplicationPlansXml(accessToken, serviceId, id, name, queryParams);

```


#### <a name="get_admin_api_services_application_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanController.GetAdminApiServicesApplicationPlansXml") GetAdminApiServicesApplicationPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns and application plan.


```csharp
Task<dynamic> GetAdminApiServicesApplicationPlansXml(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 63;
int id = 63;

dynamic result = await applicationPlan.GetAdminApiServicesApplicationPlansXml(accessToken, serviceId, id);

```


#### <a name="create_admin_api_services_application_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanController.CreateAdminApiServicesApplicationPlansXml") CreateAdminApiServicesApplicationPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Creates an application plan.


```csharp
Task<dynamic> CreateAdminApiServicesApplicationPlansXml(
        string accessToken,
        int serviceId,
        string name,
        string systemName = null,
        Dictionary<string, object> queryParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |
| systemName |  ``` Optional ```  | TODO: Add a parameter description |
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 63;
string name = "name";
string systemName = "system_name";
// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


dynamic result = await applicationPlan.CreateAdminApiServicesApplicationPlansXml(accessToken, serviceId, name, systemName, queryParams);

```


#### <a name="get_admin_api_services_application_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanController.GetAdminApiServicesApplicationPlansXml") GetAdminApiServicesApplicationPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all application plans of a service.


```csharp
Task<dynamic> GetAdminApiServicesApplicationPlansXml(string accessToken, int serviceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 63;

dynamic result = await applicationPlan.GetAdminApiServicesApplicationPlansXml(accessToken, serviceId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="account_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.AccountController") AccountController

#### Get singleton instance

The singleton instance of the ``` AccountController ``` class can be accessed from the API Client.

```csharp
AccountController account = client.Account;
```

#### <a name="get_admin_api_accounts_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.GetAdminApiAccountsXmlById") GetAdminApiAccountsXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Returns a developer account.


```csharp
Task<dynamic> GetAdminApiAccountsXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await account.GetAdminApiAccountsXmlById(accessToken, id);

```


#### <a name="update_admin_api_accounts_credit_card_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.UpdateAdminApiAccountsCreditCardXmlById") UpdateAdminApiAccountsCreditCardXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Associates credit card tokens and billing address to an account. This operation is only required if you use your own credit card capture method. These tokens are the ones required by Authorize.net, ogone, braintree, payment express and merchant e solutions


```csharp
Task<dynamic> UpdateAdminApiAccountsCreditCardXmlById(
        string accessToken,
        int id,
        string creditCardToken,
        string creditCardExpirationYear,
        string creditCardExpirationMonth,
        string billingAddressName,
        string billingAddressAddress,
        string billingAddressCity,
        string billingAddressCountry,
        string creditCardAuthorizeNetPaymentProfileToken = null,
        string billingAddressState = null,
        string billingAddressPhone = null,
        string billingAddressZip = null,
        string creditCardPartialNumber = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| creditCardToken |  ``` Required ```  | TODO: Add a parameter description |
| creditCardExpirationYear |  ``` Required ```  | TODO: Add a parameter description |
| creditCardExpirationMonth |  ``` Required ```  | TODO: Add a parameter description |
| billingAddressName |  ``` Required ```  | TODO: Add a parameter description |
| billingAddressAddress |  ``` Required ```  | TODO: Add a parameter description |
| billingAddressCity |  ``` Required ```  | TODO: Add a parameter description |
| billingAddressCountry |  ``` Required ```  | TODO: Add a parameter description |
| creditCardAuthorizeNetPaymentProfileToken |  ``` Optional ```  | TODO: Add a parameter description |
| billingAddressState |  ``` Optional ```  | TODO: Add a parameter description |
| billingAddressPhone |  ``` Optional ```  | TODO: Add a parameter description |
| billingAddressZip |  ``` Optional ```  | TODO: Add a parameter description |
| creditCardPartialNumber |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;
string creditCardToken = "credit_card_token";
string creditCardExpirationYear = "credit_card_expiration_year";
string creditCardExpirationMonth = "credit_card_expiration_month";
string billingAddressName = "billing_address_name";
string billingAddressAddress = "billing_address_address";
string billingAddressCity = "billing_address_city";
string billingAddressCountry = "billing_address_country";
string creditCardAuthorizeNetPaymentProfileToken = "credit_card_authorize_net_payment_profile_token";
string billingAddressState = "billing_address_state";
string billingAddressPhone = "billing_address_phone";
string billingAddressZip = "billing_address_zip";
string creditCardPartialNumber = "credit_card_partial_number";

dynamic result = await account.UpdateAdminApiAccountsCreditCardXmlById(accessToken, id, creditCardToken, creditCardExpirationYear, creditCardExpirationMonth, billingAddressName, billingAddressAddress, billingAddressCity, billingAddressCountry, creditCardAuthorizeNetPaymentProfileToken, billingAddressState, billingAddressPhone, billingAddressZip, creditCardPartialNumber);

```


#### <a name="create_admin_api_accounts_messages_xml_by_account_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.CreateAdminApiAccountsMessagesXmlByAccountId") CreateAdminApiAccountsMessagesXmlByAccountId

> *Tags:*  ``` Skips Authentication ``` 

> Sends a message to the account.


```csharp
Task<dynamic> CreateAdminApiAccountsMessagesXmlByAccountId(string accessToken, int accountId, string body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
string body = "body";

dynamic result = await account.CreateAdminApiAccountsMessagesXmlByAccountId(accessToken, accountId, body);

```


#### <a name="get_admin_api_accounts_plan_xml_by_account_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.GetAdminApiAccountsPlanXmlByAccountId") GetAdminApiAccountsPlanXmlByAccountId

> *Tags:*  ``` Skips Authentication ``` 

> Returns the account plan associated to an account.


```csharp
Task<dynamic> GetAdminApiAccountsPlanXmlByAccountId(string accessToken, int accountId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;

dynamic result = await account.GetAdminApiAccountsPlanXmlByAccountId(accessToken, accountId);

```


#### <a name="update_admin_api_accounts_make_pending_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.UpdateAdminApiAccountsMakePendingXmlById") UpdateAdminApiAccountsMakePendingXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Resets the state of the account to pending so that it can be approved or rejected again.


```csharp
Task<dynamic> UpdateAdminApiAccountsMakePendingXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await account.UpdateAdminApiAccountsMakePendingXmlById(accessToken, id);

```


#### <a name="update_admin_api_accounts_reject_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.UpdateAdminApiAccountsRejectXmlById") UpdateAdminApiAccountsRejectXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Rejects the account (changes the state to rejected). An account can be rejected after creation, the workflow for account creation can have a validation process that ends in approving or rejecting the account submission. The state can also be updated by PUT on /admin/api/accounts/{id}.xml


```csharp
Task<dynamic> UpdateAdminApiAccountsRejectXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await account.UpdateAdminApiAccountsRejectXmlById(accessToken, id);

```


#### <a name="update_admin_api_accounts_approve_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.UpdateAdminApiAccountsApproveXmlById") UpdateAdminApiAccountsApproveXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Approves the account (changes the state to live). Accounts need to be approved explicitly via this API after creation. The state can also be updated by PUT on /admin/api/accounts/{id}.xml


```csharp
Task<dynamic> UpdateAdminApiAccountsApproveXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await account.UpdateAdminApiAccountsApproveXmlById(accessToken, id);

```


#### <a name="update_admin_api_accounts_change_plan_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.UpdateAdminApiAccountsChangePlanXmlById") UpdateAdminApiAccountsChangePlanXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Changes the account plan for the developer account.


```csharp
Task<dynamic> UpdateAdminApiAccountsChangePlanXmlById(string accessToken, int id, int planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| planId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;
int planId = 63;

dynamic result = await account.UpdateAdminApiAccountsChangePlanXmlById(accessToken, id, planId);

```


#### <a name="get_admin_api_provider_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.GetAdminApiProviderXml") GetAdminApiProviderXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns your account.


```csharp
Task<dynamic> GetAdminApiProviderXml()
```

#### Example Usage

```csharp

dynamic result = await account.GetAdminApiProviderXml();

```


#### <a name="delete_admin_api_accounts_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.DeleteAdminApiAccountsXmlById") DeleteAdminApiAccountsXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Deletes a developer account. Deleting an account removes all users, applications and service subscriptions to the account.


```csharp
Task<dynamic> DeleteAdminApiAccountsXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await account.DeleteAdminApiAccountsXmlById(accessToken, id);

```


#### <a name="update_admin_api_accounts_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.UpdateAdminApiAccountsXmlById") UpdateAdminApiAccountsXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Updates a developer account by ID. You can modify all the fields on the account, including custom fields defined in the fields definition section of your admin portal.


```csharp
Task<dynamic> UpdateAdminApiAccountsXmlById(
        string accessToken,
        int id,
        string orgName = null,
        object additionalFields = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| orgName |  ``` Optional ```  | TODO: Add a parameter description |
| additionalFields |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;
string orgName = "org_name";
object additionalFields = new object();

dynamic result = await account.UpdateAdminApiAccountsXmlById(accessToken, id, orgName, additionalFields);

```


#### <a name="get_admin_api_accounts_find_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.GetAdminApiAccountsFindXml") GetAdminApiAccountsFindXml

> *Tags:*  ``` Skips Authentication ``` 

> Find an account by the username or email of its users (username takes precendence over email).


```csharp
Task<dynamic> GetAdminApiAccountsFindXml(
        string accessToken,
        string username = null,
        string email = null,
        int? userId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| username |  ``` Optional ```  | TODO: Add a parameter description |
| email |  ``` Optional ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
string username = "username";
string email = "email";
int? userId = 63;

dynamic result = await account.GetAdminApiAccountsFindXml(accessToken, username, email, userId);

```


#### <a name="get_admin_api_accounts_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.GetAdminApiAccountsXml") GetAdminApiAccountsXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of developer accounts (the accounts that consume your API). Filters by state are available and the results can be paginated.


```csharp
Task<dynamic> GetAdminApiAccountsXml(
        string accessToken,
        StateEnum? state = null,
        int? page = null,
        int? perPage = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| state |  ``` Optional ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | TODO: Add a parameter description |
| perPage |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
var state = StateEnum?Helper.ParseString("pending");
int? page = 63;
int? perPage = 63;

dynamic result = await account.GetAdminApiAccountsXml(accessToken, state, page, perPage);

```


#### <a name="delete_admin_api_accounts_credit_card_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountController.DeleteAdminApiAccountsCreditCardXmlById") DeleteAdminApiAccountsCreditCardXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Removes all credit card info of an account.


```csharp
Task<dynamic> DeleteAdminApiAccountsCreditCardXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await account.DeleteAdminApiAccountsCreditCardXmlById(accessToken, id);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="signup_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.SignupController") SignupController

#### Get singleton instance

The singleton instance of the ``` SignupController ``` class can be accessed from the API Client.

```csharp
SignupController signup = client.Signup;
```

#### <a name="create_admin_api_signup_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.SignupController.CreateAdminApiSignupXml") CreateAdminApiSignupXml

> *Tags:*  ``` Skips Authentication ``` 

> This request allows you to reproduce a sign-up from a developer in a single API call. It will create an Account, an Admin User for the account, and optionally an Application with its keys. If the plan_id is not passed, the default plan will be used instead. You can add additional custom parameters in Fields Definition on your Admin Portal.


```csharp
Task<dynamic> CreateAdminApiSignupXml(
        string accessToken,
        string orgName,
        string username,
        string email,
        string password,
        int? accountPlanId = null,
        int? servicePlanId = null,
        int? applicationPlanId = null,
        object additionalFields = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| orgName |  ``` Required ```  | TODO: Add a parameter description |
| username |  ``` Required ```  | TODO: Add a parameter description |
| email |  ``` Required ```  | TODO: Add a parameter description |
| password |  ``` Required ```  | TODO: Add a parameter description |
| accountPlanId |  ``` Optional ```  | TODO: Add a parameter description |
| servicePlanId |  ``` Optional ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Optional ```  | TODO: Add a parameter description |
| additionalFields |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
string orgName = "org_name";
string username = "username";
string email = "email";
string password = "password";
int? accountPlanId = 63;
int? servicePlanId = 63;
int? applicationPlanId = 63;
object additionalFields = new object();

dynamic result = await signup.CreateAdminApiSignupXml(accessToken, orgName, username, email, password, accountPlanId, servicePlanId, applicationPlanId, additionalFields);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="account_plan_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanController") AccountPlanController

#### Get singleton instance

The singleton instance of the ``` AccountPlanController ``` class can be accessed from the API Client.

```csharp
AccountPlanController accountPlan = client.AccountPlan;
```

#### <a name="delete_admin_api_account_plans_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanController.DeleteAdminApiAccountPlansXmlById") DeleteAdminApiAccountPlansXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Deletes an account plan.


```csharp
Task<dynamic> DeleteAdminApiAccountPlansXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await accountPlan.DeleteAdminApiAccountPlansXmlById(accessToken, id);

```


#### <a name="get_admin_api_account_plans_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanController.GetAdminApiAccountPlansXmlById") GetAdminApiAccountPlansXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Returns the account plan by ID.


```csharp
Task<dynamic> GetAdminApiAccountPlansXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await accountPlan.GetAdminApiAccountPlansXmlById(accessToken, id);

```


#### <a name="get_admin_api_account_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanController.GetAdminApiAccountPlansXml") GetAdminApiAccountPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all available account plans.


```csharp
Task<dynamic> GetAdminApiAccountPlansXml(string accessToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";

dynamic result = await accountPlan.GetAdminApiAccountPlansXml(accessToken);

```


#### <a name="update_admin_api_account_plans_default_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanController.UpdateAdminApiAccountPlansDefaultXmlById") UpdateAdminApiAccountPlansDefaultXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Set the account plan to be the default one. The default account plan is used unless another account plan is passed explicitly, for instance on the signup express.


```csharp
Task<dynamic> UpdateAdminApiAccountPlansDefaultXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await accountPlan.UpdateAdminApiAccountPlansDefaultXmlById(accessToken, id);

```


#### <a name="update_admin_api_account_plans_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanController.UpdateAdminApiAccountPlansXmlById") UpdateAdminApiAccountPlansXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Updates an account plan.


```csharp
Task<dynamic> UpdateAdminApiAccountPlansXmlById(string accessToken, int id, string name)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;
string name = "name";

dynamic result = await accountPlan.UpdateAdminApiAccountPlansXmlById(accessToken, id, name);

```


#### <a name="create_admin_api_account_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanController.CreateAdminApiAccountPlansXml") CreateAdminApiAccountPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Creates an account plan.


```csharp
Task<dynamic> CreateAdminApiAccountPlansXml(string accessToken, string name, string systemName = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |
| systemName |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
string name = "name";
string systemName = "system_name";

dynamic result = await accountPlan.CreateAdminApiAccountPlansXml(accessToken, name, systemName);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="account_feature_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.AccountFeatureController") AccountFeatureController

#### Get singleton instance

The singleton instance of the ``` AccountFeatureController ``` class can be accessed from the API Client.

```csharp
AccountFeatureController accountFeature = client.AccountFeature;
```

#### <a name="delete_admin_api_features_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountFeatureController.DeleteAdminApiFeaturesXmlById") DeleteAdminApiFeaturesXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Deletes an account feature.


```csharp
Task<dynamic> DeleteAdminApiFeaturesXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await accountFeature.DeleteAdminApiFeaturesXmlById(accessToken, id);

```


#### <a name="get_admin_api_features_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountFeatureController.GetAdminApiFeaturesXmlById") GetAdminApiFeaturesXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Returns an account feature.


```csharp
Task<dynamic> GetAdminApiFeaturesXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;

dynamic result = await accountFeature.GetAdminApiFeaturesXmlById(accessToken, id);

```


#### <a name="get_admin_api_features_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountFeatureController.GetAdminApiFeaturesXml") GetAdminApiFeaturesXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of the features available to accounts. Account features are globally scoped.


```csharp
Task<dynamic> GetAdminApiFeaturesXml(string accessToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";

dynamic result = await accountFeature.GetAdminApiFeaturesXml(accessToken);

```


#### <a name="create_admin_api_features_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountFeatureController.CreateAdminApiFeaturesXml") CreateAdminApiFeaturesXml

> *Tags:*  ``` Skips Authentication ``` 

> Create an account feature. The features of the account are globally scoped. Creating a feature does not associate the feature with an account plan.


```csharp
Task<dynamic> CreateAdminApiFeaturesXml(string accessToken, string name, string systemName = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |
| systemName |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
string name = "name";
string systemName = "system_name";

dynamic result = await accountFeature.CreateAdminApiFeaturesXml(accessToken, name, systemName);

```


#### <a name="update_admin_api_features_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountFeatureController.UpdateAdminApiFeaturesXmlById") UpdateAdminApiFeaturesXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Updates an account feature.


```csharp
Task<dynamic> UpdateAdminApiFeaturesXmlById(string accessToken, int id, string name)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 63;
string name = "name";

dynamic result = await accountFeature.UpdateAdminApiFeaturesXmlById(accessToken, id, name);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="proxy_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ProxyController") ProxyController

#### Get singleton instance

The singleton instance of the ``` ProxyController ``` class can be accessed from the API Client.

```csharp
ProxyController proxy = client.Proxy;
```

#### <a name="update_admin_api_services_proxy_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ProxyController.UpdateAdminApiServicesProxyXmlByServiceId") UpdateAdminApiServicesProxyXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Changes the Proxy settings.


```csharp
Task<dynamic> UpdateAdminApiServicesProxyXmlByServiceId(
        string accessToken,
        int serviceId,
        string endpoint = null,
        string credentialsLocation = null,
        string authAppKey = null,
        string authAppId = null,
        string authUserKey = null,
        string errorAuthFailed = null,
        int? errorStatusAuthFailed = null,
        string errorHeadersAuthFailed = null,
        string errorAuthMissing = null,
        int? errorStatusAuthMissing = null,
        string errorHeadersAuthMissing = null,
        string errorNoMatch = null,
        int? errorStatusNoMatch = null,
        string errorHeadersNoMatch = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| endpoint |  ``` Optional ```  | TODO: Add a parameter description |
| credentialsLocation |  ``` Optional ```  | TODO: Add a parameter description |
| authAppKey |  ``` Optional ```  | TODO: Add a parameter description |
| authAppId |  ``` Optional ```  | TODO: Add a parameter description |
| authUserKey |  ``` Optional ```  | TODO: Add a parameter description |
| errorAuthFailed |  ``` Optional ```  | TODO: Add a parameter description |
| errorStatusAuthFailed |  ``` Optional ```  | TODO: Add a parameter description |
| errorHeadersAuthFailed |  ``` Optional ```  | TODO: Add a parameter description |
| errorAuthMissing |  ``` Optional ```  | TODO: Add a parameter description |
| errorStatusAuthMissing |  ``` Optional ```  | TODO: Add a parameter description |
| errorHeadersAuthMissing |  ``` Optional ```  | TODO: Add a parameter description |
| errorNoMatch |  ``` Optional ```  | TODO: Add a parameter description |
| errorStatusNoMatch |  ``` Optional ```  | TODO: Add a parameter description |
| errorHeadersNoMatch |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 63;
string endpoint = "endpoint";
string credentialsLocation = "credentials_location";
string authAppKey = "auth_app_key";
string authAppId = "auth_app_id";
string authUserKey = "auth_user_key";
string errorAuthFailed = "error_auth_failed";
int? errorStatusAuthFailed = 63;
string errorHeadersAuthFailed = "error_headers_auth_failed";
string errorAuthMissing = "error_auth_missing";
int? errorStatusAuthMissing = 63;
string errorHeadersAuthMissing = "error_headers_auth_missing";
string errorNoMatch = "error_no_match";
int? errorStatusNoMatch = 63;
string errorHeadersNoMatch = "error_headers_no_match";

dynamic result = await proxy.UpdateAdminApiServicesProxyXmlByServiceId(accessToken, serviceId, endpoint, credentialsLocation, authAppKey, authAppId, authUserKey, errorAuthFailed, errorStatusAuthFailed, errorHeadersAuthFailed, errorAuthMissing, errorStatusAuthMissing, errorHeadersAuthMissing, errorNoMatch, errorStatusNoMatch, errorHeadersNoMatch);

```


#### <a name="get_admin_api_services_proxy_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ProxyController.GetAdminApiServicesProxyXmlByServiceId") GetAdminApiServicesProxyXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Returns the Proxy of a Service.


```csharp
Task<dynamic> GetAdminApiServicesProxyXmlByServiceId(string accessToken, int serviceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 63;

dynamic result = await proxy.GetAdminApiServicesProxyXmlByServiceId(accessToken, serviceId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="user_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.UserController") UserController

#### Get singleton instance

The singleton instance of the ``` UserController ``` class can be accessed from the API Client.

```csharp
UserController user = client.User;
```

#### <a name="update_admin_api_accounts_users_xml_by_account_id_and_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserController.UpdateAdminApiAccountsUsersXmlByAccountIdAndId") UpdateAdminApiAccountsUsersXmlByAccountIdAndId

> *Tags:*  ``` Skips Authentication ``` 

> Updates the user of an account. You can update any field, not only those in the form of the ActiveDocs but all the fields that belong to the User object. Remember that you can define custom fields on your Admin Portal.


```csharp
Task<dynamic> UpdateAdminApiAccountsUsersXmlByAccountIdAndId(
        string accessToken,
        int accountId,
        int id,
        string username = null,
        string email = null,
        string password = null,
        object additionalFields = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| username |  ``` Optional ```  | TODO: Add a parameter description |
| email |  ``` Optional ```  | TODO: Add a parameter description |
| password |  ``` Optional ```  | TODO: Add a parameter description |
| additionalFields |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;
string username = "username";
string email = "email";
string password = "password";
object additionalFields = new object();

dynamic result = await user.UpdateAdminApiAccountsUsersXmlByAccountIdAndId(accessToken, accountId, id, username, email, password, additionalFields);

```


#### <a name="create_admin_api_accounts_users_xml_by_account_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserController.CreateAdminApiAccountsUsersXmlByAccountId") CreateAdminApiAccountsUsersXmlByAccountId

> *Tags:*  ``` Skips Authentication ``` 

> Creates a new user of the account (account_id). Do not forget to activate the user otherwise he/she will be unable to sign-in. After creation the default state is pending and the default role is member. The user object can be extended using Fields Definitions in the Admin Portal. You can add/remove fields, for instance token (string), age (int), third name (string optional), etc. 


```csharp
Task<dynamic> CreateAdminApiAccountsUsersXmlByAccountId(
        string accessToken,
        int accountId,
        string username,
        string email,
        string password,
        object additionalFields = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| username |  ``` Required ```  | TODO: Add a parameter description |
| email |  ``` Required ```  | TODO: Add a parameter description |
| password |  ``` Required ```  | TODO: Add a parameter description |
| additionalFields |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
string username = "username";
string email = "email";
string password = "password";
object additionalFields = new object();

dynamic result = await user.CreateAdminApiAccountsUsersXmlByAccountId(accessToken, accountId, username, email, password, additionalFields);

```


#### <a name="update_admin_api_accounts_users_activate_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserController.UpdateAdminApiAccountsUsersActivateXml") UpdateAdminApiAccountsUsersActivateXml

> *Tags:*  ``` Skips Authentication ``` 

> Activate the user of an account. A user is created in the pending state and needs to be activated before he/she is able to sign-in.


```csharp
Task<dynamic> UpdateAdminApiAccountsUsersActivateXml(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await user.UpdateAdminApiAccountsUsersActivateXml(accessToken, accountId, id);

```


#### <a name="update_admin_api_accounts_users_unsuspend_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserController.UpdateAdminApiAccountsUsersUnsuspendXml") UpdateAdminApiAccountsUsersUnsuspendXml

> *Tags:*  ``` Skips Authentication ``` 

> Change the state of the user back to active.


```csharp
Task<dynamic> UpdateAdminApiAccountsUsersUnsuspendXml(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await user.UpdateAdminApiAccountsUsersUnsuspendXml(accessToken, accountId, id);

```


#### <a name="update_admin_api_accounts_users_suspend_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserController.UpdateAdminApiAccountsUsersSuspendXml") UpdateAdminApiAccountsUsersSuspendXml

> *Tags:*  ``` Skips Authentication ``` 

> Changes the state of the user to suspended. A suspended user cannot sign-in.


```csharp
Task<dynamic> UpdateAdminApiAccountsUsersSuspendXml(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await user.UpdateAdminApiAccountsUsersSuspendXml(accessToken, accountId, id);

```


#### <a name="update_admin_api_accounts_users_admin_xml_by_account_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserController.UpdateAdminApiAccountsUsersAdminXmlByAccountId") UpdateAdminApiAccountsUsersAdminXmlByAccountId

> *Tags:*  ``` Skips Authentication ``` 

> Changes the role of the user to admin.


```csharp
Task<dynamic> UpdateAdminApiAccountsUsersAdminXmlByAccountId(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await user.UpdateAdminApiAccountsUsersAdminXmlByAccountId(accessToken, accountId, id);

```


#### <a name="update_admin_api_accounts_users_member_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserController.UpdateAdminApiAccountsUsersMemberXml") UpdateAdminApiAccountsUsersMemberXml

> *Tags:*  ``` Skips Authentication ``` 

> Changes the role of the user to member.


```csharp
Task<dynamic> UpdateAdminApiAccountsUsersMemberXml(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await user.UpdateAdminApiAccountsUsersMemberXml(accessToken, accountId, id);

```


#### <a name="delete_admin_api_accounts_users_xml_by_account_id_and_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserController.DeleteAdminApiAccountsUsersXmlByAccountIdAndId") DeleteAdminApiAccountsUsersXmlByAccountIdAndId

> *Tags:*  ``` Skips Authentication ``` 

> Deletes a user of an account. The last user can't be deleted


```csharp
Task<dynamic> DeleteAdminApiAccountsUsersXmlByAccountIdAndId(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await user.DeleteAdminApiAccountsUsersXmlByAccountIdAndId(accessToken, accountId, id);

```


#### <a name="get_admin_api_accounts_users_xml_by_account_id_and_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserController.GetAdminApiAccountsUsersXmlByAccountIdAndId") GetAdminApiAccountsUsersXmlByAccountIdAndId

> *Tags:*  ``` Skips Authentication ``` 

> Returns the user of an account.


```csharp
Task<dynamic> GetAdminApiAccountsUsersXmlByAccountIdAndId(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await user.GetAdminApiAccountsUsersXmlByAccountIdAndId(accessToken, accountId, id);

```


#### <a name="get_admin_api_accounts_users_xml_by_account_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserController.GetAdminApiAccountsUsersXmlByAccountId") GetAdminApiAccountsUsersXmlByAccountId

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of users of an account. The list can be filtered by the state or role of the users.


```csharp
Task<dynamic> GetAdminApiAccountsUsersXmlByAccountId(
        string accessToken,
        int accountId,
        StateEnum? state = null,
        RoleEnum? role = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| state |  ``` Optional ```  | TODO: Add a parameter description |
| role |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
var state = StateEnum?Helper.ParseString("pending");
var role = RoleEnum?Helper.ParseString("member");

dynamic result = await user.GetAdminApiAccountsUsersXmlByAccountId(accessToken, accountId, state, role);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="application_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController") ApplicationController

#### Get singleton instance

The singleton instance of the ``` ApplicationController ``` class can be accessed from the API Client.

```csharp
ApplicationController application = client.Application;
```

#### <a name="create_admin_api_accounts_applications_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.CreateAdminApiAccountsApplicationsXml") CreateAdminApiAccountsApplicationsXml

> *Tags:*  ``` Skips Authentication ``` 

> Create an application. The application object can be extended with Fields Definitions in the Admin Portal where you can add/remove fields, for instance token (string), age (int), third name (string optional), etc.


```csharp
Task<dynamic> CreateAdminApiAccountsApplicationsXml(
        string accessToken,
        int accountId,
        int planId,
        string name,
        string description,
        string userKey = null,
        string applicationId = null,
        string applicationKey = null,
        object additionalFields = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| planId |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |
| description |  ``` Required ```  | TODO: Add a parameter description |
| userKey |  ``` Optional ```  | TODO: Add a parameter description |
| applicationId |  ``` Optional ```  | TODO: Add a parameter description |
| applicationKey |  ``` Optional ```  | TODO: Add a parameter description |
| additionalFields |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int planId = 63;
string name = "name";
string description = "description";
string userKey = "user_key";
string applicationId = "application_id";
string applicationKey = "application_key";
object additionalFields = new object();

dynamic result = await application.CreateAdminApiAccountsApplicationsXml(accessToken, accountId, planId, name, description, userKey, applicationId, applicationKey, additionalFields);

```


#### <a name="update_admin_api_accounts_applications_resume_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.UpdateAdminApiAccountsApplicationsResumeXml") UpdateAdminApiAccountsApplicationsResumeXml

> *Tags:*  ``` Skips Authentication ``` 

> Resume a suspended application. Once a suspended application is resumed it will be authorized on API requests.


```csharp
Task<dynamic> UpdateAdminApiAccountsApplicationsResumeXml(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await application.UpdateAdminApiAccountsApplicationsResumeXml(accessToken, accountId, id);

```


#### <a name="update_admin_api_accounts_applications_suspend_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.UpdateAdminApiAccountsApplicationsSuspendXml") UpdateAdminApiAccountsApplicationsSuspendXml

> *Tags:*  ``` Skips Authentication ``` 

> Suspends an application (changes the state to suspended). Suspending an application will stop the application from authorizing API requests.


```csharp
Task<dynamic> UpdateAdminApiAccountsApplicationsSuspendXml(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await application.UpdateAdminApiAccountsApplicationsSuspendXml(accessToken, accountId, id);

```


#### <a name="update_admin_api_accounts_applications_accept_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.UpdateAdminApiAccountsApplicationsAcceptXml") UpdateAdminApiAccountsApplicationsAcceptXml

> *Tags:*  ``` Skips Authentication ``` 

> Accepts an application (changes the state to live). Once the state is live the application can be used on API requests.


```csharp
Task<dynamic> UpdateAdminApiAccountsApplicationsAcceptXml(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await application.UpdateAdminApiAccountsApplicationsAcceptXml(accessToken, accountId, id);

```


#### <a name="update_admin_api_accounts_applications_decustomize_plan_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.UpdateAdminApiAccountsApplicationsDecustomizePlanXml") UpdateAdminApiAccountsApplicationsDecustomizePlanXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes the customized application plan of the application. After removing the customization the application will be constrained by the original application plan.


```csharp
Task<dynamic> UpdateAdminApiAccountsApplicationsDecustomizePlanXml(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await application.UpdateAdminApiAccountsApplicationsDecustomizePlanXml(accessToken, accountId, id);

```


#### <a name="update_admin_api_accounts_applications_customize_plan_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.UpdateAdminApiAccountsApplicationsCustomizePlanXml") UpdateAdminApiAccountsApplicationsCustomizePlanXml

> *Tags:*  ``` Skips Authentication ``` 

> Creates a customized application plan for the application.


```csharp
Task<dynamic> UpdateAdminApiAccountsApplicationsCustomizePlanXml(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await application.UpdateAdminApiAccountsApplicationsCustomizePlanXml(accessToken, accountId, id);

```


#### <a name="update_admin_api_accounts_applications_change_plan_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.UpdateAdminApiAccountsApplicationsChangePlanXml") UpdateAdminApiAccountsApplicationsChangePlanXml

> *Tags:*  ``` Skips Authentication ``` 

> Changes the application plan of an application.


```csharp
Task<dynamic> UpdateAdminApiAccountsApplicationsChangePlanXml(
        string accessToken,
        int accountId,
        int id,
        int planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| planId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;
int planId = 63;

dynamic result = await application.UpdateAdminApiAccountsApplicationsChangePlanXml(accessToken, accountId, id, planId);

```


#### <a name="update_admin_api_accounts_applications_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.UpdateAdminApiAccountsApplicationsXml") UpdateAdminApiAccountsApplicationsXml

> *Tags:*  ``` Skips Authentication ``` 

> Updates an application. All fields of the application object can be updated except the id and the app_id (when using OAuth or app_id/app_key authentication pattern).


```csharp
Task<dynamic> UpdateAdminApiAccountsApplicationsXml(
        string accessToken,
        int accountId,
        int id,
        string name = null,
        string description = null,
        object additionalFields = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | TODO: Add a parameter description |
| description |  ``` Optional ```  | TODO: Add a parameter description |
| additionalFields |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;
string name = "name";
string description = "description";
object additionalFields = new object();

dynamic result = await application.UpdateAdminApiAccountsApplicationsXml(accessToken, accountId, id, name, description, additionalFields);

```


#### <a name="get_admin_api_accounts_applications_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.GetAdminApiAccountsApplicationsXml") GetAdminApiAccountsApplicationsXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the application by id.


```csharp
Task<dynamic> GetAdminApiAccountsApplicationsXml(string accessToken, int accountId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int id = 63;

dynamic result = await application.GetAdminApiAccountsApplicationsXml(accessToken, accountId, id);

```


#### <a name="get_admin_api_accounts_applications_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.GetAdminApiAccountsApplicationsXml") GetAdminApiAccountsApplicationsXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of application of an account.


```csharp
Task<dynamic> GetAdminApiAccountsApplicationsXml(string accessToken, int accountId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;

dynamic result = await application.GetAdminApiAccountsApplicationsXml(accessToken, accountId);

```


#### <a name="delete_admin_api_accounts_applications_referrer_filters_id_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.DeleteAdminApiAccountsApplicationsReferrerFiltersIdXml") DeleteAdminApiAccountsApplicationsReferrerFiltersIdXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes a referrer filter of an application. Referrer filters limit API requests by domain or IP ranges.


```csharp
Task<dynamic> DeleteAdminApiAccountsApplicationsReferrerFiltersIdXml(
        string accessToken,
        int accountId,
        int applicationId,
        int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| applicationId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int applicationId = 63;
int id = 63;

dynamic result = await application.DeleteAdminApiAccountsApplicationsReferrerFiltersIdXml(accessToken, accountId, applicationId, id);

```


#### <a name="create_admin_api_accounts_applications_referrer_filters_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.CreateAdminApiAccountsApplicationsReferrerFiltersXml") CreateAdminApiAccountsApplicationsReferrerFiltersXml

> *Tags:*  ``` Skips Authentication ``` 

> Adds a referrer filter to an application. Referrer filters limit API requests by domain or IP ranges.


```csharp
Task<dynamic> CreateAdminApiAccountsApplicationsReferrerFiltersXml(
        string accessToken,
        int accountId,
        int applicationId,
        string referrerFilter)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| applicationId |  ``` Required ```  | TODO: Add a parameter description |
| referrerFilter |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int applicationId = 63;
string referrerFilter = "referrer_filter";

dynamic result = await application.CreateAdminApiAccountsApplicationsReferrerFiltersXml(accessToken, accountId, applicationId, referrerFilter);

```


#### <a name="get_admin_api_accounts_applications_referrer_filters_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.GetAdminApiAccountsApplicationsReferrerFiltersXml") GetAdminApiAccountsApplicationsReferrerFiltersXml

> *Tags:*  ``` Skips Authentication ``` 

> Lists referrer filters of the application.


```csharp
Task<dynamic> GetAdminApiAccountsApplicationsReferrerFiltersXml(string accessToken, int accountId, int applicationId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| applicationId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int applicationId = 63;

dynamic result = await application.GetAdminApiAccountsApplicationsReferrerFiltersXml(accessToken, accountId, applicationId);

```


#### <a name="delete_admin_api_accounts_applications_keys_key_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.DeleteAdminApiAccountsApplicationsKeysKeyXml") DeleteAdminApiAccountsApplicationsKeysKeyXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes a key of an application (valid only on the authentication mode app_id/app_key or oauth). An application may have to have at least one app_key (controlled by settings).


```csharp
Task<dynamic> DeleteAdminApiAccountsApplicationsKeysKeyXml(
        string accessToken,
        int accountId,
        int applicationId,
        string key)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| applicationId |  ``` Required ```  | TODO: Add a parameter description |
| key |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int applicationId = 63;
string key = "key";

dynamic result = await application.DeleteAdminApiAccountsApplicationsKeysKeyXml(accessToken, accountId, applicationId, key);

```


#### <a name="create_key_create"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.CreateKeyCreate") CreateKeyCreate

> *Tags:*  ``` Skips Authentication ``` 

> Adds a key of an application (valid only on the authentication mode app_id/app_key or oauth). There are maximum 5 app_keys per application.


```csharp
Task<dynamic> CreateKeyCreate(
        string accessToken,
        int accountId,
        int applicationId,
        string key)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| applicationId |  ``` Required ```  | TODO: Add a parameter description |
| key |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int applicationId = 63;
string key = "key";

dynamic result = await application.CreateKeyCreate(accessToken, accountId, applicationId, key);

```


#### <a name="get_admin_api_accounts_applications_keys_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.GetAdminApiAccountsApplicationsKeysXml") GetAdminApiAccountsApplicationsKeysXml

> *Tags:*  ``` Skips Authentication ``` 

> Lists app keys of the application.


```csharp
Task<dynamic> GetAdminApiAccountsApplicationsKeysXml(string accessToken, int accountId, int applicationId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| applicationId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountId = 63;
int applicationId = 63;

dynamic result = await application.GetAdminApiAccountsApplicationsKeysXml(accessToken, accountId, applicationId);

```


#### <a name="get_admin_api_applications_find_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.GetAdminApiApplicationsFindXml") GetAdminApiApplicationsFindXml

> *Tags:*  ``` Skips Authentication ``` 

> Finds an application by keys used on the integration of your API and 3scale's Service Management API or by application ID.


```csharp
Task<dynamic> GetAdminApiApplicationsFindXml(
        string accessToken,
        int? applicationId = null,
        string userKey = null,
        string appId = null,
        string serviceId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationId |  ``` Optional ```  | TODO: Add a parameter description |
| userKey |  ``` Optional ```  | TODO: Add a parameter description |
| appId |  ``` Optional ```  | TODO: Add a parameter description |
| serviceId |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int? applicationId = 63;
string userKey = "user_key";
string appId = "app_id";
string serviceId = "service_id";

dynamic result = await application.GetAdminApiApplicationsFindXml(accessToken, applicationId, userKey, appId, serviceId);

```


#### <a name="get_applications"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationController.GetApplications") GetApplications

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of applications across all services. Note that applications are scoped by service and can be paginated.


```csharp
Task<dynamic> GetApplications(
        string accessToken,
        int? page = null,
        int? perPage = null,
        string activeSince = null,
        string inactiveSince = null,
        string serviceId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | TODO: Add a parameter description |
| perPage |  ``` Optional ```  | TODO: Add a parameter description |
| activeSince |  ``` Optional ```  | TODO: Add a parameter description |
| inactiveSince |  ``` Optional ```  | TODO: Add a parameter description |
| serviceId |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int? page = 154;
int? perPage = 154;
string activeSince = "active_since";
string inactiveSince = "inactive_since";
string serviceId = "service_id";

dynamic result = await application.GetApplications(accessToken, page, perPage, activeSince, inactiveSince, serviceId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="webhooks_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.WebhooksController") WebhooksController

#### Get singleton instance

The singleton instance of the ``` WebhooksController ``` class can be accessed from the API Client.

```csharp
WebhooksController webhooks = client.Webhooks;
```

#### <a name="delete_admin_api_webhooks_failures_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.WebhooksController.DeleteAdminApiWebhooksFailuresXml") DeleteAdminApiWebhooksFailuresXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes failed delivery records. It is advisible to delete the records past the time of the last webhook failure that was received instead of deleting them all. Between the GET and the DELETE other webhooks failures may have arrived.


```csharp
Task<dynamic> DeleteAdminApiWebhooksFailuresXml(string accessToken, DateTime? time = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| time |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
DateTime? time = DateTime.Now();

dynamic result = await webhooks.DeleteAdminApiWebhooksFailuresXml(accessToken, time);

```


#### <a name="get_admin_api_webhooks_failures_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.WebhooksController.GetAdminApiWebhooksFailuresXml") GetAdminApiWebhooksFailuresXml

> *Tags:*  ``` Skips Authentication ``` 

> Lists of webhooks that could not be delivered to your end-point after 5 trials. A webhook is considered delivered if your end-point responds with a 200, otherwise it retries 5 times at 60 second intervals.


```csharp
Task<dynamic> GetAdminApiWebhooksFailuresXml(string accessToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";

dynamic result = await webhooks.GetAdminApiWebhooksFailuresXml(accessToken);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="user_provider_account_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController") UserProviderAccountController

#### Get singleton instance

The singleton instance of the ``` UserProviderAccountController ``` class can be accessed from the API Client.

```csharp
UserProviderAccountController userProviderAccount = client.UserProviderAccount;
```

#### <a name="update_admin_api_users_activate_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController.UpdateAdminApiUsersActivateXmlById") UpdateAdminApiUsersActivateXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Changes the state of the user of the provider account to active (after sign-up). You can also perform this operation with a PUT on /admin/api/users/{id}.xml to change the state parameter.


```csharp
Task<dynamic> UpdateAdminApiUsersActivateXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;

dynamic result = await userProviderAccount.UpdateAdminApiUsersActivateXmlById(accessToken, id);

```


#### <a name="update_admin_api_users_unsuspend_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController.UpdateAdminApiUsersUnsuspendXmlById") UpdateAdminApiUsersUnsuspendXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Revokes the suspension of a user of the provider account. You can also perform this operation with a PUT on /admin/api/users/{id}.xml to change the state parameter.


```csharp
Task<dynamic> UpdateAdminApiUsersUnsuspendXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;

dynamic result = await userProviderAccount.UpdateAdminApiUsersUnsuspendXmlById(accessToken, id);

```


#### <a name="update_admin_api_users_suspend_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController.UpdateAdminApiUsersSuspendXmlById") UpdateAdminApiUsersSuspendXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Changes the state of the user of the provider account to suspended, which removes the user's ability to sign-in. You can also perform this operation with a PUT on /admin/api/users/{id}.xml to change the state parameter.


```csharp
Task<dynamic> UpdateAdminApiUsersSuspendXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;

dynamic result = await userProviderAccount.UpdateAdminApiUsersSuspendXmlById(accessToken, id);

```


#### <a name="update_admin_api_users_admin_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController.UpdateAdminApiUsersAdminXmlById") UpdateAdminApiUsersAdminXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Changes the role of the provider account to admin (full rights and privileges).


```csharp
Task<dynamic> UpdateAdminApiUsersAdminXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;

dynamic result = await userProviderAccount.UpdateAdminApiUsersAdminXmlById(accessToken, id);

```


#### <a name="update_admin_api_users_member_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController.UpdateAdminApiUsersMemberXmlById") UpdateAdminApiUsersMemberXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Changes the role of the user of the provider account to member.


```csharp
Task<dynamic> UpdateAdminApiUsersMemberXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;

dynamic result = await userProviderAccount.UpdateAdminApiUsersMemberXmlById(accessToken, id);

```


#### <a name="update_admin_api_users_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController.UpdateAdminApiUsersXmlById") UpdateAdminApiUsersXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Modifies the user of the provider account by ID. You can update any field, not only those in the form of the ActiveDocs but also fields that belong to the User object. Remember that you can define custom fields on your Admin Portal.


```csharp
Task<dynamic> UpdateAdminApiUsersXmlById(
        string accessToken,
        int id,
        string username = null,
        string email = null,
        string password = null,
        object additionalFields = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| username |  ``` Optional ```  | TODO: Add a parameter description |
| email |  ``` Optional ```  | TODO: Add a parameter description |
| password |  ``` Optional ```  | TODO: Add a parameter description |
| additionalFields |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;
string username = "username";
string email = "email";
string password = "password";
object additionalFields = new object();

dynamic result = await userProviderAccount.UpdateAdminApiUsersXmlById(accessToken, id, username, email, password, additionalFields);

```


#### <a name="create_admin_api_users_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController.CreateAdminApiUsersXml") CreateAdminApiUsersXml

> *Tags:*  ``` Skips Authentication ``` 

> Creates a new user in the provider account. Do not forget to activate it, otherwise he/she will not be able to sign-in. After creation the default state is pending and the default role is member. The user object can be extended using Fields Definitions in the Admin Portal where you can add/remove fields, for instance token (string), age (int), third name (string optional), etc.


```csharp
Task<dynamic> CreateAdminApiUsersXml(
        string accessToken,
        string username,
        string email,
        string password,
        object additionalFields = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| username |  ``` Required ```  | TODO: Add a parameter description |
| email |  ``` Required ```  | TODO: Add a parameter description |
| password |  ``` Required ```  | TODO: Add a parameter description |
| additionalFields |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
string username = "username";
string email = "email";
string password = "password";
object additionalFields = new object();

dynamic result = await userProviderAccount.CreateAdminApiUsersXml(accessToken, username, email, password, additionalFields);

```


#### <a name="get_admin_api_users_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController.GetAdminApiUsersXml") GetAdminApiUsersXml

> *Tags:*  ``` Skips Authentication ``` 

> Lists the users of the provider account. You can apply filters by state and/or role.


```csharp
Task<dynamic> GetAdminApiUsersXml(string accessToken, StateEnum? state = null, RoleEnum? role = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| state |  ``` Optional ```  | TODO: Add a parameter description |
| role |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
var state = StateEnum?Helper.ParseString("pending");
var role = RoleEnum?Helper.ParseString("member");

dynamic result = await userProviderAccount.GetAdminApiUsersXml(accessToken, state, role);

```


#### <a name="delete_admin_api_users_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController.DeleteAdminApiUsersXmlById") DeleteAdminApiUsersXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Deletes the user of the provider account by ID.


```csharp
Task<dynamic> DeleteAdminApiUsersXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;

dynamic result = await userProviderAccount.DeleteAdminApiUsersXmlById(accessToken, id);

```


#### <a name="get_admin_api_users_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.UserProviderAccountController.GetAdminApiUsersXmlById") GetAdminApiUsersXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Gets the user of the provider account by ID.


```csharp
Task<dynamic> GetAdminApiUsersXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;

dynamic result = await userProviderAccount.GetAdminApiUsersXmlById(accessToken, id);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="service_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ServiceController") ServiceController

#### Get singleton instance

The singleton instance of the ``` ServiceController ``` class can be accessed from the API Client.

```csharp
ServiceController service = client.Service;
```

#### <a name="update_admin_api_services_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServiceController.UpdateAdminApiServicesXmlById") UpdateAdminApiServicesXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Update the service.


```csharp
Task<dynamic> UpdateAdminApiServicesXmlById(
        string accessToken,
        int id,
        string name = null,
        Dictionary<string, object> queryParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | TODO: Add a parameter description |
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;
string name = "name";
// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


dynamic result = await service.UpdateAdminApiServicesXmlById(accessToken, id, name, queryParams);

```


#### <a name="create_admin_api_services_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServiceController.CreateAdminApiServicesXml") CreateAdminApiServicesXml

> *Tags:*  ``` Skips Authentication ``` 

> Creates a new service.


```csharp
Task<dynamic> CreateAdminApiServicesXml(
        string accessToken,
        string name,
        string systemName = null,
        Dictionary<string, object> queryParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |
| systemName |  ``` Optional ```  | TODO: Add a parameter description |
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |


#### Example Usage

```csharp
string accessToken = "access_token";
string name = "name";
string systemName = "system_name";
// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


dynamic result = await service.CreateAdminApiServicesXml(accessToken, name, systemName, queryParams);

```


#### <a name="get_admin_api_services_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServiceController.GetAdminApiServicesXmlById") GetAdminApiServicesXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Returns the service by id.


```csharp
Task<dynamic> GetAdminApiServicesXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;

dynamic result = await service.GetAdminApiServicesXmlById(accessToken, id);

```


#### <a name="get_admin_api_services_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServiceController.GetAdminApiServicesXml") GetAdminApiServicesXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all services.


```csharp
Task<dynamic> GetAdminApiServicesXml(string accessToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";

dynamic result = await service.GetAdminApiServicesXml(accessToken);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="mapping_rule_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.MappingRuleController") MappingRuleController

#### Get singleton instance

The singleton instance of the ``` MappingRuleController ``` class can be accessed from the API Client.

```csharp
MappingRuleController mappingRule = client.MappingRule;
```

#### <a name="delete_admin_api_services_proxy_mapping_rules_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MappingRuleController.DeleteAdminApiServicesProxyMappingRulesXml") DeleteAdminApiServicesProxyMappingRulesXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes a Proxy Mapping Rule.


```csharp
Task<dynamic> DeleteAdminApiServicesProxyMappingRulesXml(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await mappingRule.DeleteAdminApiServicesProxyMappingRulesXml(accessToken, serviceId, id);

```


#### <a name="update_admin_api_services_proxy_mapping_rules_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MappingRuleController.UpdateAdminApiServicesProxyMappingRulesXml") UpdateAdminApiServicesProxyMappingRulesXml

> *Tags:*  ``` Skips Authentication ``` 

> Creates a Proxy Mapping Rule.


```csharp
Task<dynamic> UpdateAdminApiServicesProxyMappingRulesXml(
        string accessToken,
        int serviceId,
        int id,
        string httpMethod = null,
        string pattern = null,
        int? delta = null,
        int? metricId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| httpMethod |  ``` Optional ```  | TODO: Add a parameter description |
| pattern |  ``` Optional ```  | TODO: Add a parameter description |
| delta |  ``` Optional ```  | TODO: Add a parameter description |
| metricId |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;
string httpMethod = "http_method";
string pattern = "pattern";
int? delta = 154;
int? metricId = 154;

dynamic result = await mappingRule.UpdateAdminApiServicesProxyMappingRulesXml(accessToken, serviceId, id, httpMethod, pattern, delta, metricId);

```


#### <a name="create_admin_api_services_proxy_mapping_rules_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MappingRuleController.CreateAdminApiServicesProxyMappingRulesXml") CreateAdminApiServicesProxyMappingRulesXml

> *Tags:*  ``` Skips Authentication ``` 

> Creates a Proxy Mapping Rule.


```csharp
Task<dynamic> CreateAdminApiServicesProxyMappingRulesXml(
        string accessToken,
        int serviceId,
        string httpMethod,
        string pattern,
        int delta,
        int metricId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| httpMethod |  ``` Required ```  | TODO: Add a parameter description |
| pattern |  ``` Required ```  | TODO: Add a parameter description |
| delta |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
string httpMethod = "http_method";
string pattern = "pattern";
int delta = 154;
int metricId = 154;

dynamic result = await mappingRule.CreateAdminApiServicesProxyMappingRulesXml(accessToken, serviceId, httpMethod, pattern, delta, metricId);

```


#### <a name="get_admin_api_services_proxy_mapping_rules_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MappingRuleController.GetAdminApiServicesProxyMappingRulesXml") GetAdminApiServicesProxyMappingRulesXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the Mapping Rule.


```csharp
Task<dynamic> GetAdminApiServicesProxyMappingRulesXml(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await mappingRule.GetAdminApiServicesProxyMappingRulesXml(accessToken, serviceId, id);

```


#### <a name="get_admin_api_services_proxy_mapping_rules_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MappingRuleController.GetAdminApiServicesProxyMappingRulesXml") GetAdminApiServicesProxyMappingRulesXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the Mapping Rules of a Proxy.


```csharp
Task<dynamic> GetAdminApiServicesProxyMappingRulesXml(string accessToken, int serviceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;

dynamic result = await mappingRule.GetAdminApiServicesProxyMappingRulesXml(accessToken, serviceId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="end_user_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.EndUserController") EndUserController

#### Get singleton instance

The singleton instance of the ``` EndUserController ``` class can be accessed from the API Client.

```csharp
EndUserController endUser = client.EndUser;
```

#### <a name="update_admin_api_services_end_users_change_plan_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserController.UpdateAdminApiServicesEndUsersChangePlanXml") UpdateAdminApiServicesEndUsersChangePlanXml

> *Tags:*  ``` Skips Authentication ``` 

> Changes the end user plan of an end user.


```csharp
Task<dynamic> UpdateAdminApiServicesEndUsersChangePlanXml(
        string accessToken,
        int serviceId,
        string username,
        int planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| username |  ``` Required ```  | TODO: Add a parameter description |
| planId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
string username = "username";
int planId = 154;

dynamic result = await endUser.UpdateAdminApiServicesEndUsersChangePlanXml(accessToken, serviceId, username, planId);

```


#### <a name="delete_admin_api_services_end_users_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserController.DeleteAdminApiServicesEndUsersXmlByServiceId") DeleteAdminApiServicesEndUsersXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Deletes an end user.


```csharp
Task<dynamic> DeleteAdminApiServicesEndUsersXmlByServiceId(string accessToken, int serviceId, string username)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| username |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
string username = "username";

dynamic result = await endUser.DeleteAdminApiServicesEndUsersXmlByServiceId(accessToken, serviceId, username);

```


#### <a name="create_admin_api_services_end_users_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserController.CreateAdminApiServicesEndUsersXmlByServiceId") CreateAdminApiServicesEndUsersXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Create an end user.


```csharp
Task<dynamic> CreateAdminApiServicesEndUsersXmlByServiceId(
        string accessToken,
        int serviceId,
        string username,
        int? planId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| username |  ``` Required ```  | TODO: Add a parameter description |
| planId |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
string username = "username";
int? planId = 154;

dynamic result = await endUser.CreateAdminApiServicesEndUsersXmlByServiceId(accessToken, serviceId, username, planId);

```


#### <a name="get_admin_api_services_end_users_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserController.GetAdminApiServicesEndUsersXmlByServiceId") GetAdminApiServicesEndUsersXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Returns the end user by ID.


```csharp
Task<dynamic> GetAdminApiServicesEndUsersXmlByServiceId(string accessToken, int serviceId, string username)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| username |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
string username = "username";

dynamic result = await endUser.GetAdminApiServicesEndUsersXmlByServiceId(accessToken, serviceId, username);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="end_user_plan_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanController") EndUserPlanController

#### Get singleton instance

The singleton instance of the ``` EndUserPlanController ``` class can be accessed from the API Client.

```csharp
EndUserPlanController endUserPlan = client.EndUserPlan;
```

#### <a name="update_admin_api_services_end_user_plans_default_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanController.UpdateAdminApiServicesEndUserPlansDefaultXml") UpdateAdminApiServicesEndUserPlansDefaultXml

> *Tags:*  ``` Skips Authentication ``` 

> Makes the end user plan the default one. New end users will be assigned to the default plan unless an end_user_plan_id is explicity passed on end user creation.


```csharp
Task<dynamic> UpdateAdminApiServicesEndUserPlansDefaultXml(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await endUserPlan.UpdateAdminApiServicesEndUserPlansDefaultXml(accessToken, serviceId, id);

```


#### <a name="update_admin_api_services_end_user_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanController.UpdateAdminApiServicesEndUserPlansXml") UpdateAdminApiServicesEndUserPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Updates an end user plan.


```csharp
Task<dynamic> UpdateAdminApiServicesEndUserPlansXml(
        string accessToken,
        int serviceId,
        int id,
        string name)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;
string name = "name";

dynamic result = await endUserPlan.UpdateAdminApiServicesEndUserPlansXml(accessToken, serviceId, id, name);

```


#### <a name="get_admin_api_services_end_user_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanController.GetAdminApiServicesEndUserPlansXml") GetAdminApiServicesEndUserPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns an end user plan.


```csharp
Task<dynamic> GetAdminApiServicesEndUserPlansXml(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await endUserPlan.GetAdminApiServicesEndUserPlansXml(accessToken, serviceId, id);

```


#### <a name="create_admin_api_services_end_user_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanController.CreateAdminApiServicesEndUserPlansXml") CreateAdminApiServicesEndUserPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Creates an end user plan.


```csharp
Task<dynamic> CreateAdminApiServicesEndUserPlansXml(string accessToken, int serviceId, string name)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
string name = "name";

dynamic result = await endUserPlan.CreateAdminApiServicesEndUserPlansXml(accessToken, serviceId, name);

```


#### <a name="get_admin_api_services_end_user_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanController.GetAdminApiServicesEndUserPlansXml") GetAdminApiServicesEndUserPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all end user plans of a service.


```csharp
Task<dynamic> GetAdminApiServicesEndUserPlansXml(string accessToken, int serviceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;

dynamic result = await endUserPlan.GetAdminApiServicesEndUserPlansXml(accessToken, serviceId);

```


#### <a name="get_admin_api_end_user_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanController.GetAdminApiEndUserPlansXml") GetAdminApiEndUserPlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all end user plans across services. Note that end user plans are scoped by service.


```csharp
Task<dynamic> GetAdminApiEndUserPlansXml(string accessToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";

dynamic result = await endUserPlan.GetAdminApiEndUserPlansXml(accessToken);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="service_plan_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanController") ServicePlanController

#### Get singleton instance

The singleton instance of the ``` ServicePlanController ``` class can be accessed from the API Client.

```csharp
ServicePlanController servicePlan = client.ServicePlan;
```

#### <a name="update_admin_api_services_service_plans_default_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanController.UpdateAdminApiServicesServicePlansDefaultXml") UpdateAdminApiServicesServicePlansDefaultXml

> *Tags:*  ``` Skips Authentication ``` 

> Sets the service plan as default. The default service plan is used when no explicit service plan is used.


```csharp
Task<dynamic> UpdateAdminApiServicesServicePlansDefaultXml(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await servicePlan.UpdateAdminApiServicesServicePlansDefaultXml(accessToken, serviceId, id);

```


#### <a name="delete_admin_api_services_service_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanController.DeleteAdminApiServicesServicePlansXml") DeleteAdminApiServicesServicePlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes a service plan by ID.


```csharp
Task<dynamic> DeleteAdminApiServicesServicePlansXml(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await servicePlan.DeleteAdminApiServicesServicePlansXml(accessToken, serviceId, id);

```


#### <a name="update_admin_api_services_service_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanController.UpdateAdminApiServicesServicePlansXml") UpdateAdminApiServicesServicePlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Updates a service plan by ID.


```csharp
Task<dynamic> UpdateAdminApiServicesServicePlansXml(
        string accessToken,
        int serviceId,
        int id,
        string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;
string name = "name";

dynamic result = await servicePlan.UpdateAdminApiServicesServicePlansXml(accessToken, serviceId, id, name);

```


#### <a name="get_admin_api_services_service_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanController.GetAdminApiServicesServicePlansXml") GetAdminApiServicesServicePlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns a service plan by ID.


```csharp
Task<dynamic> GetAdminApiServicesServicePlansXml(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await servicePlan.GetAdminApiServicesServicePlansXml(accessToken, serviceId, id);

```


#### <a name="create_admin_api_services_service_plans_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanController.CreateAdminApiServicesServicePlansXmlById") CreateAdminApiServicesServicePlansXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Creates a new service plan in a service.


```csharp
Task<dynamic> CreateAdminApiServicesServicePlansXmlById(
        string accessToken,
        int id,
        string name,
        string systemName = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |
| systemName |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;
string name = "name";
string systemName = "system_name";

dynamic result = await servicePlan.CreateAdminApiServicesServicePlansXmlById(accessToken, id, name, systemName);

```


#### <a name="get_admin_api_services_service_plans_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanController.GetAdminApiServicesServicePlansXmlById") GetAdminApiServicesServicePlansXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Returns a list of all service plans for a service.


```csharp
Task<dynamic> GetAdminApiServicesServicePlansXmlById(string accessToken, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 154;

dynamic result = await servicePlan.GetAdminApiServicesServicePlansXmlById(accessToken, id);

```


#### <a name="get_admin_api_service_plans_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanController.GetAdminApiServicePlansXml") GetAdminApiServicePlansXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns a list of all service plans for all services. Note that service plans are scoped by service.


```csharp
Task<dynamic> GetAdminApiServicePlansXml(string accessToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";

dynamic result = await servicePlan.GetAdminApiServicePlansXml(accessToken);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="service_plan_feature_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanFeatureController") ServicePlanFeatureController

#### Get singleton instance

The singleton instance of the ``` ServicePlanFeatureController ``` class can be accessed from the API Client.

```csharp
ServicePlanFeatureController servicePlanFeature = client.ServicePlanFeature;
```

#### <a name="create_admin_api_service_plans_features_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanFeatureController.CreateAdminApiServicePlansFeaturesXml") CreateAdminApiServicePlansFeaturesXml

> *Tags:*  ``` Skips Authentication ``` 

> Associates an existing feature to a service plan.


```csharp
Task<dynamic> CreateAdminApiServicePlansFeaturesXml(string accessToken, int servicePlanId, int featureId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| servicePlanId |  ``` Required ```  | TODO: Add a parameter description |
| featureId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int servicePlanId = 154;
int featureId = 154;

dynamic result = await servicePlanFeature.CreateAdminApiServicePlansFeaturesXml(accessToken, servicePlanId, featureId);

```


#### <a name="get_admin_api_service_plans_features_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServicePlanFeatureController.GetAdminApiServicePlansFeaturesXml") GetAdminApiServicePlansFeaturesXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of features of a service plan.


```csharp
Task<dynamic> GetAdminApiServicePlansFeaturesXml(string accessToken, int servicePlanId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| servicePlanId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int servicePlanId = 154;

dynamic result = await servicePlanFeature.GetAdminApiServicePlansFeaturesXml(accessToken, servicePlanId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="service_feature_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ServiceFeatureController") ServiceFeatureController

#### Get singleton instance

The singleton instance of the ``` ServiceFeatureController ``` class can be accessed from the API Client.

```csharp
ServiceFeatureController serviceFeature = client.ServiceFeature;
```

#### <a name="delete_admin_api_services_features_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServiceFeatureController.DeleteAdminApiServicesFeaturesXmlByServiceId") DeleteAdminApiServicesFeaturesXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Deletes a feature of a service.


```csharp
Task<dynamic> DeleteAdminApiServicesFeaturesXmlByServiceId(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await serviceFeature.DeleteAdminApiServicesFeaturesXmlByServiceId(accessToken, serviceId, id);

```


#### <a name="update_admin_api_services_features_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServiceFeatureController.UpdateAdminApiServicesFeaturesXmlByServiceId") UpdateAdminApiServicesFeaturesXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Updates a feature of a service.


```csharp
Task<dynamic> UpdateAdminApiServicesFeaturesXmlByServiceId(
        string accessToken,
        int serviceId,
        int id,
        string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;
string name = "name";

dynamic result = await serviceFeature.UpdateAdminApiServicesFeaturesXmlByServiceId(accessToken, serviceId, id, name);

```


#### <a name="get_admin_api_services_features_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServiceFeatureController.GetAdminApiServicesFeaturesXmlByServiceId") GetAdminApiServicesFeaturesXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Returns a feature of a service.


```csharp
Task<dynamic> GetAdminApiServicesFeaturesXmlByServiceId(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await serviceFeature.GetAdminApiServicesFeaturesXmlByServiceId(accessToken, serviceId, id);

```


#### <a name="create_admin_api_services_features_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServiceFeatureController.CreateAdminApiServicesFeaturesXmlByServiceId") CreateAdminApiServicesFeaturesXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Creates a feature on a service. Features are usually associated to a particular type of plan; you can associate the plan on the scope parameter. Note that account plans are not scoped by service.


```csharp
Task<dynamic> CreateAdminApiServicesFeaturesXmlByServiceId(
        string accessToken,
        int serviceId,
        string name,
        string systemName = null,
        ScopeEnum? scope = ScopeEnum.APPLICATIONPLAN)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Required ```  | TODO: Add a parameter description |
| systemName |  ``` Optional ```  | TODO: Add a parameter description |
| scope |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
string name = "name";
string systemName = "system_name";
var scope = ScopeEnum?Helper.ParseString("ApplicationPlan");

dynamic result = await serviceFeature.CreateAdminApiServicesFeaturesXmlByServiceId(accessToken, serviceId, name, systemName, scope);

```


#### <a name="get_admin_api_services_features_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ServiceFeatureController.GetAdminApiServicesFeaturesXmlByServiceId") GetAdminApiServicesFeaturesXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all features of a service.


```csharp
Task<dynamic> GetAdminApiServicesFeaturesXmlByServiceId(string accessToken, int serviceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;

dynamic result = await serviceFeature.GetAdminApiServicesFeaturesXmlByServiceId(accessToken, serviceId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="metric_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.MetricController") MetricController

#### Get singleton instance

The singleton instance of the ``` MetricController ``` class can be accessed from the API Client.

```csharp
MetricController metric = client.Metric;
```

#### <a name="delete_admin_api_services_metrics_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MetricController.DeleteAdminApiServicesMetricsXmlByServiceId") DeleteAdminApiServicesMetricsXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Deletes the metric of a service. When you delete a metric or a method, it will also remove all the associated limits across application plans.


```csharp
Task<dynamic> DeleteAdminApiServicesMetricsXmlByServiceId(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await metric.DeleteAdminApiServicesMetricsXmlByServiceId(accessToken, serviceId, id);

```


#### <a name="update_admin_api_services_metrics_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MetricController.UpdateAdminApiServicesMetricsXmlByServiceId") UpdateAdminApiServicesMetricsXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Updates the metric of a service.


```csharp
Task<dynamic> UpdateAdminApiServicesMetricsXmlByServiceId(
        string accessToken,
        int serviceId,
        int id,
        string friendlyName = null,
        string unit = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| friendlyName |  ``` Optional ```  | TODO: Add a parameter description |
| unit |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;
string friendlyName = "friendly_name";
string unit = "unit";

dynamic result = await metric.UpdateAdminApiServicesMetricsXmlByServiceId(accessToken, serviceId, id, friendlyName, unit);

```


#### <a name="get_service_metric"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MetricController.GetServiceMetric") GetServiceMetric

> *Tags:*  ``` Skips Authentication ``` 

> Returns the metric of a service.


```csharp
Task<dynamic> GetServiceMetric(string accessToken, int serviceId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int id = 154;

dynamic result = await metric.GetServiceMetric(accessToken, serviceId, id);

```


#### <a name="create_admin_api_services_metrics_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MetricController.CreateAdminApiServicesMetricsXmlByServiceId") CreateAdminApiServicesMetricsXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Creates a metric on a service. All metrics are scoped by service.


```csharp
Task<dynamic> CreateAdminApiServicesMetricsXmlByServiceId(
        string accessToken,
        int serviceId,
        string friendlyName,
        string unit,
        string systemName = null,
        string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| friendlyName |  ``` Required ```  | TODO: Add a parameter description |
| unit |  ``` Required ```  | TODO: Add a parameter description |
| systemName |  ``` Optional ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
string friendlyName = "friendly_name";
string unit = "unit";
string systemName = "system_name";
string name = "name";

dynamic result = await metric.CreateAdminApiServicesMetricsXmlByServiceId(accessToken, serviceId, friendlyName, unit, systemName, name);

```


#### <a name="get_admin_api_services_metrics_xml_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MetricController.GetAdminApiServicesMetricsXmlByServiceId") GetAdminApiServicesMetricsXmlByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of metrics of a service.


```csharp
Task<dynamic> GetAdminApiServicesMetricsXmlByServiceId(string accessToken, int serviceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;

dynamic result = await metric.GetAdminApiServicesMetricsXmlByServiceId(accessToken, serviceId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="metric_method_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.MetricMethodController") MetricMethodController

#### Get singleton instance

The singleton instance of the ``` MetricMethodController ``` class can be accessed from the API Client.

```csharp
MetricMethodController metricMethod = client.MetricMethod;
```

#### <a name="delete_admin_api_services_metrics_methods_id_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MetricMethodController.DeleteAdminApiServicesMetricsMethodsIdXml") DeleteAdminApiServicesMetricsMethodsIdXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes the method of a metric.


```csharp
Task<dynamic> DeleteAdminApiServicesMetricsMethodsIdXml(
        string accessToken,
        int serviceId,
        int metricId,
        int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int metricId = 154;
int id = 154;

dynamic result = await metricMethod.DeleteAdminApiServicesMetricsMethodsIdXml(accessToken, serviceId, metricId, id);

```


#### <a name="update_admin_api_services_metrics_methods_id_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MetricMethodController.UpdateAdminApiServicesMetricsMethodsIdXml") UpdateAdminApiServicesMetricsMethodsIdXml

> *Tags:*  ``` Skips Authentication ``` 

> Updates a method of a metric.


```csharp
Task<dynamic> UpdateAdminApiServicesMetricsMethodsIdXml(
        string accessToken,
        int serviceId,
        int metricId,
        int id,
        string friendlyName = null,
        string unit = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| friendlyName |  ``` Optional ```  | TODO: Add a parameter description |
| unit |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int metricId = 154;
int id = 154;
string friendlyName = "friendly_name";
string unit = "unit";

dynamic result = await metricMethod.UpdateAdminApiServicesMetricsMethodsIdXml(accessToken, serviceId, metricId, id, friendlyName, unit);

```


#### <a name="get_admin_api_services_metrics_methods_id_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MetricMethodController.GetAdminApiServicesMetricsMethodsIdXml") GetAdminApiServicesMetricsMethodsIdXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the method of a metric.


```csharp
Task<dynamic> GetAdminApiServicesMetricsMethodsIdXml(
        string accessToken,
        int serviceId,
        int metricId,
        int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int metricId = 154;
int id = 154;

dynamic result = await metricMethod.GetAdminApiServicesMetricsMethodsIdXml(accessToken, serviceId, metricId, id);

```


#### <a name="create_admin_api_services_metrics_methods_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MetricMethodController.CreateAdminApiServicesMetricsMethodsXml") CreateAdminApiServicesMetricsMethodsXml

> *Tags:*  ``` Skips Authentication ``` 

> Creates a method under a metric.


```csharp
Task<dynamic> CreateAdminApiServicesMetricsMethodsXml(
        string accessToken,
        int serviceId,
        int metricId,
        string friendlyName,
        string unit,
        string systemName = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| friendlyName |  ``` Required ```  | TODO: Add a parameter description |
| unit |  ``` Required ```  | TODO: Add a parameter description |
| systemName |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int metricId = 154;
string friendlyName = "friendly_name";
string unit = "unit";
string systemName = "system_name";

dynamic result = await metricMethod.CreateAdminApiServicesMetricsMethodsXml(accessToken, serviceId, metricId, friendlyName, unit, systemName);

```


#### <a name="get_admin_api_services_metrics_methods_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.MetricMethodController.GetAdminApiServicesMetricsMethodsXml") GetAdminApiServicesMetricsMethodsXml

> *Tags:*  ``` Skips Authentication ``` 

> List the methods of a metric. Methods are metrics that are children of a parent metric.


```csharp
Task<dynamic> GetAdminApiServicesMetricsMethodsXml(string accessToken, int serviceId, int metricId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int serviceId = 154;
int metricId = 154;

dynamic result = await metricMethod.GetAdminApiServicesMetricsMethodsXml(accessToken, serviceId, metricId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="end_user_plan_limit_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanLimitController") EndUserPlanLimitController

#### Get singleton instance

The singleton instance of the ``` EndUserPlanLimitController ``` class can be accessed from the API Client.

```csharp
EndUserPlanLimitController endUserPlanLimit = client.EndUserPlanLimit;
```

#### <a name="delete_admin_api_end_user_plans_metrics_limits_id_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanLimitController.DeleteAdminApiEndUserPlansMetricsLimitsIdXml") DeleteAdminApiEndUserPlansMetricsLimitsIdXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes a limit on a metric of an end user plan.


```csharp
Task<dynamic> DeleteAdminApiEndUserPlansMetricsLimitsIdXml(
        string accessToken,
        int endUserPlanId,
        int metricId,
        int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| endUserPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int endUserPlanId = 154;
int metricId = 154;
int id = 154;

dynamic result = await endUserPlanLimit.DeleteAdminApiEndUserPlansMetricsLimitsIdXml(accessToken, endUserPlanId, metricId, id);

```


#### <a name="update_admin_api_end_user_plans_metrics_limits_id_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanLimitController.UpdateAdminApiEndUserPlansMetricsLimitsIdXml") UpdateAdminApiEndUserPlansMetricsLimitsIdXml

> *Tags:*  ``` Skips Authentication ``` 

> Updates a limit on a metric of an end user plan.


```csharp
Task<dynamic> UpdateAdminApiEndUserPlansMetricsLimitsIdXml(
        string accessToken,
        int endUserPlanId,
        int metricId,
        int id,
        PeriodEnum period,
        int? mvalue = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| endUserPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| period |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| mvalue |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int endUserPlanId = 154;
int metricId = 154;
int id = 154;
var period = PeriodEnumHelper.ParseString("minute");
int? mvalue = 154;

dynamic result = await endUserPlanLimit.UpdateAdminApiEndUserPlansMetricsLimitsIdXml(accessToken, endUserPlanId, metricId, id, period, mvalue);

```


#### <a name="get_admin_api_end_user_plans_metrics_limits_id_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanLimitController.GetAdminApiEndUserPlansMetricsLimitsIdXml") GetAdminApiEndUserPlansMetricsLimitsIdXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns a limit on a metric of an end user plan.


```csharp
Task<dynamic> GetAdminApiEndUserPlansMetricsLimitsIdXml(
        string accessToken,
        int endUserPlanId,
        int metricId,
        int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| endUserPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int endUserPlanId = 154;
int metricId = 154;
int id = 154;

dynamic result = await endUserPlanLimit.GetAdminApiEndUserPlansMetricsLimitsIdXml(accessToken, endUserPlanId, metricId, id);

```


#### <a name="create_admin_api_end_user_plans_metrics_limits_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanLimitController.CreateAdminApiEndUserPlansMetricsLimitsXml") CreateAdminApiEndUserPlansMetricsLimitsXml

> *Tags:*  ``` Skips Authentication ``` 

> Adds a limit to a metric of an end user plan. All end users with the end user plan (end_user_plan_id) will be constrained by this new limit on the metric (metric_id).


```csharp
Task<dynamic> CreateAdminApiEndUserPlansMetricsLimitsXml(
        string accessToken,
        int endUserPlanId,
        int metricId,
        PeriodEnum period,
        int mvalue)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| endUserPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| period |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| mvalue |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int endUserPlanId = 154;
int metricId = 154;
var period = PeriodEnumHelper.ParseString("minute");
int mvalue = 154;

dynamic result = await endUserPlanLimit.CreateAdminApiEndUserPlansMetricsLimitsXml(accessToken, endUserPlanId, metricId, period, mvalue);

```


#### <a name="get_limits"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.EndUserPlanLimitController.GetLimits") GetLimits

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all limits associated to a metric of an end user plan.


```csharp
Task<dynamic> GetLimits(string accessToken, int endUserPlanId, int metricId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| endUserPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int endUserPlanId = 154;
int metricId = 154;

dynamic result = await endUserPlanLimit.GetLimits(accessToken, endUserPlanId, metricId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="application_plan_pricing_rules_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanPricingRulesController") ApplicationPlanPricingRulesController

#### Get singleton instance

The singleton instance of the ``` ApplicationPlanPricingRulesController ``` class can be accessed from the API Client.

```csharp
ApplicationPlanPricingRulesController applicationPlanPricingRules = client.ApplicationPlanPricingRules;
```

#### <a name="get_pricing_rules"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanPricingRulesController.GetPricingRules") GetPricingRules

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all pricing rules associated to an application plan.


```csharp
Task<dynamic> GetPricingRules(string accessToken, int applicationPlanId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;

dynamic result = await applicationPlanPricingRules.GetPricingRules(accessToken, applicationPlanId);

```


#### <a name="create_admin_api_application_plans_metrics_pricing_rules_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanPricingRulesController.CreateAdminApiApplicationPlansMetricsPricingRulesXml") CreateAdminApiApplicationPlansMetricsPricingRulesXml

> *Tags:*  ``` Skips Authentication ``` 

> Creates a pricing rule for an associated application plan.


```csharp
Task<dynamic> CreateAdminApiApplicationPlansMetricsPricingRulesXml(
        string accessToken,
        int applicationPlanId,
        int metricId,
        int? min = null,
        int? max = null,
        int? costPerUnit = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| min |  ``` Optional ```  | TODO: Add a parameter description |
| max |  ``` Optional ```  | TODO: Add a parameter description |
| costPerUnit |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;
int metricId = 246;
int? min = 246;
int? max = 246;
int? costPerUnit = 246;

dynamic result = await applicationPlanPricingRules.CreateAdminApiApplicationPlansMetricsPricingRulesXml(accessToken, applicationPlanId, metricId, min, max, costPerUnit);

```


#### <a name="get_metric_pricing_rules"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanPricingRulesController.GetMetricPricingRules") GetMetricPricingRules

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all pricing rules associated to a metric of an application plan.


```csharp
Task<dynamic> GetMetricPricingRules(string accessToken, int applicationPlanId, int metricId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;
int metricId = 246;

dynamic result = await applicationPlanPricingRules.GetMetricPricingRules(accessToken, applicationPlanId, metricId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="application_plan_limit_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanLimitController") ApplicationPlanLimitController

#### Get singleton instance

The singleton instance of the ``` ApplicationPlanLimitController ``` class can be accessed from the API Client.

```csharp
ApplicationPlanLimitController applicationPlanLimit = client.ApplicationPlanLimit;
```

#### <a name="delete_admin_api_application_plans_metrics_limits_id_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanLimitController.DeleteAdminApiApplicationPlansMetricsLimitsIdXml") DeleteAdminApiApplicationPlansMetricsLimitsIdXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes a limit on a metric of an application plan.


```csharp
Task<dynamic> DeleteAdminApiApplicationPlansMetricsLimitsIdXml(
        string accessToken,
        int applicationPlanId,
        int metricId,
        int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;
int metricId = 246;
int id = 246;

dynamic result = await applicationPlanLimit.DeleteAdminApiApplicationPlansMetricsLimitsIdXml(accessToken, applicationPlanId, metricId, id);

```


#### <a name="update_admin_api_application_plans_metrics_limits_id_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanLimitController.UpdateAdminApiApplicationPlansMetricsLimitsIdXml") UpdateAdminApiApplicationPlansMetricsLimitsIdXml

> *Tags:*  ``` Skips Authentication ``` 

> Updates a limit on a metric of an application plan.


```csharp
Task<dynamic> UpdateAdminApiApplicationPlansMetricsLimitsIdXml(
        string accessToken,
        int applicationPlanId,
        int metricId,
        int id,
        PeriodEnum period,
        int? mvalue = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| period |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| mvalue |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;
int metricId = 246;
int id = 246;
var period = PeriodEnumHelper.ParseString("minute");
int? mvalue = 246;

dynamic result = await applicationPlanLimit.UpdateAdminApiApplicationPlansMetricsLimitsIdXml(accessToken, applicationPlanId, metricId, id, period, mvalue);

```


#### <a name="get_admin_api_application_plans_metrics_limits_id_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanLimitController.GetAdminApiApplicationPlansMetricsLimitsIdXml") GetAdminApiApplicationPlansMetricsLimitsIdXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns a limit on a metric of an application plan.


```csharp
Task<dynamic> GetAdminApiApplicationPlansMetricsLimitsIdXml(
        string accessToken,
        int applicationPlanId,
        int metricId,
        int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;
int metricId = 246;
int id = 246;

dynamic result = await applicationPlanLimit.GetAdminApiApplicationPlansMetricsLimitsIdXml(accessToken, applicationPlanId, metricId, id);

```


#### <a name="create_admin_api_application_plans_metrics_limits_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanLimitController.CreateAdminApiApplicationPlansMetricsLimitsXml") CreateAdminApiApplicationPlansMetricsLimitsXml

> *Tags:*  ``` Skips Authentication ``` 

> Adds a limit to a metric of an application plan. All applications with the application plan (application_plan_id) will be constrained by this new limit on the metric (metric_id).


```csharp
Task<dynamic> CreateAdminApiApplicationPlansMetricsLimitsXml(
        string accessToken,
        int applicationPlanId,
        int metricId,
        PeriodEnum period,
        int mvalue)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |
| period |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| mvalue |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;
int metricId = 246;
var period = PeriodEnumHelper.ParseString("minute");
int mvalue = 246;

dynamic result = await applicationPlanLimit.CreateAdminApiApplicationPlansMetricsLimitsXml(accessToken, applicationPlanId, metricId, period, mvalue);

```


#### <a name="get_limits"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanLimitController.GetLimits") GetLimits

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all limits associated to a metric of an application plan.


```csharp
Task<dynamic> GetLimits(string accessToken, int applicationPlanId, int metricId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |
| metricId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;
int metricId = 246;

dynamic result = await applicationPlanLimit.GetLimits(accessToken, applicationPlanId, metricId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="application_plan_limits_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanLimitsController") ApplicationPlanLimitsController

#### Get singleton instance

The singleton instance of the ``` ApplicationPlanLimitsController ``` class can be accessed from the API Client.

```csharp
ApplicationPlanLimitsController applicationPlanLimits = client.ApplicationPlanLimits;
```

#### <a name="get_plan_limits"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanLimitsController.GetPlanLimits") GetPlanLimits

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of all limits associated to an application plan.


```csharp
Task<dynamic> GetPlanLimits(string accessToken, int applicationPlanId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;

dynamic result = await applicationPlanLimits.GetPlanLimits(accessToken, applicationPlanId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="application_plan_feature_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanFeatureController") ApplicationPlanFeatureController

#### Get singleton instance

The singleton instance of the ``` ApplicationPlanFeatureController ``` class can be accessed from the API Client.

```csharp
ApplicationPlanFeatureController applicationPlanFeature = client.ApplicationPlanFeature;
```

#### <a name="delete_admin_api_application_plans_features_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanFeatureController.DeleteAdminApiApplicationPlansFeaturesXml") DeleteAdminApiApplicationPlansFeaturesXml

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add a method description


```csharp
Task<dynamic> DeleteAdminApiApplicationPlansFeaturesXml(string accessToken, int applicationPlanId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;
int id = 246;

dynamic result = await applicationPlanFeature.DeleteAdminApiApplicationPlansFeaturesXml(accessToken, applicationPlanId, id);

```


#### <a name="create_admin_api_application_plans_features_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanFeatureController.CreateAdminApiApplicationPlansFeaturesXml") CreateAdminApiApplicationPlansFeaturesXml

> *Tags:*  ``` Skips Authentication ``` 

> Associates a feature to an application plan.


```csharp
Task<dynamic> CreateAdminApiApplicationPlansFeaturesXml(string accessToken, int applicationPlanId, int featureId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |
| featureId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;
int featureId = 246;

dynamic result = await applicationPlanFeature.CreateAdminApiApplicationPlansFeaturesXml(accessToken, applicationPlanId, featureId);

```


#### <a name="get_admin_api_application_plans_features_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ApplicationPlanFeatureController.GetAdminApiApplicationPlansFeaturesXml") GetAdminApiApplicationPlansFeaturesXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of features of the application plan.


```csharp
Task<dynamic> GetAdminApiApplicationPlansFeaturesXml(string accessToken, int applicationPlanId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationPlanId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int applicationPlanId = 246;

dynamic result = await applicationPlanFeature.GetAdminApiApplicationPlansFeaturesXml(accessToken, applicationPlanId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="active_docs_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.ActiveDocsController") ActiveDocsController

#### Get singleton instance

The singleton instance of the ``` ActiveDocsController ``` class can be accessed from the API Client.

```csharp
ActiveDocsController activeDocs = client.ActiveDocs;
```

#### <a name="update_admin_api_active_docs_xml_by_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.ActiveDocsController.UpdateAdminApiActiveDocsXmlById") UpdateAdminApiActiveDocsXmlById

> *Tags:*  ``` Skips Authentication ``` 

> Updates the JSON spec of the ActiveDoc by ID. To create, delete and update the description and state of ActiveDocs you must use the Admin Portal. This request only allows to update the JSON spec (body), which is useful when the JSON spec is generated programmatically (for instance using source2swagger). Once you have the JSON spec you can upload it so it can be live immediately, for instance: 'curl -v -X PUT -F "body= YOUR_JSON_SPEC_FILE" https://YOUR-API_PORTAL.3scale.net/admin/api/active_docs/ID.xml?access_token=YOUR_ACCESS_TOKEN'


```csharp
Task<dynamic> UpdateAdminApiActiveDocsXmlById(string accessToken, int id, string body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int id = 246;
string body = "body";

dynamic result = await activeDocs.UpdateAdminApiActiveDocsXmlById(accessToken, id, body);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="nginx_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.NginxController") NginxController

#### Get singleton instance

The singleton instance of the ``` NginxController ``` class can be accessed from the API Client.

```csharp
NginxController nginx = client.Nginx;
```

#### <a name="get_admin_api_nginx_zip"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.NginxController.GetAdminApiNginxZip") GetAdminApiNginxZip

> *Tags:*  ``` Skips Authentication ``` 

> Returns the Nginx configuration files in a zip archive.


```csharp
Task<dynamic> GetAdminApiNginxZip(string accessToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";

dynamic result = await nginx.GetAdminApiNginxZip(accessToken);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="account_plan_feature_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanFeatureController") AccountPlanFeatureController

#### Get singleton instance

The singleton instance of the ``` AccountPlanFeatureController ``` class can be accessed from the API Client.

```csharp
AccountPlanFeatureController accountPlanFeature = client.AccountPlanFeature;
```

#### <a name="delete_admin_api_account_plans_features_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanFeatureController.DeleteAdminApiAccountPlansFeaturesXml") DeleteAdminApiAccountPlansFeaturesXml

> *Tags:*  ``` Skips Authentication ``` 

> Deletes the association of an account feature to an account plan.


```csharp
Task<dynamic> DeleteAdminApiAccountPlansFeaturesXml(string accessToken, int accountPlanId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountPlanId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountPlanId = 246;
int id = 246;

dynamic result = await accountPlanFeature.DeleteAdminApiAccountPlansFeaturesXml(accessToken, accountPlanId, id);

```


#### <a name="create_admin_api_account_plans_features_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanFeatureController.CreateAdminApiAccountPlansFeaturesXml") CreateAdminApiAccountPlansFeaturesXml

> *Tags:*  ``` Skips Authentication ``` 

> Associate an account feature to an account plan.


```csharp
Task<dynamic> CreateAdminApiAccountPlansFeaturesXml(string accessToken, int accountPlanId, int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountPlanId |  ``` Required ```  | TODO: Add a parameter description |
| id |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountPlanId = 246;
int id = 246;

dynamic result = await accountPlanFeature.CreateAdminApiAccountPlansFeaturesXml(accessToken, accountPlanId, id);

```


#### <a name="get_admin_api_account_plans_features_xml"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAccountManagement.PCL.Controllers.AccountPlanFeatureController.GetAdminApiAccountPlansFeaturesXml") GetAdminApiAccountPlansFeaturesXml

> *Tags:*  ``` Skips Authentication ``` 

> Returns the list of the features associated to an account plan.


```csharp
Task<dynamic> GetAdminApiAccountPlansFeaturesXml(string accessToken, int accountPlanId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| accountPlanId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string accessToken = "access_token";
int accountPlanId = 246;

dynamic result = await accountPlanFeature.GetAdminApiAccountPlansFeaturesXml(accessToken, accountPlanId);

```


[Back to List of Controllers](#list_of_controllers)



"# 3Scale-Account-Management-CSharp" 
