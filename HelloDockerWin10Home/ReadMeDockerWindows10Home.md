How to run Docker on Windows 10 Home edition

https://www.freecodecamp.org/news/how-to-run-docker-on-windows-10-home-edition/

#### Step 1: Installations
	1. Install Oracle VM VirtualBox.
	2. Install Chocolatey to use Windows PowerShall:
			>Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))
	3. Install docker-machine:
		>choco install docker-machine
	4. create a docker virtual machine called 'default'.
		>docker-machine create --driver virtualbox default
		
#### Step 2: Configurations
	1. configure which ports are exposed when running Docker containers
	
#### Step 3: Setting up Environment Variables
	1. set up Docker environment variables
		> docker-machine env default
		allows the Docker client and Docker Compose to communicate with the Docker Engine running in the Linux VM that we named "default"
	
		>docker-machine env --shell=powershell | Invoke-Expression
	
	2. use things such as docker-compose up
		>choco install docker-cli
			The install of docker-cli was successful.
		>choco install docker-compose
			The install of docker-compose was successful.



#### docker commands ===================
> docker images
>docker-machine stop
>docker-machine start

#### use docker vs2019 =================
the sample notejs / .Net Core MVC worked on my machine.
https://docs.docker.com/get-started/part2/
https://docs.docker.com/engine/examples/dotnetcore/
1. create asp.net core project:

2. Define Dockerfile on the solution folder:

3. Build and test your image
	> docker build --tag bulletinboard:1.0 .
	> docker build --tag hellodocker:1.0 .

4. Run your image as a container
	> docker run --publish 8000:8080 --detach --name bb bulletinboard:1.0
	> docker run -d -p 8000:80 --name netcoreapp hellodocker:1.0 

	http://localhost:8000/ 
5. Delete image:
	>docker rm --force bb
	>docker rm --force myapp
	
#### 




