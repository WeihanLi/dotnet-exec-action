#/bin/sh
echo $pwd
echo $1
echo $2
echo "executinig dotnet-exec $1 --args $2"
dotnet-exec $1 --args $2
