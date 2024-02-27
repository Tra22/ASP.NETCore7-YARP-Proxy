# ASP.NETCore7-YARP-Proxy
ASP .NET Core Project for learning. Every one should be able to use this templae to build a ASP .NET Core web API with YARP or Yet Another Reverse Proxy.

### Key Functions 
1. Course and Student service
2. Swagger for API's Endpoint

## Getting Started
These instructions will get you to setup the project, install sdk and add package (CLI or Package manager console).

### Prerequisites
- Visual Studio 2022 or higher 
- .NET 7.x SDK 

### Installing
1.  Install .net SDK 7<br>
[Download .NET SDK here.](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks)
2.  Create new Web API's project (Please create main project with empty and add below to the main project)<br>
`dotnet new webapi –-name YARP.Proxy`<br>
`dotnet new webapi –-name Course.Api`<br>
`dotnet new webapi --name Student.Api`<br> 
3.  Add package to YARP.Proxy's project
     - YARP<br>
       `dotnet add package Yarp.ReverseProxy`
     - Microsoft Authentication with JWT
       `dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer -v 7.0.15`
## Languages and Tools
<div>
  <img src="https://github.com/devicons/devicon/blob/master/icons/dotnetcore/dotnetcore-original.svg" title="dotnet core" alt="dotnet core" width="40" height="40"/>&nbsp;
  <img src="https://github.com/devicons/devicon/blob/master/icons/csharp/csharp-original.svg" title="csharp" alt="csharp" width="40" height="40"/>&nbsp;
  <img src="https://tech.playgokids.com/static/e8a4378a27abb98db6f0f5314b64a399/f3583/migration-aspnet-with-yarp.png" title="yarp" alt="yarp" width="40" height="40"/>&nbsp;
</div>
