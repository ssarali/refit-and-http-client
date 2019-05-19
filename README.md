# refit-vs-http-client

## Purpose
Experimenting with API calls using the Refit library and basic http clients.

## About Refit 
Refit is a library that turns a REST API into an interface. Each endpoint within the API must have an HTTP attribute (Post, Get, Delete, etc.) and relative URL. The relative URL of the resource is specified in the annotation. For example: 

### `[Get("/users/list")]`

The ApiAndRefit.Service project contains the Refit interface for GitHub's Markdown API endpoint (IApiService), in addition to a Factory class to be called when a component/class/project wants to use IApiService. Note: the Factory pattern is just one way to separate the responsibility of creating objects of other classes to another entity. Factory pattern can be called as a tool to implement dependancy injection.

The ApiAndRefit.Service.IntegrationTests project contains the class that calls GitHub's Markdown API endpoint (IApiService) through the service factory (ApiServiceFactory).

## About HTTP Clients
The ApiAndHttpClient.Service project also calls GitHub's Markdown endpoint but uses C#'s HTTP Client class to do so. Note that no dependancy injection pattern was used for the Http Client project as the ApiAndHttpClient.Service.IntegrationTests project directly calls the HTTP Client. 

## Helpful Links
https://github.com/reactiveui/refit?WT.mc_id=-blog-scottha
https://www.c-sharpcorner.com/article/calling-web-api-using-httpclient/
https://www.dotnetperls.com/httpclient
