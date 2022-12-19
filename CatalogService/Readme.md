<b>Explain the difference between terms: REST and RESTful. </b><br>
Rest - Representational state transfer (REST) is a style of software architecture.
Restful - describe that a service can fully correspond with rest architecture with 6 constraints
<br>

<b>What are the six constraints?</b><br>
1. Uniform Interface 
2. Stateless
3. Cacheable
4. Client-Server
5. Layered System
6. Code on Demand (optional)<br>

<b>Is HTTP the only protocol supported by REST?</b><br>
no, rest is just a architecture pattern and it does not configures protocol 

<b>HTTP Request Methods (the difference) and HTTP Response codes. What is idempotency?</b><br>
HTTP Request Methods represents verbs which mostly invoke crud operations 
meanwhile HTTP Response codes responsible for response statuses.
Idempotency - when making multiple identical requests has the same effect as making a single request<br>

<b>What are the advantages of statelessness in RESTful services?</b><br>
Statelessness means that every HTTP request happens in complete isolation.
When the client makes an HTTP request, it includes all information necessary 
for the server to fulfill the request.
Advantages:
1. Statelessness helps in scaling the APIs to millions of concurrent users by deploying it to multiple servers.
Any server can handle any request because there is no session related dependency.
2. Being stateless makes REST APIs less complex – by removing all server-side state synchronization logic.
3. A stateless API is also easy to cache as well. It improves the performance of applications.
4. The server never relies on information from previous requests from the client.

<b>What resource naming best practices are?</b><br>
1. Resources should have names that are represented by nouns and not actions (behaviors)
2. Resources should be named using plural form
<b>What is Richardson Maturity Model?</b><br>
The Richardson Maturity Model (RMM) is a heuristic maturity model
that can be used to better understand how mature a service 
is in terms of the REST architectural style.

Level 0

Services at this level are described as having a single URI, and using a single HTTP verb (usually POST). This is very characteristic of most Web Services (WS-*) in that this services would have a single URI accepting an HTTP POST request having an XML payload.

Level 1

Services at this level are described as having many URIs with a single HTTP verb. The primary difference between Level 0 and Level 1 is that Level 1 services expose multiple logical resources as opposed to a single resource.

Level 2

Services at this level are described as having many URI-addressable resources. Each addressable resource supports both multiple HTTP verbs and HTTP status codes.

Level 3

Services at this level are like Level 2 services that additionally support Hypermedia As The Engine Of Application State (HATEOAS). Therefore, representations of a resource will also contain links to other resources (the actions that can be performed relating to current resource).