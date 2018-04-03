1. Startup project 1. identityServer,resource api,resource owner client
2. Open postmen

POST /connect/token HTTP/1.1
Host: localhost:5000
Content-Type: application/x-www-form-urlencoded
Cache-Control: no-cache
Postman-Token: 112db8cc-d1b2-4aaa-8a03-748702c8567e

client_id=ro.client&client_secret=secret&grant_type=password&username=alice&password=password&scope=api1