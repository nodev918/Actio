API -> Infrastructure -> Core

Actio 

API - gateway
Identity service - handling authentication and account
Activities service - storing the activities data

-

request -> HTTP API [gateway] -> service bus ->
add_activity -> [Activities service] -> activity_added
-> [HTTP API]

Identity service
Activities service


Actio.Api - MongoDB [CQRS]
Actio.Common -> Messages 
Actio.Services.Identity - MongoDB
Actio.Services.Activities - MongoDB

Actio.Tests
Actio.Tests.EndToEnd