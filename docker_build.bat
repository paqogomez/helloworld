docker build . -f ./src/Core/DockerFile.test -t helloworld --build-arg CACHEBUST=$(date) --network="host"
