# Getting started

Pagarme API

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (PagarmeCoreApi.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=PagarmeCoreApi-CSharp&workspaceName=PagarmeCoreApi&projectName=PagarmeCoreApi.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the PagarmeCoreApi library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=PagarmeCoreApi-CSharp&workspaceName=PagarmeCoreApi&projectName=PagarmeCoreApi.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=PagarmeCoreApi-CSharp&workspaceName=PagarmeCoreApi&projectName=PagarmeCoreApi.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=PagarmeCoreApi-CSharp&workspaceName=PagarmeCoreApi&projectName=PagarmeCoreApi.Tests)

### 3. Add reference of the library project

In order to use the PagarmeCoreApi library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=PagarmeCoreApi-CSharp&workspaceName=PagarmeCoreApi&projectName=PagarmeCoreApi.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` PagarmeCoreApi.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```PagarmeCoreApi.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=PagarmeCoreApi-CSharp&workspaceName=PagarmeCoreApi&projectName=PagarmeCoreApi.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=PagarmeCoreApi-CSharp&workspaceName=PagarmeCoreApi&projectName=PagarmeCoreApi.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

PagarmeCoreApiClient client = new PagarmeCoreApiClient(basicAuthUserName, basicAuthPassword);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SubscriptionsController](#subscriptions_controller)
* [OrdersController](#orders_controller)
* [PlansController](#plans_controller)
* [InvoicesController](#invoices_controller)
* [CustomersController](#customers_controller)
* [ChargesController](#charges_controller)
* [RecipientsController](#recipients_controller)
* [TokensController](#tokens_controller)
* [TransactionsController](#transactions_controller)
* [TransfersController](#transfers_controller)

## <a name="subscriptions_controller"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController") SubscriptionsController

### Get singleton instance

The singleton instance of the ``` SubscriptionsController ``` class can be accessed from the API Client.

```csharp
ISubscriptionsController subscriptions = client.Subscriptions;
```

### <a name="update_subscription_card"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateSubscriptionCard") UpdateSubscriptionCard

> Updates the credit card from a subscription


```csharp
Task<PCL.Models.GetSubscriptionResponse> UpdateSubscriptionCard(string subscriptionId, PCL.Models.UpdateSubscriptionCardRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for updating a card |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.UpdateSubscriptionCardRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionCard(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_usage"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.DeleteUsage") DeleteUsage

> Deletes a usage


```csharp
Task<PCL.Models.GetUsageResponse> DeleteUsage(
        string subscriptionId,
        string itemId,
        string usageId,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| itemId |  ``` Required ```  | The subscription item id |
| usageId |  ``` Required ```  | The usage id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
string usageId = "usage_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetUsageResponse result = await subscriptions.DeleteUsage(subscriptionId, itemId, usageId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_discount"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.CreateDiscount") CreateDiscount

> Creates a discount


```csharp
Task<PCL.Models.GetDiscountResponse> CreateDiscount(string subscriptionId, PCL.Models.CreateDiscountRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for creating a discount |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.CreateDiscountRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetDiscountResponse result = await subscriptions.CreateDiscount(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_an_usage"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.CreateAnUsage") CreateAnUsage

> Create Usage


```csharp
Task<PCL.Models.GetUsageResponse> CreateAnUsage(string subscriptionId, string itemId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| itemId |  ``` Required ```  | Item id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetUsageResponse result = await subscriptions.CreateAnUsage(subscriptionId, itemId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_usages"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetUsages") GetUsages

> Lists all usages from a subscription item


```csharp
Task<PCL.Models.ListUsagesResponse> GetUsages(
        string subscriptionId,
        string itemId,
        int? page = null,
        int? size = null,
        string code = null,
        string mgroup = null,
        DateTime? usedSince = null,
        DateTime? usedUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| itemId |  ``` Required ```  | The subscription item id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| code |  ``` Optional ```  | Identification code in the client system |
| mgroup |  ``` Optional ```  | Identification group in the client system |
| usedSince |  ``` Optional ```  | TODO: Add a parameter description |
| usedUntil |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
int? page = 131;
int? size = 131;
string code = "code";
string mgroup = "group";
DateTime? usedSince = DateTime.Now();
DateTime? usedUntil = DateTime.Now();

PCL.Models.ListUsagesResponse result = await subscriptions.GetUsages(subscriptionId, itemId, page, size, code, mgroup, usedSince, usedUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_current_cycle_status"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateCurrentCycleStatus") UpdateCurrentCycleStatus

> UpdateCurrentCycleStatus


```csharp
Task UpdateCurrentCycleStatus(string subscriptionId, PCL.Models.UpdateCurrentCycleStatusRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| body |  ``` Required ```  | Request for updating the end date of the subscription current status |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.UpdateCurrentCycleStatusRequest();
string idempotencyKey = "idempotency-key";

await subscriptions.UpdateCurrentCycleStatus(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_payment_method"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateSubscriptionPaymentMethod") UpdateSubscriptionPaymentMethod

> Updates the payment method from a subscription


```csharp
Task<PCL.Models.GetSubscriptionResponse> UpdateSubscriptionPaymentMethod(string subscriptionId, PCL.Models.UpdateSubscriptionPaymentMethodRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for updating the paymentmethod from a subscription |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.UpdateSubscriptionPaymentMethodRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionPaymentMethod(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_discount"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.DeleteDiscount") DeleteDiscount

> Deletes a discount


```csharp
Task<PCL.Models.GetDiscountResponse> DeleteDiscount(string subscriptionId, string discountId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| discountId |  ``` Required ```  | Discount Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string discountId = "discount_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetDiscountResponse result = await subscriptions.DeleteDiscount(subscriptionId, discountId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscription_items"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetSubscriptionItems") GetSubscriptionItems

> Get Subscription Items


```csharp
Task<PCL.Models.ListSubscriptionItemsResponse> GetSubscriptionItems(
        string subscriptionId,
        int? page = null,
        int? size = null,
        string name = null,
        string code = null,
        string status = null,
        string description = null,
        string createdSince = null,
        string createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| name |  ``` Optional ```  | The item name |
| code |  ``` Optional ```  | Identification code in the client system |
| status |  ``` Optional ```  | The item statis |
| description |  ``` Optional ```  | The item description |
| createdSince |  ``` Optional ```  | Filter for item's creation date start range |
| createdUntil |  ``` Optional ```  | Filter for item's creation date end range |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
int? page = 131;
int? size = 131;
string name = "name";
string code = "code";
string status = "status";
string description = "description";
string createdSince = "created_since";
string createdUntil = "created_until";

PCL.Models.ListSubscriptionItemsResponse result = await subscriptions.GetSubscriptionItems(subscriptionId, page, size, name, code, status, description, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.CreateSubscriptionItem") CreateSubscriptionItem

> Creates a new Subscription item


```csharp
Task<PCL.Models.GetSubscriptionItemResponse> CreateSubscriptionItem(string subscriptionId, PCL.Models.CreateSubscriptionItemRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for creating a subscription item |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.CreateSubscriptionItemRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionItemResponse result = await subscriptions.CreateSubscriptionItem(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetSubscriptionItem") GetSubscriptionItem

> Get Subscription Item


```csharp
Task<PCL.Models.GetSubscriptionItemResponse> GetSubscriptionItem(string subscriptionId, string itemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| itemId |  ``` Required ```  | Item id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";

PCL.Models.GetSubscriptionItemResponse result = await subscriptions.GetSubscriptionItem(subscriptionId, itemId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateSubscriptionItem") UpdateSubscriptionItem

> Updates a subscription item


```csharp
Task<PCL.Models.GetSubscriptionItemResponse> UpdateSubscriptionItem(
        string subscriptionId,
        string itemId,
        PCL.Models.UpdateSubscriptionItemRequest body,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| itemId |  ``` Required ```  | Item id |
| body |  ``` Required ```  | Request for updating a subscription item |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
var body = new PCL.Models.UpdateSubscriptionItemRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionItemResponse result = await subscriptions.UpdateSubscriptionItem(subscriptionId, itemId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscriptions"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetSubscriptions") GetSubscriptions

> Gets all subscriptions


```csharp
Task<PCL.Models.ListSubscriptionsResponse> GetSubscriptions(
        int? page = null,
        int? size = null,
        string code = null,
        string billingType = null,
        string customerId = null,
        string planId = null,
        string cardId = null,
        string status = null,
        DateTime? nextBillingSince = null,
        DateTime? nextBillingUntil = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| code |  ``` Optional ```  | Filter for subscription's code |
| billingType |  ``` Optional ```  | Filter for subscription's billing type |
| customerId |  ``` Optional ```  | Filter for subscription's customer id |
| planId |  ``` Optional ```  | Filter for subscription's plan id |
| cardId |  ``` Optional ```  | Filter for subscription's card id |
| status |  ``` Optional ```  | Filter for subscription's status |
| nextBillingSince |  ``` Optional ```  | Filter for subscription's next billing date start range |
| nextBillingUntil |  ``` Optional ```  | Filter for subscription's next billing date end range |
| createdSince |  ``` Optional ```  | Filter for subscription's creation date start range |
| createdUntil |  ``` Optional ```  | Filter for subscriptions creation date end range |


#### Example Usage

```csharp
int? page = 131;
int? size = 131;
string code = "code";
string billingType = "billing_type";
string customerId = "customer_id";
string planId = "plan_id";
string cardId = "card_id";
string status = "status";
DateTime? nextBillingSince = DateTime.Now();
DateTime? nextBillingUntil = DateTime.Now();
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

PCL.Models.ListSubscriptionsResponse result = await subscriptions.GetSubscriptions(page, size, code, billingType, customerId, planId, cardId, status, nextBillingSince, nextBillingUntil, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_subscription"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.CreateSubscription") CreateSubscription

> Creates a new subscription


```csharp
Task<PCL.Models.GetSubscriptionResponse> CreateSubscription(PCL.Models.CreateSubscriptionRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a subscription |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new PCL.Models.CreateSubscriptionRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionResponse result = await subscriptions.CreateSubscription(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="cancel_subscription"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.CancelSubscription") CancelSubscription

> Cancels a subscription


```csharp
Task<PCL.Models.GetSubscriptionResponse> CancelSubscription(string subscriptionId, string idempotencyKey = null, PCL.Models.CreateCancelSubscriptionRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | Request for cancelling a subscription |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string idempotencyKey = "idempotency-key";
var body = new PCL.Models.CreateCancelSubscriptionRequest();

PCL.Models.GetSubscriptionResponse result = await subscriptions.CancelSubscription(subscriptionId, idempotencyKey, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscription"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetSubscription") GetSubscription

> Gets a subscription


```csharp
Task<PCL.Models.GetSubscriptionResponse> GetSubscription(string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";

PCL.Models.GetSubscriptionResponse result = await subscriptions.GetSubscription(subscriptionId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_increment"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.CreateIncrement") CreateIncrement

> Creates a increment


```csharp
Task<PCL.Models.GetIncrementResponse> CreateIncrement(string subscriptionId, PCL.Models.CreateIncrementRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for creating a increment |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.CreateIncrementRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetIncrementResponse result = await subscriptions.CreateIncrement(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_discount_by_id"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetDiscountById") GetDiscountById

> GetDiscountById


```csharp
Task<PCL.Models.GetDiscountResponse> GetDiscountById(string subscriptionId, string discountId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| discountId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string discountId = "discountId";

PCL.Models.GetDiscountResponse result = await subscriptions.GetDiscountById(subscriptionId, discountId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_affiliation_id"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateSubscriptionAffiliationId") UpdateSubscriptionAffiliationId

> UpdateSubscriptionAffiliationId


```csharp
Task<PCL.Models.GetSubscriptionResponse> UpdateSubscriptionAffiliationId(string subscriptionId, PCL.Models.UpdateSubscriptionAffiliationIdRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | Request for updating a subscription affiliation id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.UpdateSubscriptionAffiliationIdRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionAffiliationId(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_metadata"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateSubscriptionMetadata") UpdateSubscriptionMetadata

> Updates the metadata from a subscription


```csharp
Task<PCL.Models.GetSubscriptionResponse> UpdateSubscriptionMetadata(string subscriptionId, PCL.Models.UpdateMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| body |  ``` Required ```  | Request for updating the subscrption metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.UpdateMetadataRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionMetadata(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_increment"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.DeleteIncrement") DeleteIncrement

> Deletes a increment


```csharp
Task<PCL.Models.GetIncrementResponse> DeleteIncrement(string subscriptionId, string incrementId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| incrementId |  ``` Required ```  | Increment id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string incrementId = "increment_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetIncrementResponse result = await subscriptions.DeleteIncrement(subscriptionId, incrementId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_increment_by_id"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetIncrementById") GetIncrementById

> GetIncrementById


```csharp
Task<PCL.Models.GetIncrementResponse> GetIncrementById(string subscriptionId, string incrementId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription Id |
| incrementId |  ``` Required ```  | The increment Id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string incrementId = "increment_id";

PCL.Models.GetIncrementResponse result = await subscriptions.GetIncrementById(subscriptionId, incrementId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscription_cycles"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetSubscriptionCycles") GetSubscriptionCycles

> GetSubscriptionCycles


```csharp
Task<PCL.Models.ListCyclesResponse> GetSubscriptionCycles(string subscriptionId, string page, string size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| page |  ``` Required ```  | Page number |
| size |  ``` Required ```  | Page size |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string page = "page";
string size = "size";

PCL.Models.ListCyclesResponse result = await subscriptions.GetSubscriptionCycles(subscriptionId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="renew_subscription"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.RenewSubscription") RenewSubscription

> RenewSubscription


```csharp
Task<PCL.Models.GetPeriodResponse> RenewSubscription(string subscriptionId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | TODO: Add a parameter description |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetPeriodResponse result = await subscriptions.RenewSubscription(subscriptionId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_discounts"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetDiscounts") GetDiscounts

> GetDiscounts


```csharp
Task<PCL.Models.ListDiscountsResponse> GetDiscounts(string subscriptionId, int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| page |  ``` Required ```  | Page number |
| size |  ``` Required ```  | Page size |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
int page = 131;
int size = 131;

PCL.Models.ListDiscountsResponse result = await subscriptions.GetDiscounts(subscriptionId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_billing_date"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateSubscriptionBillingDate") UpdateSubscriptionBillingDate

> Updates the billing date from a subscription


```csharp
Task<PCL.Models.GetSubscriptionResponse> UpdateSubscriptionBillingDate(string subscriptionId, PCL.Models.UpdateSubscriptionBillingDateRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| body |  ``` Required ```  | Request for updating the subscription billing date |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.UpdateSubscriptionBillingDateRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionBillingDate(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.DeleteSubscriptionItem") DeleteSubscriptionItem

> Deletes a subscription item


```csharp
Task<PCL.Models.GetSubscriptionItemResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| subscriptionItemId |  ``` Required ```  | Subscription item id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string subscriptionItemId = "subscription_item_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionItemResponse result = await subscriptions.DeleteSubscriptionItem(subscriptionId, subscriptionItemId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_increments"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetIncrements") GetIncrements

> GetIncrements


```csharp
Task<PCL.Models.ListIncrementsResponse> GetIncrements(string subscriptionId, int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
int? page = 131;
int? size = 131;

PCL.Models.ListIncrementsResponse result = await subscriptions.GetIncrements(subscriptionId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_due_days"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateSubscriptionDueDays") UpdateSubscriptionDueDays

> Updates the boleto due days from a subscription


```csharp
Task<PCL.Models.GetSubscriptionResponse> UpdateSubscriptionDueDays(string subscriptionId, PCL.Models.UpdateSubscriptionDueDaysRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| body |  ``` Required ```  | TODO: Add a parameter description |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.UpdateSubscriptionDueDaysRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionDueDays(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_start_at"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateSubscriptionStartAt") UpdateSubscriptionStartAt

> Updates the start at date from a subscription


```csharp
Task<PCL.Models.GetSubscriptionResponse> UpdateSubscriptionStartAt(string subscriptionId, PCL.Models.UpdateSubscriptionStartAtRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| body |  ``` Required ```  | Request for updating the subscription start date |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.UpdateSubscriptionStartAtRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionStartAt(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_latest_period_end_at"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateLatestPeriodEndAt") UpdateLatestPeriodEndAt

> UpdateLatestPeriodEndAt


```csharp
Task<PCL.Models.GetSubscriptionResponse> UpdateLatestPeriodEndAt(string subscriptionId, PCL.Models.UpdateCurrentCycleEndDateRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | Request for updating the end date of the current signature cycle |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.UpdateCurrentCycleEndDateRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionResponse result = await subscriptions.UpdateLatestPeriodEndAt(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_subscription_minium_price"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateSubscriptionMiniumPrice") UpdateSubscriptionMiniumPrice

> Atualização do valor mínimo da assinatura


```csharp
Task<PCL.Models.GetSubscriptionResponse> UpdateSubscriptionMiniumPrice(string subscriptionId, PCL.Models.UpdateSubscriptionMinimumPriceRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| body |  ``` Required ```  | Request da requisição com o valor mínimo que será configurado |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new PCL.Models.UpdateSubscriptionMinimumPriceRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionMiniumPrice(subscriptionId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_subscription_cycle_by_id"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetSubscriptionCycleById") GetSubscriptionCycleById

> GetSubscriptionCycleById


```csharp
Task<PCL.Models.GetPeriodResponse> GetSubscriptionCycleById(string subscriptionId, string cycleId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription id |
| cycleId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string cycleId = "cycleId";

PCL.Models.GetPeriodResponse result = await subscriptions.GetSubscriptionCycleById(subscriptionId, cycleId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_usage_report"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.GetUsageReport") GetUsageReport

> GetUsageReport


```csharp
Task<PCL.Models.GetUsageReportResponse> GetUsageReport(string subscriptionId, string periodId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | The subscription Id |
| periodId |  ``` Required ```  | The period Id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string periodId = "period_id";

PCL.Models.GetUsageReportResponse result = await subscriptions.GetUsageReport(subscriptionId, periodId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_split_subscription"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.SubscriptionsController.UpdateSplitSubscription") UpdateSplitSubscription

> UpdateSplitSubscription


```csharp
Task<PCL.Models.GetSubscriptionResponse> UpdateSplitSubscription(string id, PCL.Models.UpdateSubscriptionSplitRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Subscription's id |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string id = "id";
var body = new PCL.Models.UpdateSubscriptionSplitRequest();

PCL.Models.GetSubscriptionResponse result = await subscriptions.UpdateSplitSubscription(id, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="orders_controller"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeCoreApi.Tests.Controllers.OrdersController") OrdersController

### Get singleton instance

The singleton instance of the ``` OrdersController ``` class can be accessed from the API Client.

```csharp
IOrdersController orders = client.Orders;
```

### <a name="get_orders"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.OrdersController.GetOrders") GetOrders

> Gets all orders


```csharp
Task<PCL.Models.ListOrderResponse> GetOrders(
        int? page = null,
        int? size = null,
        string code = null,
        string status = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null,
        string customerId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| code |  ``` Optional ```  | Filter for order's code |
| status |  ``` Optional ```  | Filter for order's status |
| createdSince |  ``` Optional ```  | Filter for order's creation date start range |
| createdUntil |  ``` Optional ```  | Filter for order's creation date end range |
| customerId |  ``` Optional ```  | Filter for order's customer id |


#### Example Usage

```csharp
int? page = 131;
int? size = 131;
string code = "code";
string status = "status";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();
string customerId = "customer_id";

PCL.Models.ListOrderResponse result = await orders.GetOrders(page, size, code, status, createdSince, createdUntil, customerId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_order"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.OrdersController.CreateOrder") CreateOrder

> Creates a new Order


```csharp
Task<PCL.Models.GetOrderResponse> CreateOrder(PCL.Models.CreateOrderRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating an order |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new PCL.Models.CreateOrderRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetOrderResponse result = await orders.CreateOrder(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_all_order_items"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.OrdersController.DeleteAllOrderItems") DeleteAllOrderItems

> DeleteAllOrderItems


```csharp
Task<PCL.Models.GetOrderResponse> DeleteAllOrderItems(string orderId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orderId = "orderId";
string idempotencyKey = "idempotency-key";

PCL.Models.GetOrderResponse result = await orders.DeleteAllOrderItems(orderId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_order_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.OrdersController.CreateOrderItem") CreateOrderItem

> CreateOrderItem


```csharp
Task<PCL.Models.GetOrderItemResponse> CreateOrderItem(string orderId, PCL.Models.CreateOrderItemRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| body |  ``` Required ```  | Order Item Model |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orderId = "orderId";
var body = new PCL.Models.CreateOrderItemRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetOrderItemResponse result = await orders.CreateOrderItem(orderId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_order_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.OrdersController.UpdateOrderItem") UpdateOrderItem

> UpdateOrderItem


```csharp
Task<PCL.Models.GetOrderItemResponse> UpdateOrderItem(
        string orderId,
        string itemId,
        PCL.Models.UpdateOrderItemRequest body,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| itemId |  ``` Required ```  | Item Id |
| body |  ``` Required ```  | Item Model |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orderId = "orderId";
string itemId = "itemId";
var body = new PCL.Models.UpdateOrderItemRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetOrderItemResponse result = await orders.UpdateOrderItem(orderId, itemId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_order_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.OrdersController.DeleteOrderItem") DeleteOrderItem

> DeleteOrderItem


```csharp
Task<PCL.Models.GetOrderItemResponse> DeleteOrderItem(string orderId, string itemId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| itemId |  ``` Required ```  | Item Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orderId = "orderId";
string itemId = "itemId";
string idempotencyKey = "idempotency-key";

PCL.Models.GetOrderItemResponse result = await orders.DeleteOrderItem(orderId, itemId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_order_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.OrdersController.GetOrderItem") GetOrderItem

> GetOrderItem


```csharp
Task<PCL.Models.GetOrderItemResponse> GetOrderItem(string orderId, string itemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order Id |
| itemId |  ``` Required ```  | Item Id |


#### Example Usage

```csharp
string orderId = "orderId";
string itemId = "itemId";

PCL.Models.GetOrderItemResponse result = await orders.GetOrderItem(orderId, itemId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="close_order"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.OrdersController.CloseOrder") CloseOrder

> CloseOrder


```csharp
Task<PCL.Models.GetOrderResponse> CloseOrder(string id, PCL.Models.UpdateOrderStatusRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Order Id |
| body |  ``` Required ```  | Update Order Model |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string id = "id";
var body = new PCL.Models.UpdateOrderStatusRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetOrderResponse result = await orders.CloseOrder(id, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_order_metadata"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.OrdersController.UpdateOrderMetadata") UpdateOrderMetadata

> Updates the metadata from an order


```csharp
Task<PCL.Models.GetOrderResponse> UpdateOrderMetadata(string orderId, PCL.Models.UpdateMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | The order id |
| body |  ``` Required ```  | Request for updating the order metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orderId = "order_id";
var body = new PCL.Models.UpdateMetadataRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetOrderResponse result = await orders.UpdateOrderMetadata(orderId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_order"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.OrdersController.GetOrder") GetOrder

> Gets an order


```csharp
Task<PCL.Models.GetOrderResponse> GetOrder(string orderId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order id |


#### Example Usage

```csharp
string orderId = "order_id";

PCL.Models.GetOrderResponse result = await orders.GetOrder(orderId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="plans_controller"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeCoreApi.Tests.Controllers.PlansController") PlansController

### Get singleton instance

The singleton instance of the ``` PlansController ``` class can be accessed from the API Client.

```csharp
IPlansController plans = client.Plans;
```

### <a name="get_plan"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.PlansController.GetPlan") GetPlan

> Gets a plan


```csharp
Task<PCL.Models.GetPlanResponse> GetPlan(string planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |


#### Example Usage

```csharp
string planId = "plan_id";

PCL.Models.GetPlanResponse result = await plans.GetPlan(planId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_plan"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.PlansController.UpdatePlan") UpdatePlan

> Updates a plan


```csharp
Task<PCL.Models.GetPlanResponse> UpdatePlan(string planId, PCL.Models.UpdatePlanRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| body |  ``` Required ```  | Request for updating a plan |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
var body = new PCL.Models.UpdatePlanRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetPlanResponse result = await plans.UpdatePlan(planId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_plan"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.PlansController.DeletePlan") DeletePlan

> Deletes a plan


```csharp
Task<PCL.Models.GetPlanResponse> DeletePlan(string planId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetPlanResponse result = await plans.DeletePlan(planId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_plan_metadata"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.PlansController.UpdatePlanMetadata") UpdatePlanMetadata

> Updates the metadata from a plan


```csharp
Task<PCL.Models.GetPlanResponse> UpdatePlanMetadata(string planId, PCL.Models.UpdateMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | The plan id |
| body |  ``` Required ```  | Request for updating the plan metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
var body = new PCL.Models.UpdateMetadataRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetPlanResponse result = await plans.UpdatePlanMetadata(planId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.PlansController.UpdatePlanItem") UpdatePlanItem

> Updates a plan item


```csharp
Task<PCL.Models.GetPlanItemResponse> UpdatePlanItem(
        string planId,
        string planItemId,
        PCL.Models.UpdatePlanItemRequest body,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| planItemId |  ``` Required ```  | Plan item id |
| body |  ``` Required ```  | Request for updating the plan item |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
string planItemId = "plan_item_id";
var body = new PCL.Models.UpdatePlanItemRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetPlanItemResponse result = await plans.UpdatePlanItem(planId, planItemId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.PlansController.GetPlanItem") GetPlanItem

> Gets a plan item


```csharp
Task<PCL.Models.GetPlanItemResponse> GetPlanItem(string planId, string planItemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| planItemId |  ``` Required ```  | Plan item id |


#### Example Usage

```csharp
string planId = "plan_id";
string planItemId = "plan_item_id";

PCL.Models.GetPlanItemResponse result = await plans.GetPlanItem(planId, planItemId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.PlansController.DeletePlanItem") DeletePlanItem

> Removes an item from a plan


```csharp
Task<PCL.Models.GetPlanItemResponse> DeletePlanItem(string planId, string planItemId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| planItemId |  ``` Required ```  | Plan item id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
string planItemId = "plan_item_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetPlanItemResponse result = await plans.DeletePlanItem(planId, planItemId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.PlansController.CreatePlanItem") CreatePlanItem

> Adds a new item to a plan


```csharp
Task<PCL.Models.GetPlanItemResponse> CreatePlanItem(string planId, PCL.Models.CreatePlanItemRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| body |  ``` Required ```  | Request for creating a plan item |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string planId = "plan_id";
var body = new PCL.Models.CreatePlanItemRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetPlanItemResponse result = await plans.CreatePlanItem(planId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_plan"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.PlansController.CreatePlan") CreatePlan

> Creates a new plan


```csharp
Task<PCL.Models.GetPlanResponse> CreatePlan(PCL.Models.CreatePlanRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a plan |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new PCL.Models.CreatePlanRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetPlanResponse result = await plans.CreatePlan(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_plans"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.PlansController.GetPlans") GetPlans

> Gets all plans


```csharp
Task<PCL.Models.ListPlansResponse> GetPlans(
        int? page = null,
        int? size = null,
        string name = null,
        string status = null,
        string billingType = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| name |  ``` Optional ```  | Filter for Plan's name |
| status |  ``` Optional ```  | Filter for Plan's status |
| billingType |  ``` Optional ```  | Filter for plan's billing type |
| createdSince |  ``` Optional ```  | Filter for plan's creation date start range |
| createdUntil |  ``` Optional ```  | Filter for plan's creation date end range |


#### Example Usage

```csharp
int? page = 131;
int? size = 131;
string name = "name";
string status = "status";
string billingType = "billing_type";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

PCL.Models.ListPlansResponse result = await plans.GetPlans(page, size, name, status, billingType, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="invoices_controller"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeCoreApi.Tests.Controllers.InvoicesController") InvoicesController

### Get singleton instance

The singleton instance of the ``` InvoicesController ``` class can be accessed from the API Client.

```csharp
IInvoicesController invoices = client.Invoices;
```

### <a name="get_partial_invoice"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.InvoicesController.GetPartialInvoice") GetPartialInvoice

> GetPartialInvoice


```csharp
Task<PCL.Models.GetInvoiceResponse> GetPartialInvoice(string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";

PCL.Models.GetInvoiceResponse result = await invoices.GetPartialInvoice(subscriptionId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="cancel_invoice"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.InvoicesController.CancelInvoice") CancelInvoice

> Cancels an invoice


```csharp
Task<PCL.Models.GetInvoiceResponse> CancelInvoice(string invoiceId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string invoiceId = "invoice_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetInvoiceResponse result = await invoices.CancelInvoice(invoiceId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_invoice"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.InvoicesController.GetInvoice") GetInvoice

> Gets an invoice


```csharp
Task<PCL.Models.GetInvoiceResponse> GetInvoice(string invoiceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice Id |


#### Example Usage

```csharp
string invoiceId = "invoice_id";

PCL.Models.GetInvoiceResponse result = await invoices.GetInvoice(invoiceId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_invoice"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.InvoicesController.CreateInvoice") CreateInvoice

> Create an Invoice


```csharp
Task<PCL.Models.GetInvoiceResponse> CreateInvoice(
        string subscriptionId,
        string cycleId,
        string idempotencyKey = null,
        PCL.Models.CreateInvoiceRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| cycleId |  ``` Required ```  | Cycle Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string cycleId = "cycle_id";
string idempotencyKey = "idempotency-key";
var body = new PCL.Models.CreateInvoiceRequest();

PCL.Models.GetInvoiceResponse result = await invoices.CreateInvoice(subscriptionId, cycleId, idempotencyKey, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_invoice_metadata"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.InvoicesController.UpdateInvoiceMetadata") UpdateInvoiceMetadata

> Updates the metadata from an invoice


```csharp
Task<PCL.Models.GetInvoiceResponse> UpdateInvoiceMetadata(string invoiceId, PCL.Models.UpdateMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | The invoice id |
| body |  ``` Required ```  | Request for updating the invoice metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string invoiceId = "invoice_id";
var body = new PCL.Models.UpdateMetadataRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetInvoiceResponse result = await invoices.UpdateInvoiceMetadata(invoiceId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_invoices"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.InvoicesController.GetInvoices") GetInvoices

> Gets all invoices


```csharp
Task<PCL.Models.ListInvoicesResponse> GetInvoices(
        int? page = null,
        int? size = null,
        string code = null,
        string customerId = null,
        string subscriptionId = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null,
        string status = null,
        DateTime? dueSince = null,
        DateTime? dueUntil = null,
        string customerDocument = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| code |  ``` Optional ```  | Filter for Invoice's code |
| customerId |  ``` Optional ```  | Filter for Invoice's customer id |
| subscriptionId |  ``` Optional ```  | Filter for Invoice's subscription id |
| createdSince |  ``` Optional ```  | Filter for Invoice's creation date start range |
| createdUntil |  ``` Optional ```  | Filter for Invoices creation date end range |
| status |  ``` Optional ```  | Filter for Invoice's status |
| dueSince |  ``` Optional ```  | Filter for Invoice's due date start range |
| dueUntil |  ``` Optional ```  | Filter for Invoice's due date end range |
| customerDocument |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int? page = 131;
int? size = 131;
string code = "code";
string customerId = "customer_id";
string subscriptionId = "subscription_id";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();
string status = "status";
DateTime? dueSince = DateTime.Now();
DateTime? dueUntil = DateTime.Now();
string customerDocument = "customer_document";

PCL.Models.ListInvoicesResponse result = await invoices.GetInvoices(page, size, code, customerId, subscriptionId, createdSince, createdUntil, status, dueSince, dueUntil, customerDocument);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_invoice_status"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.InvoicesController.UpdateInvoiceStatus") UpdateInvoiceStatus

> Updates the status from an invoice


```csharp
Task<PCL.Models.GetInvoiceResponse> UpdateInvoiceStatus(string invoiceId, PCL.Models.UpdateInvoiceStatusRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice Id |
| body |  ``` Required ```  | Request for updating an invoice's status |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string invoiceId = "invoice_id";
var body = new PCL.Models.UpdateInvoiceStatusRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetInvoiceResponse result = await invoices.UpdateInvoiceStatus(invoiceId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="customers_controller"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeCoreApi.Tests.Controllers.CustomersController") CustomersController

### Get singleton instance

The singleton instance of the ``` CustomersController ``` class can be accessed from the API Client.

```csharp
ICustomersController customers = client.Customers;
```

### <a name="update_card"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.UpdateCard") UpdateCard

> Updates a card


```csharp
Task<PCL.Models.GetCardResponse> UpdateCard(
        string customerId,
        string cardId,
        PCL.Models.UpdateCardRequest body,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| cardId |  ``` Required ```  | Card id |
| body |  ``` Required ```  | Request for updating a card |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";
var body = new PCL.Models.UpdateCardRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetCardResponse result = await customers.UpdateCard(customerId, cardId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_card"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.DeleteCard") DeleteCard

> Delete a customer's card


```csharp
Task<PCL.Models.GetCardResponse> DeleteCard(string customerId, string cardId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| cardId |  ``` Required ```  | Card Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetCardResponse result = await customers.DeleteCard(customerId, cardId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_card"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.GetCard") GetCard

> Get a customer's card


```csharp
Task<PCL.Models.GetCardResponse> GetCard(string customerId, string cardId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| cardId |  ``` Required ```  | Card id |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";

PCL.Models.GetCardResponse result = await customers.GetCard(customerId, cardId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_address"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.UpdateAddress") UpdateAddress

> Updates an address


```csharp
Task<PCL.Models.GetAddressResponse> UpdateAddress(
        string customerId,
        string addressId,
        PCL.Models.UpdateAddressRequest body,
        string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| addressId |  ``` Required ```  | Address Id |
| body |  ``` Required ```  | Request for updating an address |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";
var body = new PCL.Models.UpdateAddressRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetAddressResponse result = await customers.UpdateAddress(customerId, addressId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_address"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.GetAddress") GetAddress

> Get a customer's address


```csharp
Task<PCL.Models.GetAddressResponse> GetAddress(string customerId, string addressId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| addressId |  ``` Required ```  | Address Id |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";

PCL.Models.GetAddressResponse result = await customers.GetAddress(customerId, addressId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_address"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.DeleteAddress") DeleteAddress

> Delete a Customer's address


```csharp
Task<PCL.Models.GetAddressResponse> DeleteAddress(string customerId, string addressId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| addressId |  ``` Required ```  | Address Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetAddressResponse result = await customers.DeleteAddress(customerId, addressId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_access_token"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.DeleteAccessToken") DeleteAccessToken

> Delete a customer's access token


```csharp
Task<PCL.Models.GetAccessTokenResponse> DeleteAccessToken(string customerId, string tokenId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| tokenId |  ``` Required ```  | Token Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string tokenId = "token_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetAccessTokenResponse result = await customers.DeleteAccessToken(customerId, tokenId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_access_token"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.GetAccessToken") GetAccessToken

> Get a Customer's access token


```csharp
Task<PCL.Models.GetAccessTokenResponse> GetAccessToken(string customerId, string tokenId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| tokenId |  ``` Required ```  | Token Id |


#### Example Usage

```csharp
string customerId = "customer_id";
string tokenId = "token_id";

PCL.Models.GetAccessTokenResponse result = await customers.GetAccessToken(customerId, tokenId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_access_token"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.CreateAccessToken") CreateAccessToken

> Creates a access token for a customer


```csharp
Task<PCL.Models.GetAccessTokenResponse> CreateAccessToken(string customerId, PCL.Models.CreateAccessTokenRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| body |  ``` Required ```  | Request for creating a access token |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new PCL.Models.CreateAccessTokenRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetAccessTokenResponse result = await customers.CreateAccessToken(customerId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_access_tokens"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.GetAccessTokens") GetAccessTokens

> Get all access tokens from a customer


```csharp
Task<PCL.Models.ListAccessTokensResponse> GetAccessTokens(string customerId, int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
string customerId = "customer_id";
int? page = 90;
int? size = 90;

PCL.Models.ListAccessTokensResponse result = await customers.GetAccessTokens(customerId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_address"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.CreateAddress") CreateAddress

> Creates a new address for a customer


```csharp
Task<PCL.Models.GetAddressResponse> CreateAddress(string customerId, PCL.Models.CreateAddressRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| body |  ``` Required ```  | Request for creating an address |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new PCL.Models.CreateAddressRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetAddressResponse result = await customers.CreateAddress(customerId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_addresses"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.GetAddresses") GetAddresses

> Gets all adressess from a customer


```csharp
Task<PCL.Models.ListAddressesResponse> GetAddresses(string customerId, int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
string customerId = "customer_id";
int? page = 90;
int? size = 90;

PCL.Models.ListAddressesResponse result = await customers.GetAddresses(customerId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_customer"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.CreateCustomer") CreateCustomer

> Creates a new customer


```csharp
Task<PCL.Models.GetCustomerResponse> CreateCustomer(PCL.Models.CreateCustomerRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a customer |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new PCL.Models.CreateCustomerRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetCustomerResponse result = await customers.CreateCustomer(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_customers"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.GetCustomers") GetCustomers

> Get all Customers


```csharp
Task<PCL.Models.ListCustomersResponse> GetCustomers(
        string name = null,
        string document = null,
        int? page = 1,
        int? size = 10,
        string email = null,
        string code = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | Name of the Customer |
| document |  ``` Optional ```  | Document of the Customer |
| page |  ``` Optional ```  ``` DefaultValue ```  | Current page the the search |
| size |  ``` Optional ```  ``` DefaultValue ```  | Quantity pages of the search |
| email |  ``` Optional ```  | Customer's email |
| code |  ``` Optional ```  | Customer's code |


#### Example Usage

```csharp
string name = "name";
string document = "document";
int? page = 1;
int? size = 10;
string email = "email";
string code = "Code";

PCL.Models.ListCustomersResponse result = await customers.GetCustomers(name, document, page, size, email, code);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="delete_access_tokens"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.DeleteAccessTokens") DeleteAccessTokens

> Delete a Customer's access tokens


```csharp
Task<PCL.Models.ListAccessTokensResponse> DeleteAccessTokens(string customerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |


#### Example Usage

```csharp
string customerId = "customer_id";

PCL.Models.ListAccessTokensResponse result = await customers.DeleteAccessTokens(customerId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_card"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.CreateCard") CreateCard

> Creates a new card for a customer


```csharp
Task<PCL.Models.GetCardResponse> CreateCard(string customerId, PCL.Models.CreateCardRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| body |  ``` Required ```  | Request for creating a card |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new PCL.Models.CreateCardRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetCardResponse result = await customers.CreateCard(customerId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_cards"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.GetCards") GetCards

> Get all cards from a customer


```csharp
Task<PCL.Models.ListCardsResponse> GetCards(string customerId, int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
string customerId = "customer_id";
int? page = 90;
int? size = 90;

PCL.Models.ListCardsResponse result = await customers.GetCards(customerId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_customer"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.UpdateCustomer") UpdateCustomer

> Updates a customer


```csharp
Task<PCL.Models.GetCustomerResponse> UpdateCustomer(string customerId, PCL.Models.UpdateCustomerRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| body |  ``` Required ```  | Request for updating a customer |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new PCL.Models.UpdateCustomerRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetCustomerResponse result = await customers.UpdateCustomer(customerId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_customer"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.GetCustomer") GetCustomer

> Get a customer


```csharp
Task<PCL.Models.GetCustomerResponse> GetCustomer(string customerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |


#### Example Usage

```csharp
string customerId = "customer_id";

PCL.Models.GetCustomerResponse result = await customers.GetCustomer(customerId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="renew_card"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.RenewCard") RenewCard

> Renew a card


```csharp
Task<PCL.Models.GetCardResponse> RenewCard(string customerId, string cardId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| cardId |  ``` Required ```  | Card Id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetCardResponse result = await customers.RenewCard(customerId, cardId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_customer_metadata"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.CustomersController.UpdateCustomerMetadata") UpdateCustomerMetadata

> Updates the metadata a customer


```csharp
Task<PCL.Models.GetCustomerResponse> UpdateCustomerMetadata(string customerId, PCL.Models.UpdateMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | The customer id |
| body |  ``` Required ```  | Request for updating the customer metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new PCL.Models.UpdateMetadataRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetCustomerResponse result = await customers.UpdateCustomerMetadata(customerId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="charges_controller"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeCoreApi.Tests.Controllers.ChargesController") ChargesController

### Get singleton instance

The singleton instance of the ``` ChargesController ``` class can be accessed from the API Client.

```csharp
IChargesController charges = client.Charges;
```

### <a name="update_charge_metadata"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.UpdateChargeMetadata") UpdateChargeMetadata

> Updates the metadata from a charge


```csharp
Task<PCL.Models.GetChargeResponse> UpdateChargeMetadata(string chargeId, PCL.Models.UpdateMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | The charge id |
| body |  ``` Required ```  | Request for updating the charge metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string chargeId = "charge_id";
var body = new PCL.Models.UpdateMetadataRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetChargeResponse result = await charges.UpdateChargeMetadata(chargeId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="capture_charge"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.CaptureCharge") CaptureCharge

> Captures a charge


```csharp
Task<PCL.Models.GetChargeResponse> CaptureCharge(string chargeId, string idempotencyKey = null, PCL.Models.CreateCaptureChargeRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | Request for capturing a charge |


#### Example Usage

```csharp
string chargeId = "charge_id";
string idempotencyKey = "idempotency-key";
var body = new PCL.Models.CreateCaptureChargeRequest();

PCL.Models.GetChargeResponse result = await charges.CaptureCharge(chargeId, idempotencyKey, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_charge_payment_method"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.UpdateChargePaymentMethod") UpdateChargePaymentMethod

> Updates a charge's payment method


```csharp
Task<PCL.Models.GetChargeResponse> UpdateChargePaymentMethod(string chargeId, PCL.Models.UpdateChargePaymentMethodRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| body |  ``` Required ```  | Request for updating the payment method from a charge |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string chargeId = "charge_id";
var body = new PCL.Models.UpdateChargePaymentMethodRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetChargeResponse result = await charges.UpdateChargePaymentMethod(chargeId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_charge_transactions"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.GetChargeTransactions") GetChargeTransactions

> GetChargeTransactions


```csharp
Task<PCL.Models.ListChargeTransactionsResponse> GetChargeTransactions(string chargeId, int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge Id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
string chargeId = "charge_id";
int? page = 90;
int? size = 90;

PCL.Models.ListChargeTransactionsResponse result = await charges.GetChargeTransactions(chargeId, page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_charge_due_date"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.UpdateChargeDueDate") UpdateChargeDueDate

> Updates the due date from a charge


```csharp
Task<PCL.Models.GetChargeResponse> UpdateChargeDueDate(string chargeId, PCL.Models.UpdateChargeDueDateRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge Id |
| body |  ``` Required ```  | Request for updating the due date |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string chargeId = "charge_id";
var body = new PCL.Models.UpdateChargeDueDateRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetChargeResponse result = await charges.UpdateChargeDueDate(chargeId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_charges"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.GetCharges") GetCharges

> Lists all charges


```csharp
Task<PCL.Models.ListChargesResponse> GetCharges(
        int? page = null,
        int? size = null,
        string code = null,
        string status = null,
        string paymentMethod = null,
        string customerId = null,
        string orderId = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| code |  ``` Optional ```  | Filter for charge's code |
| status |  ``` Optional ```  | Filter for charge's status |
| paymentMethod |  ``` Optional ```  | Filter for charge's payment method |
| customerId |  ``` Optional ```  | Filter for charge's customer id |
| orderId |  ``` Optional ```  | Filter for charge's order id |
| createdSince |  ``` Optional ```  | Filter for the beginning of the range for charge's creation |
| createdUntil |  ``` Optional ```  | Filter for the end of the range for charge's creation |


#### Example Usage

```csharp
int? page = 90;
int? size = 90;
string code = "code";
string status = "status";
string paymentMethod = "payment_method";
string customerId = "customer_id";
string orderId = "order_id";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

PCL.Models.ListChargesResponse result = await charges.GetCharges(page, size, code, status, paymentMethod, customerId, orderId, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_charge_card"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.UpdateChargeCard") UpdateChargeCard

> Updates the card from a charge


```csharp
Task<PCL.Models.GetChargeResponse> UpdateChargeCard(string chargeId, PCL.Models.UpdateChargeCardRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| body |  ``` Required ```  | Request for updating a charge's card |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string chargeId = "charge_id";
var body = new PCL.Models.UpdateChargeCardRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetChargeResponse result = await charges.UpdateChargeCard(chargeId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_charge"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.GetCharge") GetCharge

> Get a charge from its id


```csharp
Task<PCL.Models.GetChargeResponse> GetCharge(string chargeId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |


#### Example Usage

```csharp
string chargeId = "charge_id";

PCL.Models.GetChargeResponse result = await charges.GetCharge(chargeId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="cancel_charge"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.CancelCharge") CancelCharge

> Cancel a charge


```csharp
Task<PCL.Models.GetChargeResponse> CancelCharge(string chargeId, string idempotencyKey = null, PCL.Models.CreateCancelChargeRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | Request for cancelling a charge |


#### Example Usage

```csharp
string chargeId = "charge_id";
string idempotencyKey = "idempotency-key";
var body = new PCL.Models.CreateCancelChargeRequest();

PCL.Models.GetChargeResponse result = await charges.CancelCharge(chargeId, idempotencyKey, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_charges_summary"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.GetChargesSummary") GetChargesSummary

> GetChargesSummary


```csharp
Task<PCL.Models.GetChargesSummaryResponse> GetChargesSummary(string status, DateTime? createdSince = null, DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| status |  ``` Required ```  | TODO: Add a parameter description |
| createdSince |  ``` Optional ```  | TODO: Add a parameter description |
| createdUntil |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string status = "status";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

PCL.Models.GetChargesSummaryResponse result = await charges.GetChargesSummary(status, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="retry_charge"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.RetryCharge") RetryCharge

> Retries a charge


```csharp
Task<PCL.Models.GetChargeResponse> RetryCharge(string chargeId, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string chargeId = "charge_id";
string idempotencyKey = "idempotency-key";

PCL.Models.GetChargeResponse result = await charges.RetryCharge(chargeId, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_charge"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.CreateCharge") CreateCharge

> Creates a new charge


```csharp
Task<PCL.Models.GetChargeResponse> CreateCharge(PCL.Models.CreateChargeRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a charge |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new PCL.Models.CreateChargeRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetChargeResponse result = await charges.CreateCharge(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="confirm_payment"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.ChargesController.ConfirmPayment") ConfirmPayment

> ConfirmPayment


```csharp
Task<PCL.Models.GetChargeResponse> ConfirmPayment(string chargeId, string idempotencyKey = null, PCL.Models.CreateConfirmPaymentRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | TODO: Add a parameter description |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| body |  ``` Optional ```  | Request for confirm payment |


#### Example Usage

```csharp
string chargeId = "charge_id";
string idempotencyKey = "idempotency-key";
var body = new PCL.Models.CreateConfirmPaymentRequest();

PCL.Models.GetChargeResponse result = await charges.ConfirmPayment(chargeId, idempotencyKey, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="recipients_controller"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeCoreApi.Tests.Controllers.RecipientsController") RecipientsController

### Get singleton instance

The singleton instance of the ``` RecipientsController ``` class can be accessed from the API Client.

```csharp
IRecipientsController recipients = client.Recipients;
```

### <a name="get_transfer"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetTransfer") GetTransfer

> Gets a transfer


```csharp
Task<PCL.Models.GetTransferResponse> GetTransfer(string recipientId, string transferId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| transferId |  ``` Required ```  | Transfer id |


#### Example Usage

```csharp
string recipientId = "recipient_id";
string transferId = "transfer_id";

PCL.Models.GetTransferResponse result = await recipients.GetTransfer(recipientId, transferId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_recipient"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.UpdateRecipient") UpdateRecipient

> Updates a recipient


```csharp
Task<PCL.Models.GetRecipientResponse> UpdateRecipient(string recipientId, PCL.Models.UpdateRecipientRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| body |  ``` Required ```  | Recipient data |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new PCL.Models.UpdateRecipientRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetRecipientResponse result = await recipients.UpdateRecipient(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_recipient"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetRecipient") GetRecipient

> Retrieves recipient information


```csharp
Task<PCL.Models.GetRecipientResponse> GetRecipient(string recipientId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipiend id |


#### Example Usage

```csharp
string recipientId = "recipient_id";

PCL.Models.GetRecipientResponse result = await recipients.GetRecipient(recipientId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_anticipation"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.CreateAnticipation") CreateAnticipation

> Creates an anticipation


```csharp
Task<PCL.Models.GetAnticipationResponse> CreateAnticipation(string recipientId, PCL.Models.CreateAnticipationRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| body |  ``` Required ```  | Anticipation data |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new PCL.Models.CreateAnticipationRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetAnticipationResponse result = await recipients.CreateAnticipation(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_anticipations"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetAnticipations") GetAnticipations

> Retrieves a paginated list of anticipations from a recipient


```csharp
Task<PCL.Models.ListAnticipationResponse> GetAnticipations(
        string recipientId,
        int? page = null,
        int? size = null,
        string status = null,
        string timeframe = null,
        DateTime? paymentDateSince = null,
        DateTime? paymentDateUntil = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| status |  ``` Optional ```  | Filter for anticipation status |
| timeframe |  ``` Optional ```  | Filter for anticipation timeframe |
| paymentDateSince |  ``` Optional ```  | Filter for start range for anticipation payment date |
| paymentDateUntil |  ``` Optional ```  | Filter for end range for anticipation payment date |
| createdSince |  ``` Optional ```  | Filter for start range for anticipation creation date |
| createdUntil |  ``` Optional ```  | Filter for end range for anticipation creation date |


#### Example Usage

```csharp
string recipientId = "recipient_id";
int? page = 90;
int? size = 90;
string status = "status";
string timeframe = "timeframe";
DateTime? paymentDateSince = DateTime.Now();
DateTime? paymentDateUntil = DateTime.Now();
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

PCL.Models.ListAnticipationResponse result = await recipients.GetAnticipations(recipientId, page, size, status, timeframe, paymentDateSince, paymentDateUntil, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_anticipation_limits"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetAnticipationLimits") GetAnticipationLimits

> Gets the anticipation limits for a recipient


```csharp
Task<PCL.Models.GetAnticipationLimitResponse> GetAnticipationLimits(string recipientId, string timeframe, DateTime paymentDate)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| timeframe |  ``` Required ```  | Timeframe |
| paymentDate |  ``` Required ```  | Anticipation payment date |


#### Example Usage

```csharp
string recipientId = "recipient_id";
string timeframe = "timeframe";
DateTime paymentDate = DateTime.Now();

PCL.Models.GetAnticipationLimitResponse result = await recipients.GetAnticipationLimits(recipientId, timeframe, paymentDate);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_recipients"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetRecipients") GetRecipients

> Retrieves paginated recipients information


```csharp
Task<PCL.Models.ListRecipientResponse> GetRecipients(int? page = null, int? size = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |


#### Example Usage

```csharp
int? page = 90;
int? size = 90;

PCL.Models.ListRecipientResponse result = await recipients.GetRecipients(page, size);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_recipient"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.CreateRecipient") CreateRecipient

> Creates a new recipient


```csharp
Task<PCL.Models.GetRecipientResponse> CreateRecipient(PCL.Models.CreateRecipientRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Recipient data |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new PCL.Models.CreateRecipientRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetRecipientResponse result = await recipients.CreateRecipient(body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_withdraw_by_id"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetWithdrawById") GetWithdrawById

> GetWithdrawById


```csharp
Task<PCL.Models.GetWithdrawResponse> GetWithdrawById(string recipientId, string withdrawalId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | TODO: Add a parameter description |
| withdrawalId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
string withdrawalId = "withdrawal_id";

PCL.Models.GetWithdrawResponse result = await recipients.GetWithdrawById(recipientId, withdrawalId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_recipient_default_bank_account"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.UpdateRecipientDefaultBankAccount") UpdateRecipientDefaultBankAccount

> Updates the default bank account from a recipient


```csharp
Task<PCL.Models.GetRecipientResponse> UpdateRecipientDefaultBankAccount(string recipientId, PCL.Models.UpdateRecipientBankAccountRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| body |  ``` Required ```  | Bank account data |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new PCL.Models.UpdateRecipientBankAccountRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetRecipientResponse result = await recipients.UpdateRecipientDefaultBankAccount(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_recipient_metadata"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.UpdateRecipientMetadata") UpdateRecipientMetadata

> Updates recipient metadata


```csharp
Task<PCL.Models.GetRecipientResponse> UpdateRecipientMetadata(string recipientId, PCL.Models.UpdateMetadataRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| body |  ``` Required ```  | Metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new PCL.Models.UpdateMetadataRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetRecipientResponse result = await recipients.UpdateRecipientMetadata(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_transfers"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetTransfers") GetTransfers

> Gets a paginated list of transfers for the recipient


```csharp
Task<PCL.Models.ListTransferResponse> GetTransfers(
        string recipientId,
        int? page = null,
        int? size = null,
        string status = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| page |  ``` Optional ```  | Page number |
| size |  ``` Optional ```  | Page size |
| status |  ``` Optional ```  | Filter for transfer status |
| createdSince |  ``` Optional ```  | Filter for start range of transfer creation date |
| createdUntil |  ``` Optional ```  | Filter for end range of transfer creation date |


#### Example Usage

```csharp
string recipientId = "recipient_id";
int? page = 90;
int? size = 90;
string status = "status";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

PCL.Models.ListTransferResponse result = await recipients.GetTransfers(recipientId, page, size, status, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_transfer"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.CreateTransfer") CreateTransfer

> Creates a transfer for a recipient


```csharp
Task<PCL.Models.GetTransferResponse> CreateTransfer(string recipientId, PCL.Models.CreateTransferRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient Id |
| body |  ``` Required ```  | Transfer data |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new PCL.Models.CreateTransferRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetTransferResponse result = await recipients.CreateTransfer(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="create_withdraw"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.CreateWithdraw") CreateWithdraw

> CreateWithdraw


```csharp
Task<PCL.Models.GetWithdrawResponse> CreateWithdraw(string recipientId, PCL.Models.CreateWithdrawRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new PCL.Models.CreateWithdrawRequest();

PCL.Models.GetWithdrawResponse result = await recipients.CreateWithdraw(recipientId, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_withdrawals"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetWithdrawals") GetWithdrawals

> Gets a paginated list of transfers for the recipient


```csharp
Task<PCL.Models.ListWithdrawals> GetWithdrawals(
        string recipientId,
        int? page = null,
        int? size = null,
        string status = null,
        DateTime? createdSince = null,
        DateTime? createdUntil = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | TODO: Add a parameter description |
| page |  ``` Optional ```  | TODO: Add a parameter description |
| size |  ``` Optional ```  | TODO: Add a parameter description |
| status |  ``` Optional ```  | TODO: Add a parameter description |
| createdSince |  ``` Optional ```  | TODO: Add a parameter description |
| createdUntil |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
int? page = 90;
int? size = 90;
string status = "status";
DateTime? createdSince = DateTime.Now();
DateTime? createdUntil = DateTime.Now();

PCL.Models.ListWithdrawals result = await recipients.GetWithdrawals(recipientId, page, size, status, createdSince, createdUntil);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_automatic_anticipation_settings"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.UpdateAutomaticAnticipationSettings") UpdateAutomaticAnticipationSettings

> Updates recipient metadata


```csharp
Task<PCL.Models.GetRecipientResponse> UpdateAutomaticAnticipationSettings(string recipientId, PCL.Models.UpdateAutomaticAnticipationSettingsRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| body |  ``` Required ```  | Metadata |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new PCL.Models.UpdateAutomaticAnticipationSettingsRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetRecipientResponse result = await recipients.UpdateAutomaticAnticipationSettings(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_anticipation"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetAnticipation") GetAnticipation

> Gets an anticipation


```csharp
Task<PCL.Models.GetAnticipationResponse> GetAnticipation(string recipientId, string anticipationId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |
| anticipationId |  ``` Required ```  | Anticipation id |


#### Example Usage

```csharp
string recipientId = "recipient_id";
string anticipationId = "anticipation_id";

PCL.Models.GetAnticipationResponse result = await recipients.GetAnticipation(recipientId, anticipationId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="update_recipient_transfer_settings"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.UpdateRecipientTransferSettings") UpdateRecipientTransferSettings

> UpdateRecipientTransferSettings


```csharp
Task<PCL.Models.GetRecipientResponse> UpdateRecipientTransferSettings(string recipientId, PCL.Models.UpdateTransferSettingsRequest body, string idempotencyKey = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient Identificator |
| body |  ``` Required ```  | TODO: Add a parameter description |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var body = new PCL.Models.UpdateTransferSettingsRequest();
string idempotencyKey = "idempotency-key";

PCL.Models.GetRecipientResponse result = await recipients.UpdateRecipientTransferSettings(recipientId, body, idempotencyKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_balance"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetBalance") GetBalance

> Get balance information for a recipient


```csharp
Task<PCL.Models.GetBalanceResponse> GetBalance(string recipientId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | Recipient id |


#### Example Usage

```csharp
string recipientId = "recipient_id";

PCL.Models.GetBalanceResponse result = await recipients.GetBalance(recipientId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_recipient_by_code"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetRecipientByCode") GetRecipientByCode

> Retrieves recipient information


```csharp
Task<PCL.Models.GetRecipientResponse> GetRecipientByCode(string code)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| code |  ``` Required ```  | Recipient code |


#### Example Usage

```csharp
string code = "code";

PCL.Models.GetRecipientResponse result = await recipients.GetRecipientByCode(code);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_default_recipient"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.RecipientsController.GetDefaultRecipient") GetDefaultRecipient

> GetDefaultRecipient


```csharp
Task<PCL.Models.GetRecipientResponse> GetDefaultRecipient()
```

#### Example Usage

```csharp

PCL.Models.GetRecipientResponse result = await recipients.GetDefaultRecipient();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="tokens_controller"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeCoreApi.Tests.Controllers.TokensController") TokensController

### Get singleton instance

The singleton instance of the ``` TokensController ``` class can be accessed from the API Client.

```csharp
ITokensController tokens = client.Tokens;
```

### <a name="create_token"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.TokensController.CreateToken") CreateToken

> *Tags:*  ``` Skips Authentication ``` 

> CreateToken


```csharp
Task<PCL.Models.GetTokenResponse> CreateToken(
        string publicKey,
        PCL.Models.CreateTokenRequest body,
        string idempotencyKey = null,
        string appId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| publicKey |  ``` Required ```  | Public key |
| body |  ``` Required ```  | Request for creating a token |
| idempotencyKey |  ``` Optional ```  | TODO: Add a parameter description |
| appId |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string publicKey = "public_key";
var body = new PCL.Models.CreateTokenRequest();
string idempotencyKey = "idempotency-key";
string appId = "appId";

PCL.Models.GetTokenResponse result = await tokens.CreateToken(publicKey, body, idempotencyKey, appId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_token"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.TokensController.GetToken") GetToken

> *Tags:*  ``` Skips Authentication ``` 

> Gets a token from its id


```csharp
Task<PCL.Models.GetTokenResponse> GetToken(string id, string publicKey, string appId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Token id |
| publicKey |  ``` Required ```  | Public key |
| appId |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string id = "id";
string publicKey = "public_key";
string appId = "appId";

PCL.Models.GetTokenResponse result = await tokens.GetToken(id, publicKey, appId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="transactions_controller"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeCoreApi.Tests.Controllers.TransactionsController") TransactionsController

### Get singleton instance

The singleton instance of the ``` TransactionsController ``` class can be accessed from the API Client.

```csharp
ITransactionsController transactions = client.Transactions;
```

### <a name="get_transaction"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.TransactionsController.GetTransaction") GetTransaction

> GetTransaction


```csharp
Task<PCL.Models.GetTransactionResponse> GetTransaction(string transactionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transactionId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string transactionId = "transaction_id";

PCL.Models.GetTransactionResponse result = await transactions.GetTransaction(transactionId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="transfers_controller"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeCoreApi.Tests.Controllers.TransfersController") TransfersController

### Get singleton instance

The singleton instance of the ``` TransfersController ``` class can be accessed from the API Client.

```csharp
ITransfersController transfers = client.Transfers;
```

### <a name="get_transfer_by_id"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.TransfersController.GetTransferById") GetTransferById

> GetTransferById


```csharp
Task<PCL.Models.GetTransfer> GetTransferById(string transferId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transferId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string transferId = "transfer_id";

PCL.Models.GetTransfer result = await transfers.GetTransferById(transferId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="post_create_transfer"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.TransfersController.PostCreateTransfer") PostCreateTransfer

> CreateTransfer


```csharp
Task<PCL.Models.GetTransfer> PostCreateTransfer(PCL.Models.CreateTransfer body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new PCL.Models.CreateTransfer();

PCL.Models.GetTransfer result = await transfers.PostCreateTransfer(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


### <a name="get_transfers1"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeCoreApi.Tests.Controllers.TransfersController.GetTransfers1") GetTransfers1

> Gets all transfers


```csharp
Task<PCL.Models.ListTransfers> GetTransfers1()
```

#### Example Usage

```csharp

PCL.Models.ListTransfers result = await transfers.GetTransfers1();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Invalid request |
| 401 | Invalid API key |
| 404 | An informed resource was not found |
| 412 | Business validation error |
| 422 | Contract validation error |
| 500 | Internal server error |


[Back to List of Controllers](#list_of_controllers)



