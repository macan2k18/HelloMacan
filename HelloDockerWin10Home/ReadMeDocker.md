#### Use Docker with VS2019 in local machine: 
    1. To install  "Docker Desktop";
    2. To create application to choose "Enable Docker Support" ;
        Including Include="Microsoft.VisualStudio.Azure.Containers.Tools.Targets"
    3. A "Dockerfile" is created. you can change it for Windows or Linux
        by "Docker Support..." menu.
    4. To create "docker-compose" project on Solution by 
        submenu "Container Orchestrator Support..."
    5. One solution only has one "docker-compose" project, all of projects are on the "docker-compose" project.
    6. You run your project on docker by select "Docker".

#### Docker Spec
```
https://docs.docker.com/docker-for-windows/install/
```

#### Use Docker image on container and delopy to Staging server / Cloud.

#### TODO

    1. Create Docker file by manualy Not use VS2019
    2.

#### Q&A
1. how to connect database?
2. Where is the Docker image on my local?
3. How to use docker Hub /Query to put images to staging server / Cloud?
4. The "Docker Desktop" is Docker Machine / Docker Engine?
5. What is "docker-compose"?
 

#### Container Tools in Visual Studio
```
https://docs.microsoft.com/en-us/visualstudio/containers/overview?view=vs-2019
```
#### Debug apps in a local Docker container
```
https://docs.microsoft.com/en-us/visualstudio/containers/edit-and-refresh?view=vs-2019
```

#### the Docker Toolbox is Docker Desktop
https://www.docker.com/products/docker-desktop

#### sample:
https://medium.com/@ducmeit/net-core-using-cqrs-pattern-with-mediatr-part-2-cc55763e83f0

A network-related or instance-specific error 
occurred while establishing a connection to SQL Server. 
The server was not found or was not accessible. 
Verify that the instance name is correct and that 
SQL Server is configured to allow remote connections. 
(provider: SQL Network Interfaces,
 error: 26 - Error Locating Server/Instance Specified)

A network-related or instance-specific error occurred while establishing a connection to SQL Server. 
The server was not found or was not accessible. 
Verify that the instance name is correct and that SQL Server is configured to allow 
remote connections. (provider: TCP Provider, error: 0 - 
No connection could be made because the target machine actively refused it.)

