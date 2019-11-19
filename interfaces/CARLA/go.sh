@echo off

echo Updating meta data

#curl http://carla-spice-dev.pathfinder.bcgov/swagger/v1/swagger.json > carla-spice.swagger
# curl http://localhost:5050/swagger/v1/swagger.json > carla-spice.swagger

echo Updating client

autorest Readme.md
